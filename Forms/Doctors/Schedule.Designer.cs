namespace Registry.Forms.Doctors
{
    partial class Schedule
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
            this.DoctorsName_label = new System.Windows.Forms.Label();
            this.Speciality_label = new System.Windows.Forms.Label();
            this.Time_label = new System.Windows.Forms.Label();
            this.daysOfweek_cmb = new System.Windows.Forms.ComboBox();
            this.FreeTime_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DoctorsName_label
            // 
            this.DoctorsName_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.DoctorsName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoctorsName_label.Location = new System.Drawing.Point(0, 0);
            this.DoctorsName_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DoctorsName_label.Name = "DoctorsName_label";
            this.DoctorsName_label.Size = new System.Drawing.Size(450, 52);
            this.DoctorsName_label.TabIndex = 0;
            this.DoctorsName_label.Text = "Лікар:";
            this.DoctorsName_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Speciality_label
            // 
            this.Speciality_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Speciality_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Speciality_label.Location = new System.Drawing.Point(0, 52);
            this.Speciality_label.Name = "Speciality_label";
            this.Speciality_label.Size = new System.Drawing.Size(450, 36);
            this.Speciality_label.TabIndex = 1;
            this.Speciality_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Time_label
            // 
            this.Time_label.AutoSize = true;
            this.Time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time_label.Location = new System.Drawing.Point(28, 212);
            this.Time_label.Name = "Time_label";
            this.Time_label.Size = new System.Drawing.Size(0, 24);
            this.Time_label.TabIndex = 2;
            // 
            // daysOfweek_cmb
            // 
            this.daysOfweek_cmb.FormattingEnabled = true;
            this.daysOfweek_cmb.Location = new System.Drawing.Point(137, 129);
            this.daysOfweek_cmb.Name = "daysOfweek_cmb";
            this.daysOfweek_cmb.Size = new System.Drawing.Size(179, 28);
            this.daysOfweek_cmb.TabIndex = 3;
            this.daysOfweek_cmb.SelectedIndexChanged += new System.EventHandler(this.daysOfweek_cmb_SelectedIndexChanged);
            // 
            // FreeTime_label
            // 
            this.FreeTime_label.AutoSize = true;
            this.FreeTime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FreeTime_label.Location = new System.Drawing.Point(325, 212);
            this.FreeTime_label.Name = "FreeTime_label";
            this.FreeTime_label.Size = new System.Drawing.Size(0, 24);
            this.FreeTime_label.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Виберіть день тижня:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(450, 468);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FreeTime_label);
            this.Controls.Add(this.daysOfweek_cmb);
            this.Controls.Add(this.Time_label);
            this.Controls.Add(this.Speciality_label);
            this.Controls.Add(this.DoctorsName_label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.Schedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DoctorsName_label;
        private System.Windows.Forms.Label Speciality_label;
        private System.Windows.Forms.Label Time_label;
        private System.Windows.Forms.ComboBox daysOfweek_cmb;
        private System.Windows.Forms.Label FreeTime_label;
        private System.Windows.Forms.Label label1;
    }
}