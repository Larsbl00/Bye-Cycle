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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxIO = new System.Windows.Forms.GroupBox();
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
            this.buttonPieChart = new System.Windows.Forms.Button();
            this.buttonBarChart = new System.Windows.Forms.Button();
            this.groupBoxIO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBoxData.SuspendLayout();
            this.groupBoxFollowSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIO
            // 
            this.groupBoxIO.Controls.Add(this.buttonBackup);
            this.groupBoxIO.Controls.Add(this.buttonDelete);
            this.groupBoxIO.Controls.Add(this.buttonSave);
            this.groupBoxIO.Location = new System.Drawing.Point(12, 395);
            this.groupBoxIO.Name = "groupBoxIO";
            this.groupBoxIO.Size = new System.Drawing.Size(92, 134);
            this.groupBoxIO.TabIndex = 0;
            this.groupBoxIO.TabStop = false;
            this.groupBoxIO.Text = "IO";
            // 
            // buttonBackup
            // 
            this.buttonBackup.Location = new System.Drawing.Point(7, 94);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(75, 30);
            this.buttonBackup.TabIndex = 2;
            this.buttonBackup.Text = "Backup";
            this.buttonBackup.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(7, 58);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 30);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(7, 22);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 30);
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
            this.listBoxData.Size = new System.Drawing.Size(192, 260);
            this.listBoxData.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 26);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(738, 292);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.listBoxData);
            this.groupBoxData.Location = new System.Drawing.Point(13, 13);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(204, 292);
            this.groupBoxData.TabIndex = 3;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Dates";
            // 
            // groupBoxFollowSystem
            // 
            this.groupBoxFollowSystem.Controls.Add(this.buttonBarChart);
            this.groupBoxFollowSystem.Controls.Add(this.buttonPieChart);
            this.groupBoxFollowSystem.Controls.Add(this.chart1);
            this.groupBoxFollowSystem.Location = new System.Drawing.Point(224, 13);
            this.groupBoxFollowSystem.Name = "groupBoxFollowSystem";
            this.groupBoxFollowSystem.Size = new System.Drawing.Size(750, 365);
            this.groupBoxFollowSystem.TabIndex = 4;
            this.groupBoxFollowSystem.TabStop = false;
            this.groupBoxFollowSystem.Text = "Follow Light";
            // 
            // buttonPieChart
            // 
            this.buttonPieChart.Location = new System.Drawing.Point(6, 324);
            this.buttonPieChart.Name = "buttonPieChart";
            this.buttonPieChart.Size = new System.Drawing.Size(365, 33);
            this.buttonPieChart.TabIndex = 3;
            this.buttonPieChart.Text = "Pie chart";
            this.buttonPieChart.UseVisualStyleBackColor = true;
            // 
            // buttonBarChart
            // 
            this.buttonBarChart.Location = new System.Drawing.Point(377, 324);
            this.buttonBarChart.Name = "buttonBarChart";
            this.buttonBarChart.Size = new System.Drawing.Size(365, 33);
            this.buttonBarChart.TabIndex = 4;
            this.buttonBarChart.Text = "Bar chart";
            this.buttonBarChart.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 632);
            this.Controls.Add(this.groupBoxFollowSystem);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.groupBoxIO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxIO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxFollowSystem.ResumeLayout(false);
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
    }
}

