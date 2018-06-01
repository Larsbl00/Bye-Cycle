using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bye_Cycle
{
    public partial class Dashboard : Form
    {
        Thread MainThread = null;
        private bool Reading;
        private Administration administration;

        public Dashboard()
        {
            InitializeComponent();
            administration = new Administration();
            MainThread = Thread.CurrentThread;
            backgroundWorkerCommunication.RunWorkerAsync();
            Reading = true;
            administration.Import(AppDomain.CurrentDomain.BaseDirectory + @" DataDoNotTouch.Bye");
            UpdateForm();

        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            try
            {
                while (Reading = true)
                {
                    administration.ReadMessage();

                }
            }
            catch (IndexOutOfRangeException)
            {
                //Nothing will be done because this exeption is thrown when data is corrupt, No messagebox will be thrown because it will stop the program.
            }
            /*
            catch(InvalidOperationException)
            {
                //Nothing will be done because this exeption is thrown because this loop wil always be running, so the contentwill always be changed, it only happens when the next day starts.
            }
            */
        }

        private void UpdateForm()
        {
            try
            {
                administration.Save();
                UpdatFormTrafficLight();
                UpdateFormFollowSystem();
            }
            catch (InvalidOperationException e)
            {

            }
            catch (InvalidCastException e)
            {

            }

        }

        public void UpdateFormFollowSystem()
        {
            foreach (Data data in administration.CopyData)
            {
                FollowSystem Fdata = data as FollowSystem;
                if (Fdata != null)
                {
                    if (!listBoxData.Items.Contains(data.Date.ToString("dd/MM/yyyy")))
                    {
                        listBoxData.Items.Add(data.Date.ToString("dd/MM/yyyy"));
                    }

                    if (listBoxData.SelectedIndex != -1)
                    {
                        if (data.Date.ToString("dd/MM/yyyy") == listBoxData.SelectedItem.ToString())
                        {
                            //update Form for FollowLight Info
                            labelHowManyBikesOnFollowSystem.Text = Convert.ToString(Fdata.HowManyBikesOnLane);
                            labelPrefferdSide.Text = Convert.ToString(Fdata.Side);
                            listBoxTimeLightsOn.Items.Clear();
                            foreach (string lightsOn in Fdata.TimeLightsOn)
                            {
                                listBoxTimeLightsOn.Items.Add(lightsOn);
                            }
                        }
                    }
                }
            }
        }

        public void UpdatFormTrafficLight()
        {
            foreach (Data data in administration.CopyData)
            {
                TrafficLight Tdata = data as TrafficLight;
                if (Tdata != null)
                {
                    if (!listBoxData.Items.Contains(data.Date.ToString("dd/MM/yyyy")))
                    {
                        listBoxData.Items.Add(data.Date.ToString("dd/MM/yyyy"));
                    }

                    if (listBoxData.SelectedIndex != -1)
                    {
                        foreach (long timeRain in Tdata.TotalTimeRain)
                        {
                            listBoxTotalTimeRain.Items.Add((float)timeRain / 1000 + " Sec");
                        }
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void buttonFollowLightON_Click(object sender, EventArgs e)
        {
            try
            {
                Reading = false;
                administration.SendOnOffMessageToFollowingSystem(false);
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
                administration.SendOnOffMessageToFollowingSystem(true);
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
            UpdateForm();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Reading = false;
            administration.DeleteData(Convert.ToString(listBoxData.SelectedItem));
            listBoxData.Items.Clear();
            labelPrefferdSide.Text = "";
            labelHowManyBikesOnFollowSystem.Text = "";
            listBoxTimeLightsOn.Items.Clear();
            UpdateForm();
            administration.Save();
            Reading = true;
        }
    }

}

