namespace Zegar_z_alarmem
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
            this.components = new System.ComponentModel.Container();
            this.clockDisplayer = new System.Windows.Forms.Label();
            this.addAlarmBTN = new System.Windows.Forms.Button();
            this.dateLBL = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.bottomLBL = new System.Windows.Forms.Label();
            this.alarmTimeLBL = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // clockDisplayer
            // 
            this.clockDisplayer.AutoSize = true;
            this.clockDisplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clockDisplayer.Location = new System.Drawing.Point(61, 9);
            this.clockDisplayer.Name = "clockDisplayer";
            this.clockDisplayer.Size = new System.Drawing.Size(164, 42);
            this.clockDisplayer.TabIndex = 0;
            this.clockDisplayer.Text = "00:00:00";
            this.clockDisplayer.Click += new System.EventHandler(this.clockDisplayer_Click);
            // 
            // addAlarmBTN
            // 
            this.addAlarmBTN.Location = new System.Drawing.Point(68, 161);
            this.addAlarmBTN.Name = "addAlarmBTN";
            this.addAlarmBTN.Size = new System.Drawing.Size(147, 36);
            this.addAlarmBTN.TabIndex = 1;
            this.addAlarmBTN.Text = "Dodaj alarm";
            this.addAlarmBTN.UseVisualStyleBackColor = true;
            this.addAlarmBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateLBL
            // 
            this.dateLBL.AutoSize = true;
            this.dateLBL.Location = new System.Drawing.Point(108, 51);
            this.dateLBL.Name = "dateLBL";
            this.dateLBL.Size = new System.Drawing.Size(61, 13);
            this.dateLBL.TabIndex = 2;
            this.dateLBL.Text = "01.01.2017";
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // bottomLBL
            // 
            this.bottomLBL.AutoSize = true;
            this.bottomLBL.Location = new System.Drawing.Point(21, 217);
            this.bottomLBL.Name = "bottomLBL";
            this.bottomLBL.Size = new System.Drawing.Size(36, 13);
            this.bottomLBL.TabIndex = 3;
            this.bottomLBL.Text = "Alarm:";
            this.bottomLBL.Visible = false;
            // 
            // alarmTimeLBL
            // 
            this.alarmTimeLBL.AutoSize = true;
            this.alarmTimeLBL.Location = new System.Drawing.Point(63, 217);
            this.alarmTimeLBL.Name = "alarmTimeLBL";
            this.alarmTimeLBL.Size = new System.Drawing.Size(49, 13);
            this.alarmTimeLBL.TabIndex = 4;
            this.alarmTimeLBL.Text = "00:00:00";
            this.alarmTimeLBL.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(82, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.alarmTimeLBL);
            this.Controls.Add(this.bottomLBL);
            this.Controls.Add(this.dateLBL);
            this.Controls.Add(this.addAlarmBTN);
            this.Controls.Add(this.clockDisplayer);
            this.Name = "Form1";
            this.Text = "Zegarek";
            this.Load += new System.EventHandler(this.clockTimer_Tick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clockDisplayer;
        private System.Windows.Forms.Button addAlarmBTN;
        private System.Windows.Forms.Label dateLBL;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Label bottomLBL;
        private System.Windows.Forms.Label alarmTimeLBL;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

