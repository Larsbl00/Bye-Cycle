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
            this.groupBoxIO = new System.Windows.Forms.GroupBox();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.backgroundWorkerCommunication = new System.ComponentModel.BackgroundWorker();
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
            this.groupBoxIO.SuspendLayout();
            this.groupBoxData.SuspendLayout();
            this.groupBoxFollowSystem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxTimeLightsOn.SuspendLayout();
            this.groupBoxTrafficLights.SuspendLayout();
            this.groupBoxTotalTimeRain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIO
            // 
            this.groupBoxIO.Controls.Add(this.buttonImport);
            this.groupBoxIO.Controls.Add(this.buttonDelete);
            this.groupBoxIO.Controls.Add(this.buttonExport);
            this.groupBoxIO.Controls.Add(this.buttonSave);
            this.groupBoxIO.Location = new System.Drawing.Point(5, 276);
            this.groupBoxIO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxIO.Name = "groupBoxIO";
            this.groupBoxIO.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxIO.Size = new System.Drawing.Size(192, 95);
            this.groupBoxIO.TabIndex = 0;
            this.groupBoxIO.TabStop = false;
            this.groupBoxIO.Text = "IO";
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(96, 57);
            this.buttonImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(85, 30);
            this.buttonImport.TabIndex = 4;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(96, 21);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(85, 30);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(5, 57);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(85, 30);
            this.buttonExport.TabIndex = 2;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(5, 21);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(85, 30);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.ItemHeight = 16;
            this.listBoxData.Location = new System.Drawing.Point(5, 26);
            this.listBoxData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(192, 244);
            this.listBoxData.TabIndex = 1;
            this.listBoxData.SelectedIndexChanged += new System.EventHandler(this.listBoxData_SelectedIndexChanged);
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.listBoxData);
            this.groupBoxData.Controls.Add(this.groupBoxIO);
            this.groupBoxData.Location = new System.Drawing.Point(13, 14);
            this.groupBoxData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxData.Size = new System.Drawing.Size(204, 379);
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
            this.groupBoxFollowSystem.Controls.Add(this.groupBox1);
            this.groupBoxFollowSystem.Controls.Add(this.labelPrefferdSide);
            this.groupBoxFollowSystem.Controls.Add(this.labelHowManyBikesOnFollowSystem);
            this.groupBoxFollowSystem.Controls.Add(this.groupBoxTimeLightsOn);
            this.groupBoxFollowSystem.Controls.Add(this.labelPefferedSideStatic);
            this.groupBoxFollowSystem.Controls.Add(this.labelHowManyBikesStatic);
            this.groupBoxFollowSystem.Location = new System.Drawing.Point(224, 14);
            this.groupBoxFollowSystem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFollowSystem.Name = "groupBoxFollowSystem";
            this.groupBoxFollowSystem.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFollowSystem.Size = new System.Drawing.Size(487, 379);
            this.groupBoxFollowSystem.TabIndex = 4;
            this.groupBoxFollowSystem.TabStop = false;
            this.groupBoxFollowSystem.Text = "Follow Light";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFollowLightON);
            this.groupBox1.Controls.Add(this.buttonFollowLightOFF);
            this.groupBox1.Location = new System.Drawing.Point(325, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(161, 210);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turn System on/off";
            // 
            // buttonFollowLightON
            // 
            this.buttonFollowLightON.Location = new System.Drawing.Point(8, 23);
            this.buttonFollowLightON.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFollowLightON.Name = "buttonFollowLightON";
            this.buttonFollowLightON.Size = new System.Drawing.Size(135, 76);
            this.buttonFollowLightON.TabIndex = 10;
            this.buttonFollowLightON.Text = "ON";
            this.buttonFollowLightON.UseVisualStyleBackColor = true;
            this.buttonFollowLightON.Click += new System.EventHandler(this.buttonFollowLightON_Click);
            // 
            // buttonFollowLightOFF
            // 
            this.buttonFollowLightOFF.Location = new System.Drawing.Point(8, 127);
            this.buttonFollowLightOFF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFollowLightOFF.Name = "buttonFollowLightOFF";
            this.buttonFollowLightOFF.Size = new System.Drawing.Size(135, 76);
            this.buttonFollowLightOFF.TabIndex = 11;
            this.buttonFollowLightOFF.Text = "OFF";
            this.buttonFollowLightOFF.UseVisualStyleBackColor = true;
            this.buttonFollowLightOFF.Click += new System.EventHandler(this.buttonFollowLightOFF_Click);
            // 
            // labelPrefferdSide
            // 
            this.labelPrefferdSide.AutoSize = true;
            this.labelPrefferdSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrefferdSide.Location = new System.Drawing.Point(275, 57);
            this.labelPrefferdSide.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrefferdSide.Name = "labelPrefferdSide";
            this.labelPrefferdSide.Size = new System.Drawing.Size(0, 31);
            this.labelPrefferdSide.TabIndex = 12;
            // 
            // labelHowManyBikesOnFollowSystem
            // 
            this.labelHowManyBikesOnFollowSystem.AutoSize = true;
            this.labelHowManyBikesOnFollowSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHowManyBikesOnFollowSystem.Location = new System.Drawing.Point(275, 26);
            this.labelHowManyBikesOnFollowSystem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHowManyBikesOnFollowSystem.Name = "labelHowManyBikesOnFollowSystem";
            this.labelHowManyBikesOnFollowSystem.Size = new System.Drawing.Size(0, 31);
            this.labelHowManyBikesOnFollowSystem.TabIndex = 9;
            // 
            // groupBoxTimeLightsOn
            // 
            this.groupBoxTimeLightsOn.Controls.Add(this.listBoxTimeLightsOn);
            this.groupBoxTimeLightsOn.Location = new System.Drawing.Point(21, 90);
            this.groupBoxTimeLightsOn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTimeLightsOn.Name = "groupBoxTimeLightsOn";
            this.groupBoxTimeLightsOn.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTimeLightsOn.Size = new System.Drawing.Size(297, 210);
            this.groupBoxTimeLightsOn.TabIndex = 8;
            this.groupBoxTimeLightsOn.TabStop = false;
            this.groupBoxTimeLightsOn.Text = "Time lights on";
            // 
            // listBoxTimeLightsOn
            // 
            this.listBoxTimeLightsOn.FormattingEnabled = true;
            this.listBoxTimeLightsOn.ItemHeight = 16;
            this.listBoxTimeLightsOn.Location = new System.Drawing.Point(5, 21);
            this.listBoxTimeLightsOn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxTimeLightsOn.Name = "listBoxTimeLightsOn";
            this.listBoxTimeLightsOn.Size = new System.Drawing.Size(286, 180);
            this.listBoxTimeLightsOn.TabIndex = 7;
            // 
            // labelPefferedSideStatic
            // 
            this.labelPefferedSideStatic.AutoSize = true;
            this.labelPefferedSideStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPefferedSideStatic.Location = new System.Drawing.Point(15, 57);
            this.labelPefferedSideStatic.Name = "labelPefferedSideStatic";
            this.labelPefferedSideStatic.Size = new System.Drawing.Size(191, 31);
            this.labelPefferedSideStatic.TabIndex = 6;
            this.labelPefferedSideStatic.Text = "Preffered side:";
            // 
            // labelHowManyBikesStatic
            // 
            this.labelHowManyBikesStatic.AutoSize = true;
            this.labelHowManyBikesStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHowManyBikesStatic.Location = new System.Drawing.Point(15, 26);
            this.labelHowManyBikesStatic.Name = "labelHowManyBikesStatic";
            this.labelHowManyBikesStatic.Size = new System.Drawing.Size(221, 31);
            this.labelHowManyBikesStatic.TabIndex = 5;
            this.labelHowManyBikesStatic.Text = "How many bikes:";
            // 
            // groupBoxTrafficLights
            // 
            this.groupBoxTrafficLights.Controls.Add(this.label1);
            this.groupBoxTrafficLights.Controls.Add(this.groupBoxTotalTimeRain);
            this.groupBoxTrafficLights.Location = new System.Drawing.Point(717, 14);
            this.groupBoxTrafficLights.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTrafficLights.Name = "groupBoxTrafficLights";
            this.groupBoxTrafficLights.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTrafficLights.Size = new System.Drawing.Size(240, 379);
            this.groupBoxTrafficLights.TabIndex = 5;
            this.groupBoxTrafficLights.TabStop = false;
            this.groupBoxTrafficLights.Text = "Traffic Lights";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "How many bikes priorytised:";
            // 
            // groupBoxTotalTimeRain
            // 
            this.groupBoxTotalTimeRain.Controls.Add(this.listBoxTotalTimeRain);
            this.groupBoxTotalTimeRain.Location = new System.Drawing.Point(5, 57);
            this.groupBoxTotalTimeRain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTotalTimeRain.Name = "groupBoxTotalTimeRain";
            this.groupBoxTotalTimeRain.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTotalTimeRain.Size = new System.Drawing.Size(135, 210);
            this.groupBoxTotalTimeRain.TabIndex = 9;
            this.groupBoxTotalTimeRain.TabStop = false;
            this.groupBoxTotalTimeRain.Text = "Total time rain";
            // 
            // listBoxTotalTimeRain
            // 
            this.listBoxTotalTimeRain.FormattingEnabled = true;
            this.listBoxTotalTimeRain.ItemHeight = 16;
            this.listBoxTotalTimeRain.Location = new System.Drawing.Point(5, 21);
            this.listBoxTotalTimeRain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxTotalTimeRain.Name = "listBoxTotalTimeRain";
            this.listBoxTotalTimeRain.Size = new System.Drawing.Size(120, 180);
            this.listBoxTotalTimeRain.TabIndex = 7;
            // 
            // timerUpdateForm
            // 
            this.timerUpdateForm.Enabled = true;
            this.timerUpdateForm.Interval = 3000;
            this.timerUpdateForm.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 569);
            this.Controls.Add(this.groupBoxTrafficLights);
            this.Controls.Add(this.groupBoxFollowSystem);
            this.Controls.Add(this.groupBoxData);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.Text = "Dashbord ";
            this.groupBoxIO.ResumeLayout(false);
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxFollowSystem.ResumeLayout(false);
            this.groupBoxFollowSystem.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxTimeLightsOn.ResumeLayout(false);
            this.groupBoxTrafficLights.ResumeLayout(false);
            this.groupBoxTrafficLights.PerformLayout();
            this.groupBoxTotalTimeRain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIO;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCommunication;
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
    }
}

