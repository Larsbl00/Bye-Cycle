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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxIO = new System.Windows.Forms.GroupBox();
            this.buttonNewCurrentDate = new System.Windows.Forms.Button();
            this.buttonDeleteAll = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.backgroundWorkerTrafficlight = new System.ComponentModel.BackgroundWorker();
            this.groupBoxFollowSystem = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFollowLightON = new System.Windows.Forms.Button();
            this.buttonFollowLightOFF = new System.Windows.Forms.Button();
            this.labelPrefferdSide = new System.Windows.Forms.Label();
            this.labelHowManyBikesOnFollowSystem = new System.Windows.Forms.Label();
            this.groupBoxTimeLightsOn = new System.Windows.Forms.GroupBox();
            this.listBoxTimeLightsOn = new System.Windows.Forms.ListBox();
            this.labelPefferedSideStatic = new System.Windows.Forms.Label();
            this.labelHowManyBikesStatic = new System.Windows.Forms.Label();
            this.groupBoxTrafficLights = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxTotalTimeRain = new System.Windows.Forms.GroupBox();
            this.listBoxTotalTimeRain = new System.Windows.Forms.ListBox();
            this.timerUpdateForm = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkerFollow = new System.ComponentModel.BackgroundWorker();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonToggleTimer = new System.Windows.Forms.Button();
            this.groupBoxGraphs = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chartAverageTimeNeeded = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.chartPriorityUsed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chartDirectionPreferedAll = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDirectionsPerDay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxIO.SuspendLayout();
            this.groupBoxData.SuspendLayout();
            this.groupBoxFollowSystem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxTimeLightsOn.SuspendLayout();
            this.groupBoxTrafficLights.SuspendLayout();
            this.groupBoxTotalTimeRain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxGraphs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAverageTimeNeeded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPriorityUsed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDirectionPreferedAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDirectionsPerDay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxIO
            // 
            this.groupBoxIO.Controls.Add(this.buttonNewCurrentDate);
            this.groupBoxIO.Controls.Add(this.buttonDeleteAll);
            this.groupBoxIO.Controls.Add(this.buttonImport);
            this.groupBoxIO.Controls.Add(this.buttonDelete);
            this.groupBoxIO.Controls.Add(this.buttonExport);
            this.groupBoxIO.Controls.Add(this.buttonSave);
            this.groupBoxIO.Location = new System.Drawing.Point(8, 431);
            this.groupBoxIO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxIO.Name = "groupBoxIO";
            this.groupBoxIO.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxIO.Size = new System.Drawing.Size(288, 202);
            this.groupBoxIO.TabIndex = 0;
            this.groupBoxIO.TabStop = false;
            this.groupBoxIO.Text = "IO";
            // 
            // buttonNewCurrentDate
            // 
            this.buttonNewCurrentDate.Location = new System.Drawing.Point(144, 142);
            this.buttonNewCurrentDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonNewCurrentDate.Name = "buttonNewCurrentDate";
            this.buttonNewCurrentDate.Size = new System.Drawing.Size(128, 47);
            this.buttonNewCurrentDate.TabIndex = 6;
            this.buttonNewCurrentDate.Text = "New Date";
            this.buttonNewCurrentDate.UseVisualStyleBackColor = true;
            this.buttonNewCurrentDate.Click += new System.EventHandler(this.buttonNewCurrentDate_Click);
            // 
            // buttonDeleteAll
            // 
            this.buttonDeleteAll.Location = new System.Drawing.Point(8, 142);
            this.buttonDeleteAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDeleteAll.Name = "buttonDeleteAll";
            this.buttonDeleteAll.Size = new System.Drawing.Size(128, 47);
            this.buttonDeleteAll.TabIndex = 5;
            this.buttonDeleteAll.Text = "Delete all";
            this.buttonDeleteAll.UseVisualStyleBackColor = true;
            this.buttonDeleteAll.Click += new System.EventHandler(this.buttonDeleteAll_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(144, 89);
            this.buttonImport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(128, 47);
            this.buttonImport.TabIndex = 4;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(144, 33);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(128, 47);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(8, 89);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(128, 47);
            this.buttonExport.TabIndex = 2;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(8, 33);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(128, 47);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.ItemHeight = 25;
            this.listBoxData.Location = new System.Drawing.Point(8, 40);
            this.listBoxData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(286, 379);
            this.listBoxData.TabIndex = 1;
            this.listBoxData.SelectedIndexChanged += new System.EventHandler(this.listBoxData_SelectedIndexChanged);
            this.listBoxData.DoubleClick += new System.EventHandler(this.listBoxData_DoubleClick);
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.listBoxData);
            this.groupBoxData.Controls.Add(this.groupBoxIO);
            this.groupBoxData.Location = new System.Drawing.Point(20, 22);
            this.groupBoxData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxData.Size = new System.Drawing.Size(306, 687);
            this.groupBoxData.TabIndex = 3;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Dates";
            // 
            // backgroundWorkerTrafficlight
            // 
            this.backgroundWorkerTrafficlight.WorkerSupportsCancellation = true;
            this.backgroundWorkerTrafficlight.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork_1);
            // 
            // groupBoxFollowSystem
            // 
            this.groupBoxFollowSystem.Controls.Add(this.groupBox1);
            this.groupBoxFollowSystem.Controls.Add(this.labelPrefferdSide);
            this.groupBoxFollowSystem.Controls.Add(this.labelHowManyBikesOnFollowSystem);
            this.groupBoxFollowSystem.Controls.Add(this.groupBoxTimeLightsOn);
            this.groupBoxFollowSystem.Controls.Add(this.labelPefferedSideStatic);
            this.groupBoxFollowSystem.Controls.Add(this.labelHowManyBikesStatic);
            this.groupBoxFollowSystem.Location = new System.Drawing.Point(336, 22);
            this.groupBoxFollowSystem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxFollowSystem.Name = "groupBoxFollowSystem";
            this.groupBoxFollowSystem.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxFollowSystem.Size = new System.Drawing.Size(860, 855);
            this.groupBoxFollowSystem.TabIndex = 4;
            this.groupBoxFollowSystem.TabStop = false;
            this.groupBoxFollowSystem.Text = "Follow Light";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFollowLightON);
            this.groupBox1.Controls.Add(this.buttonFollowLightOFF);
            this.groupBox1.Location = new System.Drawing.Point(30, 478);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(230, 368);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turn System on/off";
            // 
            // buttonFollowLightON
            // 
            this.buttonFollowLightON.Location = new System.Drawing.Point(12, 36);
            this.buttonFollowLightON.Margin = new System.Windows.Forms.Padding(6);
            this.buttonFollowLightON.Name = "buttonFollowLightON";
            this.buttonFollowLightON.Size = new System.Drawing.Size(202, 119);
            this.buttonFollowLightON.TabIndex = 10;
            this.buttonFollowLightON.Text = "ON";
            this.buttonFollowLightON.UseVisualStyleBackColor = true;
            this.buttonFollowLightON.Click += new System.EventHandler(this.buttonFollowLightON_Click);
            // 
            // buttonFollowLightOFF
            // 
            this.buttonFollowLightOFF.Location = new System.Drawing.Point(12, 198);
            this.buttonFollowLightOFF.Margin = new System.Windows.Forms.Padding(6);
            this.buttonFollowLightOFF.Name = "buttonFollowLightOFF";
            this.buttonFollowLightOFF.Size = new System.Drawing.Size(202, 119);
            this.buttonFollowLightOFF.TabIndex = 11;
            this.buttonFollowLightOFF.Text = "OFF";
            this.buttonFollowLightOFF.UseVisualStyleBackColor = true;
            this.buttonFollowLightOFF.Click += new System.EventHandler(this.buttonFollowLightOFF_Click);
            // 
            // labelPrefferdSide
            // 
            this.labelPrefferdSide.AutoSize = true;
            this.labelPrefferdSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrefferdSide.Location = new System.Drawing.Point(412, 89);
            this.labelPrefferdSide.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPrefferdSide.Name = "labelPrefferdSide";
            this.labelPrefferdSide.Size = new System.Drawing.Size(0, 48);
            this.labelPrefferdSide.TabIndex = 12;
            // 
            // labelHowManyBikesOnFollowSystem
            // 
            this.labelHowManyBikesOnFollowSystem.AutoSize = true;
            this.labelHowManyBikesOnFollowSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHowManyBikesOnFollowSystem.Location = new System.Drawing.Point(412, 40);
            this.labelHowManyBikesOnFollowSystem.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHowManyBikesOnFollowSystem.Name = "labelHowManyBikesOnFollowSystem";
            this.labelHowManyBikesOnFollowSystem.Size = new System.Drawing.Size(0, 48);
            this.labelHowManyBikesOnFollowSystem.TabIndex = 9;
            // 
            // groupBoxTimeLightsOn
            // 
            this.groupBoxTimeLightsOn.Controls.Add(this.listBoxTimeLightsOn);
            this.groupBoxTimeLightsOn.Location = new System.Drawing.Point(32, 140);
            this.groupBoxTimeLightsOn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxTimeLightsOn.Name = "groupBoxTimeLightsOn";
            this.groupBoxTimeLightsOn.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxTimeLightsOn.Size = new System.Drawing.Size(446, 328);
            this.groupBoxTimeLightsOn.TabIndex = 8;
            this.groupBoxTimeLightsOn.TabStop = false;
            this.groupBoxTimeLightsOn.Text = "Time lights on";
            // 
            // listBoxTimeLightsOn
            // 
            this.listBoxTimeLightsOn.FormattingEnabled = true;
            this.listBoxTimeLightsOn.ItemHeight = 25;
            this.listBoxTimeLightsOn.Location = new System.Drawing.Point(8, 33);
            this.listBoxTimeLightsOn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxTimeLightsOn.Name = "listBoxTimeLightsOn";
            this.listBoxTimeLightsOn.Size = new System.Drawing.Size(426, 279);
            this.listBoxTimeLightsOn.TabIndex = 7;
            // 
            // labelPefferedSideStatic
            // 
            this.labelPefferedSideStatic.AutoSize = true;
            this.labelPefferedSideStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPefferedSideStatic.Location = new System.Drawing.Point(22, 89);
            this.labelPefferedSideStatic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPefferedSideStatic.Name = "labelPefferedSideStatic";
            this.labelPefferedSideStatic.Size = new System.Drawing.Size(280, 48);
            this.labelPefferedSideStatic.TabIndex = 6;
            this.labelPefferedSideStatic.Text = "Prefered side:";
            // 
            // labelHowManyBikesStatic
            // 
            this.labelHowManyBikesStatic.AutoSize = true;
            this.labelHowManyBikesStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHowManyBikesStatic.Location = new System.Drawing.Point(22, 40);
            this.labelHowManyBikesStatic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHowManyBikesStatic.Name = "labelHowManyBikesStatic";
            this.labelHowManyBikesStatic.Size = new System.Drawing.Size(337, 48);
            this.labelHowManyBikesStatic.TabIndex = 5;
            this.labelHowManyBikesStatic.Text = "How many bikes:";
            // 
            // groupBoxTrafficLights
            // 
            this.groupBoxTrafficLights.Controls.Add(this.label1);
            this.groupBoxTrafficLights.Controls.Add(this.groupBoxTotalTimeRain);
            this.groupBoxTrafficLights.Location = new System.Drawing.Point(1204, 22);
            this.groupBoxTrafficLights.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxTrafficLights.Name = "groupBoxTrafficLights";
            this.groupBoxTrafficLights.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxTrafficLights.Size = new System.Drawing.Size(473, 592);
            this.groupBoxTrafficLights.TabIndex = 5;
            this.groupBoxTrafficLights.TabStop = false;
            this.groupBoxTrafficLights.Text = "Traffic Lights";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "How many bikes prioritised:";
            // 
            // groupBoxTotalTimeRain
            // 
            this.groupBoxTotalTimeRain.Controls.Add(this.listBoxTotalTimeRain);
            this.groupBoxTotalTimeRain.Location = new System.Drawing.Point(8, 89);
            this.groupBoxTotalTimeRain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxTotalTimeRain.Name = "groupBoxTotalTimeRain";
            this.groupBoxTotalTimeRain.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxTotalTimeRain.Size = new System.Drawing.Size(457, 490);
            this.groupBoxTotalTimeRain.TabIndex = 9;
            this.groupBoxTotalTimeRain.TabStop = false;
            this.groupBoxTotalTimeRain.Text = "Total time rain";
            // 
            // listBoxTotalTimeRain
            // 
            this.listBoxTotalTimeRain.FormattingEnabled = true;
            this.listBoxTotalTimeRain.ItemHeight = 25;
            this.listBoxTotalTimeRain.Location = new System.Drawing.Point(8, 33);
            this.listBoxTotalTimeRain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxTotalTimeRain.Name = "listBoxTotalTimeRain";
            this.listBoxTotalTimeRain.Size = new System.Drawing.Size(441, 429);
            this.listBoxTotalTimeRain.TabIndex = 7;
            // 
            // timerUpdateForm
            // 
            this.timerUpdateForm.Enabled = true;
            this.timerUpdateForm.Interval = 3000;
            // 
            // backgroundWorkerFollow
            // 
            this.backgroundWorkerFollow.WorkerSupportsCancellation = true;
            this.backgroundWorkerFollow.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerFollow_DoWork);
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonToggleTimer);
            this.groupBox2.Location = new System.Drawing.Point(1204, 620);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(473, 149);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toggle Timer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Timer on:";
            // 
            // buttonToggleTimer
            // 
            this.buttonToggleTimer.Location = new System.Drawing.Point(114, 56);
            this.buttonToggleTimer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonToggleTimer.Name = "buttonToggleTimer";
            this.buttonToggleTimer.Size = new System.Drawing.Size(343, 40);
            this.buttonToggleTimer.TabIndex = 0;
            this.buttonToggleTimer.Text = "False";
            this.buttonToggleTimer.UseVisualStyleBackColor = true;
            this.buttonToggleTimer.Click += new System.EventHandler(this.buttonToggleTimer_Click);
            // 
            // groupBoxGraphs
            // 
            this.groupBoxGraphs.Controls.Add(this.label6);
            this.groupBoxGraphs.Controls.Add(this.chartAverageTimeNeeded);
            this.groupBoxGraphs.Controls.Add(this.label5);
            this.groupBoxGraphs.Controls.Add(this.chartPriorityUsed);
            this.groupBoxGraphs.Controls.Add(this.label4);
            this.groupBoxGraphs.Controls.Add(this.label3);
            this.groupBoxGraphs.Controls.Add(this.chartDirectionPreferedAll);
            this.groupBoxGraphs.Controls.Add(this.chartDirectionsPerDay);
            this.groupBoxGraphs.Location = new System.Drawing.Point(20, 914);
            this.groupBoxGraphs.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxGraphs.Name = "groupBoxGraphs";
            this.groupBoxGraphs.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxGraphs.Size = new System.Drawing.Size(2519, 824);
            this.groupBoxGraphs.TabIndex = 7;
            this.groupBoxGraphs.TabStop = false;
            this.groupBoxGraphs.Text = "Charts";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1889, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Average time lights are on";
            // 
            // chartAverageTimeNeeded
            // 
            chartArea1.Name = "ChartArea1";
            this.chartAverageTimeNeeded.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartAverageTimeNeeded.Legends.Add(legend1);
            this.chartAverageTimeNeeded.Location = new System.Drawing.Point(1894, 101);
            this.chartAverageTimeNeeded.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chartAverageTimeNeeded.Name = "chartAverageTimeNeeded";
            this.chartAverageTimeNeeded.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.chartAverageTimeNeeded.Size = new System.Drawing.Size(602, 524);
            this.chartAverageTimeNeeded.TabIndex = 6;
            this.chartAverageTimeNeeded.Text = "AverageTimeToCross";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1264, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Priority used per day";
            // 
            // chartPriorityUsed
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPriorityUsed.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPriorityUsed.Legends.Add(legend2);
            this.chartPriorityUsed.Location = new System.Drawing.Point(1268, 101);
            this.chartPriorityUsed.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chartPriorityUsed.Name = "chartPriorityUsed";
            this.chartPriorityUsed.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chartPriorityUsed.Size = new System.Drawing.Size(602, 524);
            this.chartPriorityUsed.TabIndex = 4;
            this.chartPriorityUsed.Text = "Directions per day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Overall prefered direction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Directions per day";
            // 
            // chartDirectionPreferedAll
            // 
            chartArea3.Name = "ChartArea1";
            this.chartDirectionPreferedAll.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartDirectionPreferedAll.Legends.Add(legend3);
            this.chartDirectionPreferedAll.Location = new System.Drawing.Point(641, 101);
            this.chartDirectionPreferedAll.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chartDirectionPreferedAll.Name = "chartDirectionPreferedAll";
            this.chartDirectionPreferedAll.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Direction";
            this.chartDirectionPreferedAll.Series.Add(series1);
            this.chartDirectionPreferedAll.Size = new System.Drawing.Size(602, 524);
            this.chartDirectionPreferedAll.TabIndex = 1;
            this.chartDirectionPreferedAll.Text = "Directions per day";
            // 
            // chartDirectionsPerDay
            // 
            chartArea4.Name = "ChartArea1";
            this.chartDirectionsPerDay.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartDirectionsPerDay.Legends.Add(legend4);
            this.chartDirectionsPerDay.Location = new System.Drawing.Point(16, 101);
            this.chartDirectionsPerDay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chartDirectionsPerDay.Name = "chartDirectionsPerDay";
            this.chartDirectionsPerDay.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Direction";
            this.chartDirectionsPerDay.Series.Add(series2);
            this.chartDirectionsPerDay.Size = new System.Drawing.Size(602, 524);
            this.chartDirectionsPerDay.TabIndex = 0;
            this.chartDirectionsPerDay.Text = "Directions per day";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(2694, 1466);
            this.Controls.Add(this.groupBoxGraphs);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxTrafficLights);
            this.Controls.Add(this.groupBoxFollowSystem);
            this.Controls.Add(this.groupBoxData);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Dashboard";
            this.Text = "Dashboard ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.groupBoxIO.ResumeLayout(false);
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxFollowSystem.ResumeLayout(false);
            this.groupBoxFollowSystem.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxTimeLightsOn.ResumeLayout(false);
            this.groupBoxTrafficLights.ResumeLayout(false);
            this.groupBoxTrafficLights.PerformLayout();
            this.groupBoxTotalTimeRain.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxGraphs.ResumeLayout(false);
            this.groupBoxGraphs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAverageTimeNeeded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPriorityUsed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDirectionPreferedAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDirectionsPerDay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIO;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.ComponentModel.BackgroundWorker backgroundWorkerTrafficlight;
        private System.Windows.Forms.GroupBox groupBoxFollowSystem;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxTrafficLights;
        private System.Windows.Forms.GroupBox groupBoxTimeLightsOn;
        private System.Windows.Forms.ListBox listBoxTimeLightsOn;
        private System.Windows.Forms.Label labelPefferedSideStatic;
        private System.Windows.Forms.Label labelHowManyBikesStatic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxTotalTimeRain;
        private System.Windows.Forms.ListBox listBoxTotalTimeRain;
        private System.Windows.Forms.Timer timerUpdateForm;
        private System.Windows.Forms.Label labelHowManyBikesOnFollowSystem;
        private System.Windows.Forms.Button buttonFollowLightOFF;
        private System.Windows.Forms.Button buttonFollowLightON;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Label labelPrefferdSide;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerFollow;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonToggleTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxGraphs;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDirectionsPerDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDirectionPreferedAll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPriorityUsed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAverageTimeNeeded;
        private System.Windows.Forms.Button buttonDeleteAll;
        private System.Windows.Forms.Button buttonNewCurrentDate;
    }
}

