namespace Registry.Forms.Doctors
{
    partial class CreateConclusion
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
            this.Conclusion_label = new System.Windows.Forms.Label();
            this.Diagnos_label = new System.Windows.Forms.Label();
            this.Diagnosis_textBox = new System.Windows.Forms.TextBox();
            this.Treatment_textBox = new System.Windows.Forms.RichTextBox();
            this.Create_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Conclusion_label
            // 
            this.Conclusion_label.AutoSize = true;
            this.Conclusion_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Conclusion_label.Location = new System.Drawing.Point(154, 179);
            this.Conclusion_label.Name = "Conclusion_label";
            this.Conclusion_label.Size = new System.Drawing.Size(297, 29);
            this.Conclusion_label.TabIndex = 10;
            this.Conclusion_label.Text = "Призначене лікування";
            // 
            // Diagnos_label
            // 
            this.Diagnos_label.AutoSize = true;
            this.Diagnos_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Diagnos_label.Location = new System.Drawing.Point(86, 69);
            this.Diagnos_label.Name = "Diagnos_label";
            this.Diagnos_label.Size = new System.Drawing.Size(78, 20);
            this.Diagnos_label.TabIndex = 9;
            this.Diagnos_label.Text = "Діагноз:";
            // 
            // Diagnosis_textBox
            // 
            this.Diagnosis_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Diagnosis_textBox.Location = new System.Drawing.Point(170, 58);
            this.Diagnosis_textBox.Multiline = true;
            this.Diagnosis_textBox.Name = "Diagnosis_textBox";
            this.Diagnosis_textBox.Size = new System.Drawing.Size(281, 31);
            this.Diagnosis_textBox.TabIndex = 7;
            // 
            // Treatment_textBox
            // 
            this.Treatment_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Treatment_textBox.Location = new System.Drawing.Point(32, 230);
            this.Treatment_textBox.Name = "Treatment_textBox";
            this.Treatment_textBox.Size = new System.Drawing.Size(529, 189);
            this.Treatment_textBox.TabIndex = 11;
            this.Treatment_textBox.Text = "";
            // 
            // Create_btn
            // 
            this.Create_btn.BackColor = System.Drawing.Color.Coral;
            this.Create_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create_btn.Location = new System.Drawing.Point(199, 445);
            this.Create_btn.Name = "Create_btn";
            this.Create_btn.Size = new System.Drawing.Size(210, 41);
            this.Create_btn.TabIndex = 12;
            this.Create_btn.Text = "Призначити ";
            this.Create_btn.UseVisualStyleBackColor = false;
            this.Create_btn.Click += new System.EventHandler(this.Create_btn_Click);
            // 
            // CreateConclusion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(601, 498);
            this.Controls.Add(this.Create_btn);
            this.Controls.Add(this.Treatment_textBox);
            this.Controls.Add(this.Conclusion_label);
            this.Controls.Add(this.Diagnos_label);
            this.Controls.Add(this.Diagnosis_textBox);
            this.Name = "CreateConclusion";
            this.Text = "CreateConclusion";
            this.Load += new System.EventHandler(this.CreateConclusion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Conclusion_label;
        private System.Windows.Forms.Label Diagnos_label;
        private System.Windows.Forms.TextBox Diagnosis_textBox;
        private System.Windows.Forms.RichTextBox Treatment_textBox;
        private System.Windows.Forms.Button Create_btn;
    }
}