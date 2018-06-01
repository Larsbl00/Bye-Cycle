namespace Bye_Cycle
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxIO = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.backgroundWorkerCommunication = new System.ComponentModel.BackgroundWorker();
            this.groupBoxFollowSystem = new System.Windows.Forms.GroupBox();
            this.groupBoxTimeLightsOn = new System.Windows.Forms.GroupBox();
            this.listBoxTimeLightsOn = new System.Windows.Forms.ListBox();
            this.labelPrefferedSide = new System.Windows.Forms.Label();
            this.labelHowManyBikes = new System.Windows.Forms.Label();
            this.buttonBarChart = new System.Windows.Forms.Button();
            this.buttonPieChart = new System.Windows.Forms.Button();
            this.groupBoxTrafficLights = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxTotalTimeRain = new System.Windows.Forms.GroupBox();
            this.listBoxTotalTimeRain = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerUpdateForm = new System.Windows.Forms.Timer(this.components);
            this.labelHowManyBikesOnFollowSystem = new System.Windows.Forms.Label();
            this.buttonFollowLightON = new System.Windows.Forms.Button();
            this.buttonFollowLightOFF = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.groupBoxIO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBoxData.SuspendLayout();
            this.groupBoxFollowSystem.SuspendLayout();
            this.groupBoxTimeLightsOn.SuspendLayout();
            this.groupBoxTrafficLights.SuspendLayout();
            this.groupBoxTotalTimeRain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxIO
            // 
            this.groupBoxIO.Controls.Add(this.buttonImport);
            this.groupBoxIO.Controls.Add(this.buttonDelete);
            this.groupBoxIO.Controls.Add(this.buttonExport);
            this.groupBoxIO.Controls.Add(this.buttonSave);
            this.groupBoxIO.Location = new System.Drawing.Point(4, 224);
            this.groupBoxIO.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxIO.Name = "groupBoxIO";
            this.groupBoxIO.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxIO.Size = new System.Drawing.Size(144, 77);
            this.groupBoxIO.TabIndex = 0;
            this.groupBoxIO.TabStop = false;
            this.groupBoxIO.Text = "IO";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(72, 17);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(64, 24);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(4, 46);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(64, 24);
            this.buttonExport.TabIndex = 2;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(4, 17);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(64, 24);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.Location = new System.Drawing.Point(4, 21);
            this.listBoxData.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(145, 199);
            this.listBoxData.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(4, 21);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(554, 237);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.listBoxData);
            this.groupBoxData.Controls.Add(this.groupBoxIO);
            this.groupBoxData.Location = new System.Drawing.Point(10, 11);
            this.groupBoxData.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxData.Size = new System.Drawing.Size(153, 308);
            this.groupBoxData.TabIndex = 3;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Dates";
            // 
            // backgroundWorkerCommunication
            // 
            this.backgroundWorkerCommunication.WorkerSupportsCancellation = true;
            this.backgroundWorkerCommunication.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork_1);
            // 
            // groupBoxFollowSystem
            // 
            this.groupBoxFollowSystem.Controls.Add(this.buttonFollowLightOFF);
            this.groupBoxFollowSystem.Controls.Add(this.buttonFollowLightON);
            this.groupBoxFollowSystem.Controls.Add(this.labelHowManyBikesOnFollowSystem);
            this.groupBoxFollowSystem.Controls.Add(this.groupBoxTimeLightsOn);
            this.groupBoxFollowSystem.Controls.Add(this.labelPrefferedSide);
            this.groupBoxFollowSystem.Controls.Add(this.labelHowManyBikes);
            this.groupBoxFollowSystem.Controls.Add(this.buttonBarChart);
            this.groupBoxFollowSystem.Controls.Add(this.buttonPieChart);
            this.groupBoxFollowSystem.Controls.Add(this.chart1);
            this.groupBoxFollowSystem.Location = new System.Drawing.Point(168, 11);
            this.groupBoxFollowSystem.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxFollowSystem.Name = "groupBoxFollowSystem";
            this.groupBoxFollowSystem.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxFollowSystem.Size = new System.Drawing.Size(562, 583);
            this.groupBoxFollowSystem.TabIndex = 4;
            this.groupBoxFollowSystem.TabStop = false;
            this.groupBoxFollowSystem.Text = "Follow Light";
            // 
            // groupBoxTimeLightsOn
            // 
            this.groupBoxTimeLightsOn.Controls.Add(this.listBoxTimeLightsOn);
            this.groupBoxTimeLightsOn.Location = new System.Drawing.Point(10, 340);
            this.groupBoxTimeLightsOn.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTimeLightsOn.Name = "groupBoxTimeLightsOn";
            this.groupBoxTimeLightsOn.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTimeLightsOn.Size = new System.Drawing.Size(101, 171);
            this.groupBoxTimeLightsOn.TabIndex = 8;
            this.groupBoxTimeLightsOn.TabStop = false;
            this.groupBoxTimeLightsOn.Text = "Time lights on";
            // 
            // listBoxTimeLightsOn
            // 
            this.listBoxTimeLightsOn.FormattingEnabled = true;
            this.listBoxTimeLightsOn.Location = new System.Drawing.Point(4, 17);
            this.listBoxTimeLightsOn.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxTimeLightsOn.Name = "listBoxTimeLightsOn";
            this.listBoxTimeLightsOn.Size = new System.Drawing.Size(91, 147);
            this.listBoxTimeLightsOn.TabIndex = 7;
            // 
            // labelPrefferedSide
            // 
            this.labelPrefferedSide.AutoSize = true;
            this.labelPrefferedSide.Location = new System.Drawing.Point(8, 324);
            this.labelPrefferedSide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrefferedSide.Name = "labelPrefferedSide";
            this.labelPrefferedSide.Size = new System.Drawing.Size(75, 13);
            this.labelPrefferedSide.TabIndex = 6;
            this.labelPrefferedSide.Text = "Preffered side:";
            // 
            // labelHowManyBikes
            // 
            this.labelHowManyBikes.AutoSize = true;
            this.labelHowManyBikes.Location = new System.Drawing.Point(5, 307);
            this.labelHowManyBikes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHowManyBikes.Name = "labelHowManyBikes";
            this.labelHowManyBikes.Size = new System.Drawing.Size(88, 13);
            this.labelHowManyBikes.TabIndex = 5;
            this.labelHowManyBikes.Text = "How many bikes:";
            // 
            // buttonBarChart
            // 
            this.buttonBarChart.Location = new System.Drawing.Point(283, 263);
            this.buttonBarChart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBarChart.Name = "buttonBarChart";
            this.buttonBarChart.Size = new System.Drawing.Size(274, 38);
            this.buttonBarChart.TabIndex = 4;
            this.buttonBarChart.Text = "Bar chart";
            this.buttonBarChart.UseVisualStyleBackColor = true;
            // 
            // buttonPieChart
            // 
            this.buttonPieChart.Location = new System.Drawing.Point(4, 263);
            this.buttonPieChart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPieChart.Name = "buttonPieChart";
            this.buttonPieChart.Size = new System.Drawing.Size(274, 38);
            this.buttonPieChart.TabIndex = 3;
            this.buttonPieChart.Text = "Pie chart";
            this.buttonPieChart.UseVisualStyleBackColor = true;
            // 
            // groupBoxTrafficLights
            // 
            this.groupBoxTrafficLights.Controls.Add(this.label1);
            this.groupBoxTrafficLights.Controls.Add(this.groupBoxTotalTimeRain);
            this.groupBoxTrafficLights.Controls.Add(this.button1);
            this.groupBoxTrafficLights.Controls.Add(this.button2);
            this.groupBoxTrafficLights.Controls.Add(this.chart2);
            this.groupBoxTrafficLights.Location = new System.Drawing.Point(735, 11);
            this.groupBoxTrafficLights.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTrafficLights.Name = "groupBoxTrafficLights";
            this.groupBoxTrafficLights.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTrafficLights.Size = new System.Drawing.Size(562, 583);
            this.groupBoxTrafficLights.TabIndex = 5;
            this.groupBoxTrafficLights.TabStop = false;
            this.groupBoxTrafficLights.Text = "Traffic Lights";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 314);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "How many bikes priorytised:";
            // 
            // groupBoxTotalTimeRain
            // 
            this.groupBoxTotalTimeRain.Controls.Add(this.listBoxTotalTimeRain);
            this.groupBoxTotalTimeRain.Location = new System.Drawing.Point(4, 340);
            this.groupBoxTotalTimeRain.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTotalTimeRain.Name = "groupBoxTotalTimeRain";
            this.groupBoxTotalTimeRain.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTotalTimeRain.Size = new System.Drawing.Size(101, 171);
            this.groupBoxTotalTimeRain.TabIndex = 9;
            this.groupBoxTotalTimeRain.TabStop = false;
            this.groupBoxTotalTimeRain.Text = "Total time rain";
            // 
            // listBoxTotalTimeRain
            // 
            this.listBoxTotalTimeRain.FormattingEnabled = true;
            this.listBoxTotalTimeRain.Location = new System.Drawing.Point(4, 17);
            this.listBoxTotalTimeRain.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxTotalTimeRain.Name = "listBoxTotalTimeRain";
            this.listBoxTotalTimeRain.Size = new System.Drawing.Size(91, 147);
            this.listBoxTotalTimeRain.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 263);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Bar chart";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 263);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Pie chart";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(4, 21);
            this.chart2.Margin = new System.Windows.Forms.Padding(2);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(554, 237);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // timerUpdateForm
            // 
            this.timerUpdateForm.Enabled = true;
            this.timerUpdateForm.Interval = 3000;
            this.timerUpdateForm.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelHowManyBikesOnFollowSystem
            // 
            this.labelHowManyBikesOnFollowSystem.AutoSize = true;
            this.labelHowManyBikesOnFollowSystem.Location = new System.Drawing.Point(99, 307);
            this.labelHowManyBikesOnFollowSystem.Name = "labelHowManyBikesOnFollowSystem";
            this.labelHowManyBikesOnFollowSystem.Size = new System.Drawing.Size(0, 13);
            this.labelHowManyBikesOnFollowSystem.TabIndex = 9;
            // 
            // buttonFollowLightON
            // 
            this.buttonFollowLightON.Location = new System.Drawing.Point(10, 517);
            this.buttonFollowLightON.Name = "buttonFollowLightON";
            this.buttonFollowLightON.Size = new System.Drawing.Size(101, 41);
            this.buttonFollowLightON.TabIndex = 10;
            this.buttonFollowLightON.Text = "ON";
            this.buttonFollowLightON.UseVisualStyleBackColor = true;
            this.buttonFollowLightON.Click += new System.EventHandler(this.buttonFollowLightON_Click);
            // 
            // buttonFollowLightOFF
            // 
            this.buttonFollowLightOFF.Location = new System.Drawing.Point(117, 517);
            this.buttonFollowLightOFF.Name = "buttonFollowLightOFF";
            this.buttonFollowLightOFF.Size = new System.Drawing.Size(101, 41);
            this.buttonFollowLightOFF.TabIndex = 11;
            this.buttonFollowLightOFF.Text = "OFF";
            this.buttonFollowLightOFF.UseVisualStyleBackColor = true;
            this.buttonFollowLightOFF.Click += new System.EventHandler(this.buttonFollowLightOFF_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(72, 46);
            this.buttonImport.Margin = new System.Windows.Forms.Padding(2);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(64, 24);
            this.buttonImport.TabIndex = 4;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 604);
            this.Controls.Add(this.groupBoxTrafficLights);
            this.Controls.Add(this.groupBoxFollowSystem);
            this.Controls.Add(this.groupBoxData);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "Dashbord ";
            this.groupBoxIO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxFollowSystem.ResumeLayout(false);
            this.groupBoxFollowSystem.PerformLayout();
            this.groupBoxTimeLightsOn.ResumeLayout(false);
            this.groupBoxTrafficLights.ResumeLayout(false);
            this.groupBoxTrafficLights.PerformLayout();
            this.groupBoxTotalTimeRain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIO;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCommunication;
        private System.Windows.Forms.GroupBox groupBoxFollowSystem;
        private System.Windows.Forms.Button buttonBarChart;
        private System.Windows.Forms.Button buttonPieChart;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxTrafficLights;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.GroupBox groupBoxTimeLightsOn;
        private System.Windows.Forms.ListBox listBoxTimeLightsOn;
        private System.Windows.Forms.Label labelPrefferedSide;
        private System.Windows.Forms.Label labelHowManyBikes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxTotalTimeRain;
        private System.Windows.Forms.ListBox listBoxTotalTimeRain;
        private System.Windows.Forms.Timer timerUpdateForm;
        private System.Windows.Forms.Label labelHowManyBikesOnFollowSystem;
        private System.Windows.Forms.Button buttonFollowLightOFF;
        private System.Windows.Forms.Button buttonFollowLightON;
        private System.Windows.Forms.Button buttonImport;
    }
}

