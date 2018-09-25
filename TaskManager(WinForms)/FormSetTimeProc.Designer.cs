namespace TaskManager_WinForms_
{
    partial class FormSetTimeProc
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
            this.lbYear = new System.Windows.Forms.Label();
            this.lbMonth = new System.Windows.Forms.Label();
            this.lbDay = new System.Windows.Forms.Label();
            this.lbHour = new System.Windows.Forms.Label();
            this.lbMinute = new System.Windows.Forms.Label();
            this.btnSetTime = new System.Windows.Forms.Button();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbMonth = new System.Windows.Forms.TextBox();
            this.tbDay = new System.Windows.Forms.TextBox();
            this.tbHour = new System.Windows.Forms.TextBox();
            this.tbMinute = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnMonth = new System.Windows.Forms.RadioButton();
            this.radioBtnWeekend = new System.Windows.Forms.RadioButton();
            this.radioBtnDaily = new System.Windows.Forms.RadioButton();
            this.radioBtnTime = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSetProcess = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(6, 24);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(29, 13);
            this.lbYear.TabIndex = 0;
            this.lbYear.Text = "Year";
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Location = new System.Drawing.Point(6, 67);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(37, 13);
            this.lbMonth.TabIndex = 1;
            this.lbMonth.Text = "Month";
            // 
            // lbDay
            // 
            this.lbDay.AutoSize = true;
            this.lbDay.Location = new System.Drawing.Point(6, 110);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(26, 13);
            this.lbDay.TabIndex = 2;
            this.lbDay.Text = "Day";
            // 
            // lbHour
            // 
            this.lbHour.AutoSize = true;
            this.lbHour.Location = new System.Drawing.Point(6, 153);
            this.lbHour.Name = "lbHour";
            this.lbHour.Size = new System.Drawing.Size(30, 13);
            this.lbHour.TabIndex = 3;
            this.lbHour.Text = "Hour";
            // 
            // lbMinute
            // 
            this.lbMinute.AutoSize = true;
            this.lbMinute.Location = new System.Drawing.Point(6, 196);
            this.lbMinute.Name = "lbMinute";
            this.lbMinute.Size = new System.Drawing.Size(39, 13);
            this.lbMinute.TabIndex = 4;
            this.lbMinute.Text = "Minute";
            // 
            // btnSetTime
            // 
            this.btnSetTime.Location = new System.Drawing.Point(151, 232);
            this.btnSetTime.Name = "btnSetTime";
            this.btnSetTime.Size = new System.Drawing.Size(75, 23);
            this.btnSetTime.TabIndex = 5;
            this.btnSetTime.Text = "Run process";
            this.btnSetTime.UseVisualStyleBackColor = true;
            this.btnSetTime.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(52, 22);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(50, 20);
            this.tbYear.TabIndex = 6;
            // 
            // tbMonth
            // 
            this.tbMonth.Location = new System.Drawing.Point(52, 64);
            this.tbMonth.Name = "tbMonth";
            this.tbMonth.Size = new System.Drawing.Size(50, 20);
            this.tbMonth.TabIndex = 7;
            // 
            // tbDay
            // 
            this.tbDay.Location = new System.Drawing.Point(52, 107);
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(50, 20);
            this.tbDay.TabIndex = 8;
            // 
            // tbHour
            // 
            this.tbHour.Location = new System.Drawing.Point(52, 150);
            this.tbHour.Name = "tbHour";
            this.tbHour.Size = new System.Drawing.Size(50, 20);
            this.tbHour.TabIndex = 9;
            // 
            // tbMinute
            // 
            this.tbMinute.Location = new System.Drawing.Point(52, 193);
            this.tbMinute.Name = "tbMinute";
            this.tbMinute.Size = new System.Drawing.Size(50, 20);
            this.tbMinute.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnMonth);
            this.groupBox1.Controls.Add(this.radioBtnWeekend);
            this.groupBox1.Controls.Add(this.radioBtnDaily);
            this.groupBox1.Controls.Add(this.radioBtnTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(151, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 206);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frequency";
            // 
            // radioBtnMonth
            // 
            this.radioBtnMonth.AutoSize = true;
            this.radioBtnMonth.Location = new System.Drawing.Point(82, 168);
            this.radioBtnMonth.Name = "radioBtnMonth";
            this.radioBtnMonth.Size = new System.Drawing.Size(14, 13);
            this.radioBtnMonth.TabIndex = 7;
            this.radioBtnMonth.TabStop = true;
            this.radioBtnMonth.UseVisualStyleBackColor = true;
            // 
            // radioBtnWeekend
            // 
            this.radioBtnWeekend.AutoSize = true;
            this.radioBtnWeekend.Location = new System.Drawing.Point(82, 120);
            this.radioBtnWeekend.Name = "radioBtnWeekend";
            this.radioBtnWeekend.Size = new System.Drawing.Size(14, 13);
            this.radioBtnWeekend.TabIndex = 6;
            this.radioBtnWeekend.TabStop = true;
            this.radioBtnWeekend.UseVisualStyleBackColor = true;
            // 
            // radioBtnDaily
            // 
            this.radioBtnDaily.AutoSize = true;
            this.radioBtnDaily.Location = new System.Drawing.Point(82, 74);
            this.radioBtnDaily.Name = "radioBtnDaily";
            this.radioBtnDaily.Size = new System.Drawing.Size(14, 13);
            this.radioBtnDaily.TabIndex = 5;
            this.radioBtnDaily.TabStop = true;
            this.radioBtnDaily.UseVisualStyleBackColor = true;
            // 
            // radioBtnTime
            // 
            this.radioBtnTime.AutoSize = true;
            this.radioBtnTime.Location = new System.Drawing.Point(82, 32);
            this.radioBtnTime.Name = "radioBtnTime";
            this.radioBtnTime.Size = new System.Drawing.Size(14, 13);
            this.radioBtnTime.TabIndex = 4;
            this.radioBtnTime.TabStop = true;
            this.radioBtnTime.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monthly";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weekly";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Daily";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbYear);
            this.groupBox2.Controls.Add(this.lbMonth);
            this.groupBox2.Controls.Add(this.tbMinute);
            this.groupBox2.Controls.Add(this.lbDay);
            this.groupBox2.Controls.Add(this.tbHour);
            this.groupBox2.Controls.Add(this.lbHour);
            this.groupBox2.Controls.Add(this.tbDay);
            this.groupBox2.Controls.Add(this.lbMinute);
            this.groupBox2.Controls.Add(this.tbMonth);
            this.groupBox2.Controls.Add(this.tbYear);
            this.groupBox2.Location = new System.Drawing.Point(12, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(111, 225);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // btnSetProcess
            // 
            this.btnSetProcess.Location = new System.Drawing.Point(48, 232);
            this.btnSetProcess.Name = "btnSetProcess";
            this.btnSetProcess.Size = new System.Drawing.Size(75, 23);
            this.btnSetProcess.TabIndex = 13;
            this.btnSetProcess.Text = "Set process";
            this.btnSetProcess.UseVisualStyleBackColor = true;
            this.btnSetProcess.Click += new System.EventHandler(this.btnSetProcess_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(151, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 14;
            // 
            // FormSetTimeProc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSetProcess);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSetTime);
            this.Name = "FormSetTimeProc";
            this.Text = "FormSetTimeProc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.Label lbHour;
        private System.Windows.Forms.Label lbMinute;
        private System.Windows.Forms.Button btnSetTime;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbMonth;
        private System.Windows.Forms.TextBox tbDay;
        private System.Windows.Forms.TextBox tbHour;
        private System.Windows.Forms.TextBox tbMinute;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnMonth;
        private System.Windows.Forms.RadioButton radioBtnWeekend;
        private System.Windows.Forms.RadioButton radioBtnDaily;
        private System.Windows.Forms.RadioButton radioBtnTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSetProcess;
        private System.Windows.Forms.Label label5;
    }
}