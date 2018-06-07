using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Bye_Cycle
{
    public partial class Dashboard : Form
    {
        private int lastFollowCount;
        private int lastTrafficCount;
        private bool Reading;
        private Date selectedDate = null;
        private string exportPath = AppDomain.CurrentDomain.BaseDirectory + "DataDoNotTouch.Bye";
        private string prioritisedText = "How many bikes prioritised: ";

        Administration administration;
        Date date;
        System.Threading.Timer timerCom;

        private void UpdateDirectionChart()
        {
            chartDirectionsPerDay.Series["Direction"].Points.Clear();
            if (selectedDate == null) return;
            long leftCount = 0;
            long rightCount = 0;
            long unknownCount = 0;
            foreach (FollowSystemData data in selectedDate.FollowSystem.FollowSystemData)
            {
                switch (data.Direction)
                {
                    case Side.Left:
                        leftCount++;
                        break;
                    case Side.Right:
                        rightCount++;
                        break;
                    default:
                        unknownCount++;
                        break;
                }
            }
            chartDirectionsPerDay.Series["Direction"].Points.AddXY("Left", leftCount);
            chartDirectionsPerDay.Series["Direction"].Points.AddXY("Right", rightCount);
            chartDirectionsPerDay.Series["Direction"].Points.AddXY("Unknown", unknownCount);
        }

        private void UpdateOverAllDirectionsChart()
        {
            chartDirectionPreferedAll.Series["Direction"].Points.Clear();
            if (administration.Dates.Count == 0) return;
            long leftCount = 0;
            long rightCount = 0;
            long unknownCount = 0;
            foreach (Date date in administration.Dates)
            {
                switch (date.FollowSystem.PreferedSide)
                {
                    case Side.Left:
                        leftCount++;
                        break;
                    case Side.Right:
                        rightCount++;
                        break;
                    default:
                        unknownCount++;
                        break;
                }
            }
            chartDirectionPreferedAll.Series["Direction"].Points.AddXY("Left", leftCount);
            chartDirectionPreferedAll.Series["Direction"].Points.AddXY("Right", rightCount);
            chartDirectionPreferedAll.Series["Direction"].Points.AddXY("Unknown", unknownCount);
        }

        private void UpdatePriorityUsedChart()
        {
            chartPriorityUsed.Series.Clear();
            if (administration.Dates.Count == 0) return;
            foreach (Date date in administration.Dates)
            {
                string serie = date.GetDate().ToString("dd/MM/yyyy");
                chartPriorityUsed.Series.Add(serie);
                chartPriorityUsed.Series[serie].Points.Add(date.TrafficLight.BikesPrioritised);
            }
            chartPriorityUsed.ResetAutoValues();
        }

        private void UpdateAverageTimeChart()
        {
            chartAverageTimeNeeded.Series.Clear();
            if (administration.Dates.Count == 0) return;
            List<FollowSystemData> copyOfData = new List<FollowSystemData>(date.FollowSystem.FollowSystemData);
            foreach (Date date in administration.Dates)
            {
                string serie = date.GetDate().ToString("dd/MM/yyyy");
                chartAverageTimeNeeded.Series.Add(serie);
                double total = 0;
                foreach (FollowSystemData data in copyOfData)
                {
                    total += Math.Round((double)data.TimeLightsOn/1000, 2);
                }
                if (total == 0) return;
                double average = total / date.FollowSystem.FollowSystemData.Count;
                chartAverageTimeNeeded.Series[serie].Points.Add(average);
            }
            chartAverageTimeNeeded.ResetAutoValues();
        }

        private void GetValidDate(ref Date date)
        {
            DateTime dateInput = DateTime.Now;
            foreach (Date foundDate in administration.Dates)
            {
                if ((foundDate.GetDate().DayOfYear == dateInput.DayOfYear && foundDate.GetDate().Year == dateInput.Year))
                {
                    date = foundDate;
                    return;
                }
            }
            date = new Date();
            administration.Add(date);
        }

        private void UpdateCom(object args)
        {
            administration.Parser.ParseArduinoData(date);
        }

        public Dashboard()
        {
            InitializeComponent();
            administration = new Administration();
            backgroundWorkerTrafficlight.RunWorkerAsync();
            Reading = true;
            administration.Import(exportPath);
            GetValidDate(ref date);
            UpdateForm();
            timerCom = new System.Threading.Timer(UpdateCom, null, 10, 500);
        }

        
        private void UpdateForm()
        {
            try
            {
                administration.Save();
                listBoxData.Items.Clear();
                foreach (Date date in administration.Dates)
                {
                    listBoxData.Items.Add(date.GetDate().ToString("dd/MM/yyyy"));
                }
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (InvalidCastException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                UpdateFormFollowSystem();
                UpdatePriorityUsedChart();
            }
        }

        private void UpdateFormFollowSystem()
        {
            UpdateOverAllDirectionsChart();
            UpdateAverageTimeChart();
            UpdateDirectionChart();
            int selIndex = listBoxData.SelectedIndex;
            if ((selIndex < 0)) return;
            listBoxTimeLightsOn.Items.Clear();
            labelPefferedSideStatic.Text = "Prefered Side: " + selectedDate.FollowSystem.PreferedSide;
            List<FollowSystemData> copy = new List<FollowSystemData>(selectedDate.FollowSystem.FollowSystemData);
            copy.Reverse();
            foreach (FollowSystemData data in copy)
            {
                listBoxTimeLightsOn.Items.Add("Time: " + Math.Round((double)data.TimeLightsOn/1000, 2) + "s, Direction: "+ data.Direction.ToString());
            }
        }

        private void UpdateFormTrafficLight()
        {
            UpdatePriorityUsedChart();
            int selIndex = listBoxData.SelectedIndex;
            if ((selIndex < 0)) return;
            listBoxTotalTimeRain.Items.Clear();
            label1.Text = prioritisedText + selectedDate.TrafficLight.BikesPrioritised;
            List<TrafficLightData> copy = new List<TrafficLightData>(selectedDate.TrafficLight.TrafficLightData);
            copy.Reverse();
            foreach (TrafficLightData data in copy)
            {
                listBoxTotalTimeRain.Items.Add("Time: " + Math.Round((double)data.TotalTimeRain / 1000, 2) + "s");
            }
        }


        private void buttonFollowLightON_Click(object sender, EventArgs e)
        {
            try
            {
                Reading = false;
                administration.SendMessage(false);
                Reading = true;
            }
            catch (System.IO.IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFollowLightOFF_Click(object sender, EventArgs e)
        {
            try
            {
                Reading = false;
                administration.SendMessage(true);
                Reading = true;
            }
            catch (System.IO.IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            administration.Save();
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog
                {
                    InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString(),
                    Multiselect = false
                };

                if (open.ShowDialog() == DialogResult.OK)
                {
                    administration.Import(open.FileName);
                    GetValidDate(ref date);
                    UpdateForm();
                    MessageBox.Show("Load successful");
                }
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (IOException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (UnauthorizedAccessException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (NotSupportedException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog
                {
                    InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString(),
                    FileName = "DataOfByeCycle-" + DateTime.Today.Month + "-" + DateTime.Today.Day + "-" +
                               DateTime.Today.Year,
                    DefaultExt = ".Bye"
                };

                if (save.ShowDialog() == DialogResult.OK)
                {
                    administration.Export(save.FileName);
                    MessageBox.Show("Save successful");
                }
            }
            catch (IOException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (System.Security.SecurityException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (ArgumentNullException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (UnauthorizedAccessException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void listBoxData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxData.SelectedIndex >= 0) selectedDate = administration.Dates[listBoxData.SelectedIndex];
            UpdateFormFollowSystem();
            UpdateFormTrafficLight();
            GetValidDate(ref date);
        }

        private void listBoxData_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(selectedDate.ToString());
            UpdateDirectionChart();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Reading = false;
            if ((listBoxData.SelectedIndex >= 0))
            {
                administration.Remove(administration.Dates[listBoxData.SelectedIndex]);
            }
            listBoxData.Items.Clear();
            labelPrefferdSide.Text = "";
            labelHowManyBikesOnFollowSystem.Text = "";
            listBoxTimeLightsOn.Items.Clear();
            UpdateForm();
            administration.Save();
            Reading = true;
        }

        private void backgroundWorkerFollow_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                while (Reading = true)
                {
                    administration.ReadMessage(date);
                }
            }
            catch (IndexOutOfRangeException)
            {
                //Nothing will be done because this exeption is thrown when data is corrupt, No messagebox will be thrown because it will stop the program.
            }
            catch (InvalidOperationException)
            {
                //Nothing will be done because this exeption is thrown because this loop wil always be running, so the contentwill always be changed, it only happens when the next day starts.
            }
        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            try
            {
                while (Reading = true)
                {
                    administration.ReadMessage(date);
                }
            }
            catch (IndexOutOfRangeException)
            {
                //Nothing will be done because this exeption is thrown when data is corrupt, No messagebox will be thrown because it will stop the program.
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (selectedDate == null) return;


            if (selectedDate.FollowSystem.FollowSystemData.Count != lastFollowCount)
            {
                lastFollowCount = selectedDate.FollowSystem.FollowSystemData.Count;
                UpdateFormFollowSystem();
            }

            if (selectedDate.TrafficLight.TrafficLightData.Count != lastTrafficCount)
            {
                lastTrafficCount = selectedDate.TrafficLight.TrafficLightData.Count;
                UpdateFormTrafficLight();
            }
        }

        private void buttonToggleTimer_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
            buttonToggleTimer.Text = timer.Enabled.ToString();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            administration.Save();
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            List<Date> copyOfDates = new List<Date>(administration.Dates);
            foreach (Date date in copyOfDates)
            {
                administration.Remove(date);
            }
            UpdateForm();
        }

        private void buttonNewCurrentDate_Click(object sender, EventArgs e)
        {
            GetValidDate(ref date);
            UpdateForm();
        }
    }

}

