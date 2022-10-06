namespace Registry.Forms.Patients
{
    partial class MakeAnAppointment
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
            this.Speciality_label = new System.Windows.Forms.Label();
            this.DoctorsName_label = new System.Windows.Forms.Label();
            this.SelectDate_picker = new System.Windows.Forms.DateTimePicker();
            this.selectDate_label = new System.Windows.Forms.Label();
            this.selectTime_label = new System.Windows.Forms.Label();
            this.SelectTime_cmb = new System.Windows.Forms.ComboBox();
            this.ok_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Speciality_label
            // 
            this.Speciality_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Speciality_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Speciality_label.Location = new System.Drawing.Point(0, 80);
            this.Speciality_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Speciality_label.Name = "Speciality_label";
            this.Speciality_label.Size = new System.Drawing.Size(430, 55);
            this.Speciality_label.TabIndex = 7;
            this.Speciality_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DoctorsName_label
            // 
            this.DoctorsName_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.DoctorsName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoctorsName_label.Location = new System.Drawing.Point(0, 0);
            this.DoctorsName_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.DoctorsName_label.Name = "DoctorsName_label";
            this.DoctorsName_label.Size = new System.Drawing.Size(430, 80);
            this.DoctorsName_label.TabIndex = 6;
            this.DoctorsName_label.Text = "Лікар:";
            this.DoctorsName_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectDate_picker
            // 
            this.SelectDate_picker.Location = new System.Drawing.Point(204, 187);
            this.SelectDate_picker.Name = "SelectDate_picker";
            this.SelectDate_picker.Size = new System.Drawing.Size(203, 26);
            this.SelectDate_picker.TabIndex = 8;
            this.SelectDate_picker.ValueChanged += new System.EventHandler(this.SelectDate_picker_ValueChanged);
            // 
            // selectDate_label
            // 
            this.selectDate_label.AutoSize = true;
            this.selectDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectDate_label.Location = new System.Drawing.Point(65, 192);
            this.selectDate_label.Name = "selectDate_label";
            this.selectDate_label.Size = new System.Drawing.Size(121, 20);
            this.selectDate_label.TabIndex = 9;
            this.selectDate_label.Text = "Оберіть дату";
            // 
            // selectTime_label
            // 
            this.selectTime_label.AutoSize = true;
            this.selectTime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectTime_label.Location = new System.Drawing.Point(8, 247);
            this.selectTime_label.Name = "selectTime_label";
            this.selectTime_label.Size = new System.Drawing.Size(185, 20);
            this.selectTime_label.TabIndex = 10;
            this.selectTime_label.Text = "Оберіть час прийому";
            // 
            // SelectTime_cmb
            // 
            this.SelectTime_cmb.FormattingEnabled = true;
            this.SelectTime_cmb.Location = new System.Drawing.Point(204, 245);
            this.SelectTime_cmb.Name = "SelectTime_cmb";
            this.SelectTime_cmb.Size = new System.Drawing.Size(203, 28);
            this.SelectTime_cmb.TabIndex = 11;
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.ok_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ok_btn.Location = new System.Drawing.Point(130, 341);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(176, 56);
            this.ok_btn.TabIndex = 12;
            this.ok_btn.Text = "Записатися ✔️";
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // MakeAnAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 444);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.SelectTime_cmb);
            this.Controls.Add(this.selectTime_label);
            this.Controls.Add(this.selectDate_label);
            this.Controls.Add(this.SelectDate_picker);
            this.Controls.Add(this.Speciality_label);
            this.Controls.Add(this.DoctorsName_label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MakeAnAppointment";
            this.Text = "MakeAnAppointment";
            this.Load += new System.EventHandler(this.MakeAnAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Speciality_label;
        private System.Windows.Forms.Label DoctorsName_label;
        private System.Windows.Forms.DateTimePicker SelectDate_picker;
        private System.Windows.Forms.Label selectDate_label;
        private System.Windows.Forms.Label selectTime_label;
        private System.Windows.Forms.ComboBox SelectTime_cmb;
        private System.Windows.Forms.Button ok_btn;
    }
}