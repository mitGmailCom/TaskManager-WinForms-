namespace TaskManager_WinForms_
{
    partial class FormSetTimeStopProc
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
            this.btnSetProcess = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbMinute = new System.Windows.Forms.TextBox();
            this.lbDay = new System.Windows.Forms.Label();
            this.tbHour = new System.Windows.Forms.TextBox();
            this.lbHour = new System.Windows.Forms.Label();
            this.tbDay = new System.Windows.Forms.TextBox();
            this.lbMinute = new System.Windows.Forms.Label();
            this.btnSetTime = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSetProcess
            // 
            this.btnSetProcess.Location = new System.Drawing.Point(61, 218);
            this.btnSetProcess.Name = "btnSetProcess";
            this.btnSetProcess.Size = new System.Drawing.Size(75, 23);
            this.btnSetProcess.TabIndex = 16;
            this.btnSetProcess.Text = "Check process";
            this.btnSetProcess.UseVisualStyleBackColor = true;
            this.btnSetProcess.Click += new System.EventHandler(this.btnSetProcess_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbMinute);
            this.groupBox2.Controls.Add(this.lbDay);
            this.groupBox2.Controls.Add(this.tbHour);
            this.groupBox2.Controls.Add(this.lbHour);
            this.groupBox2.Controls.Add(this.tbDay);
            this.groupBox2.Controls.Add(this.lbMinute);
            this.groupBox2.Location = new System.Drawing.Point(90, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(111, 162);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // tbMinute
            // 
            this.tbMinute.Location = new System.Drawing.Point(52, 115);
            this.tbMinute.Name = "tbMinute";
            this.tbMinute.Size = new System.Drawing.Size(50, 20);
            this.tbMinute.TabIndex = 10;
            this.tbMinute.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // lbDay
            // 
            this.lbDay.AutoSize = true;
            this.lbDay.Location = new System.Drawing.Point(6, 32);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(26, 13);
            this.lbDay.TabIndex = 2;
            this.lbDay.Text = "Day";
            // 
            // tbHour
            // 
            this.tbHour.Location = new System.Drawing.Point(52, 72);
            this.tbHour.Name = "tbHour";
            this.tbHour.Size = new System.Drawing.Size(50, 20);
            this.tbHour.TabIndex = 9;
            this.tbHour.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // lbHour
            // 
            this.lbHour.AutoSize = true;
            this.lbHour.Location = new System.Drawing.Point(6, 75);
            this.lbHour.Name = "lbHour";
            this.lbHour.Size = new System.Drawing.Size(30, 13);
            this.lbHour.TabIndex = 3;
            this.lbHour.Text = "Hour";
            // 
            // tbDay
            // 
            this.tbDay.Location = new System.Drawing.Point(52, 29);
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(50, 20);
            this.tbDay.TabIndex = 8;
            this.tbDay.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // lbMinute
            // 
            this.lbMinute.AutoSize = true;
            this.lbMinute.Location = new System.Drawing.Point(6, 118);
            this.lbMinute.Name = "lbMinute";
            this.lbMinute.Size = new System.Drawing.Size(39, 13);
            this.lbMinute.TabIndex = 4;
            this.lbMinute.Text = "Minute";
            // 
            // btnSetTime
            // 
            this.btnSetTime.Location = new System.Drawing.Point(164, 218);
            this.btnSetTime.Name = "btnSetTime";
            this.btnSetTime.Size = new System.Drawing.Size(75, 23);
            this.btnSetTime.TabIndex = 14;
            this.btnSetTime.Text = "Stop process";
            this.btnSetTime.UseVisualStyleBackColor = true;
            this.btnSetTime.Click += new System.EventHandler(this.btnSetTime_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(90, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 17;
            // 
            // FormSetTimeStopProc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSetProcess);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSetTime);
            this.Name = "FormSetTimeStopProc";
            this.Text = "FormSetTimeStopProc";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSetProcess;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbMinute;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.TextBox tbHour;
        private System.Windows.Forms.Label lbHour;
        private System.Windows.Forms.TextBox tbDay;
        private System.Windows.Forms.Label lbMinute;
        private System.Windows.Forms.Button btnSetTime;
        private System.Windows.Forms.Label label5;
    }
}