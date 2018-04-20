namespace Bye_Cycle
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxIO = new System.Windows.Forms.GroupBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxFollowSystem = new System.Windows.Forms.GroupBox();
            this.buttonBarChart = new System.Windows.Forms.Button();
            this.buttonPieChart = new System.Windows.Forms.Button();
            this.groupBoxTrafficLights = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelHowManyBikes = new System.Windows.Forms.Label();
            this.labelPrefferedSide = new System.Windows.Forms.Label();
            this.listBoxTimeLightsOn = new System.Windows.Forms.ListBox();
            this.groupBoxTimeLightsOn = new System.Windows.Forms.GroupBox();
            this.groupBoxTotalTimeRain = new System.Windows.Forms.GroupBox();
            this.listBoxTotalTimeRain = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBoxIO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBoxData.SuspendLayout();
            this.groupBoxFollowSystem.SuspendLayout();
            this.groupBoxTrafficLights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBoxTimeLightsOn.SuspendLayout();
            this.groupBoxTotalTimeRain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIO
            // 
            this.groupBoxIO.Controls.Add(this.buttonChange);
            this.groupBoxIO.Controls.Add(this.buttonBackup);
            this.groupBoxIO.Controls.Add(this.buttonDelete);
            this.groupBoxIO.Controls.Add(this.buttonSave);
            this.groupBoxIO.Location = new System.Drawing.Point(6, 276);
            this.groupBoxIO.Name = "groupBoxIO";
            this.groupBoxIO.Size = new System.Drawing.Size(192, 95);
            this.groupBoxIO.TabIndex = 0;
            this.groupBoxIO.TabStop = false;
            this.groupBoxIO.Text = "IO";
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(97, 56);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(89, 30);
            this.buttonChange.TabIndex = 3;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            // 
            // buttonBackup
            // 
            this.buttonBackup.Location = new System.Drawing.Point(6, 57);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(85, 30);
            this.buttonBackup.TabIndex = 2;
            this.buttonBackup.Text = "Backup";
            this.buttonBackup.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(97, 21);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(89, 30);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(6, 21);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(85, 30);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.ItemHeight = 16;
            this.listBoxData.Location = new System.Drawing.Point(6, 26);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(192, 244);
            this.listBoxData.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(6, 26);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(738, 292);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.listBoxData);
            this.groupBoxData.Controls.Add(this.groupBoxIO);
            this.groupBoxData.Location = new System.Drawing.Point(13, 13);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(204, 379);
            this.groupBoxData.TabIndex = 3;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Dates";
            // 
            // groupBoxFollowSystem
            // 
            this.groupBoxFollowSystem.Controls.Add(this.groupBoxTimeLightsOn);
            this.groupBoxFollowSystem.Controls.Add(this.labelPrefferedSide);
            this.groupBoxFollowSystem.Controls.Add(this.labelHowManyBikes);
            this.groupBoxFollowSystem.Controls.Add(this.buttonBarChart);
            this.groupBoxFollowSystem.Controls.Add(this.buttonPieChart);
            this.groupBoxFollowSystem.Controls.Add(this.chart1);
            this.groupBoxFollowSystem.Location = new System.Drawing.Point(224, 13);
            this.groupBoxFollowSystem.Name = "groupBoxFollowSystem";
            this.groupBoxFollowSystem.Size = new System.Drawing.Size(750, 718);
            this.groupBoxFollowSystem.TabIndex = 4;
            this.groupBoxFollowSystem.TabStop = false;
            this.groupBoxFollowSystem.Text = "Follow Light";
            // 
            // buttonBarChart
            // 
            this.buttonBarChart.Location = new System.Drawing.Point(377, 324);
            this.buttonBarChart.Name = "buttonBarChart";
            this.buttonBarChart.Size = new System.Drawing.Size(365, 47);
            this.buttonBarChart.TabIndex = 4;
            this.buttonBarChart.Text = "Bar chart";
            this.buttonBarChart.UseVisualStyleBackColor = true;
            // 
            // buttonPieChart
            // 
            this.buttonPieChart.Location = new System.Drawing.Point(6, 324);
            this.buttonPieChart.Name = "buttonPieChart";
            this.buttonPieChart.Size = new System.Drawing.Size(365, 47);
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
            this.groupBoxTrafficLights.Location = new System.Drawing.Point(980, 13);
            this.groupBoxTrafficLights.Name = "groupBoxTrafficLights";
            this.groupBoxTrafficLights.Size = new System.Drawing.Size(750, 718);
            this.groupBoxTrafficLights.TabIndex = 5;
            this.groupBoxTrafficLights.TabStop = false;
            this.groupBoxTrafficLights.Text = "Traffic Lights";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(365, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Bar chart";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(365, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "Pie chart";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(6, 26);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(738, 292);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // labelHowManyBikes
            // 
            this.labelHowManyBikes.AutoSize = true;
            this.labelHowManyBikes.Location = new System.Drawing.Point(7, 378);
            this.labelHowManyBikes.Name = "labelHowManyBikes";
            this.labelHowManyBikes.Size = new System.Drawing.Size(114, 17);
            this.labelHowManyBikes.TabIndex = 5;
            this.labelHowManyBikes.Text = "How many bikes:";
            // 
            // labelPrefferedSide
            // 
            this.labelPrefferedSide.AutoSize = true;
            this.labelPrefferedSide.Location = new System.Drawing.Point(10, 399);
            this.labelPrefferedSide.Name = "labelPrefferedSide";
            this.labelPrefferedSide.Size = new System.Drawing.Size(101, 17);
            this.labelPrefferedSide.TabIndex = 6;
            this.labelPrefferedSide.Text = "Preffered side:";
            // 
            // listBoxTimeLightsOn
            // 
            this.listBoxTimeLightsOn.FormattingEnabled = true;
            this.listBoxTimeLightsOn.ItemHeight = 16;
            this.listBoxTimeLightsOn.Location = new System.Drawing.Point(6, 21);
            this.listBoxTimeLightsOn.Name = "listBoxTimeLightsOn";
            this.listBoxTimeLightsOn.Size = new System.Drawing.Size(120, 180);
            this.listBoxTimeLightsOn.TabIndex = 7;
            // 
            // groupBoxTimeLightsOn
            // 
            this.groupBoxTimeLightsOn.Controls.Add(this.listBoxTimeLightsOn);
            this.groupBoxTimeLightsOn.Location = new System.Drawing.Point(13, 419);
            this.groupBoxTimeLightsOn.Name = "groupBoxTimeLightsOn";
            this.groupBoxTimeLightsOn.Size = new System.Drawing.Size(135, 210);
            this.groupBoxTimeLightsOn.TabIndex = 8;
            this.groupBoxTimeLightsOn.TabStop = false;
            this.groupBoxTimeLightsOn.Text = "Time lights on";
            // 
            // groupBoxTotalTimeRain
            // 
            this.groupBoxTotalTimeRain.Controls.Add(this.listBoxTotalTimeRain);
            this.groupBoxTotalTimeRain.Location = new System.Drawing.Point(6, 419);
            this.groupBoxTotalTimeRain.Name = "groupBoxTotalTimeRain";
            this.groupBoxTotalTimeRain.Size = new System.Drawing.Size(135, 210);
            this.groupBoxTotalTimeRain.TabIndex = 9;
            this.groupBoxTotalTimeRain.TabStop = false;
            this.groupBoxTotalTimeRain.Text = "Total time rain";
            // 
            // listBoxTotalTimeRain
            // 
            this.listBoxTotalTimeRain.FormattingEnabled = true;
            this.listBoxTotalTimeRain.ItemHeight = 16;
            this.listBoxTotalTimeRain.Location = new System.Drawing.Point(6, 21);
            this.listBoxTotalTimeRain.Name = "listBoxTotalTimeRain";
            this.listBoxTotalTimeRain.Size = new System.Drawing.Size(120, 180);
            this.listBoxTotalTimeRain.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "How many bikes priorytised:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1743, 743);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBoxTrafficLights);
            this.Controls.Add(this.groupBoxFollowSystem);
            this.Controls.Add(this.groupBoxData);
            this.Name = "Form1";
            this.Text = "Dashbord ";
            this.groupBoxIO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxFollowSystem.ResumeLayout(false);
            this.groupBoxFollowSystem.PerformLayout();
            this.groupBoxTrafficLights.ResumeLayout(false);
            this.groupBoxTrafficLights.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBoxTimeLightsOn.ResumeLayout(false);
            this.groupBoxTotalTimeRain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIO;
        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBoxFollowSystem;
        private System.Windows.Forms.Button buttonBarChart;
        private System.Windows.Forms.Button buttonPieChart;
        private System.Windows.Forms.Button buttonChange;
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
        private System.Windows.Forms.Button button3;
    }
}

