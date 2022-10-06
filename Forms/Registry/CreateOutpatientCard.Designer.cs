namespace Registry.Forms.Registry
{
    partial class CreateOutpatientCard
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
            this.FullName_textBox = new System.Windows.Forms.TextBox();
            this.Address_textBox = new System.Windows.Forms.TextBox();
            this.Contacts_textBox = new System.Windows.Forms.TextBox();
            this.Passport_textBox = new System.Windows.Forms.TextBox();
            this.FullName_label = new System.Windows.Forms.Label();
            this.Address_label = new System.Windows.Forms.Label();
            this.Contacts_label = new System.Windows.Forms.Label();
            this.DateOfbirth_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Gender_label = new System.Windows.Forms.Label();
            this.dateOfBirth_picker = new System.Windows.Forms.DateTimePicker();
            this.Gender_cmb = new System.Windows.Forms.ComboBox();
            this.Save_btn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Cancel_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // FullName_textBox
            // 
            this.FullName_textBox.Location = new System.Drawing.Point(212, 30);
            this.FullName_textBox.Name = "FullName_textBox";
            this.FullName_textBox.Size = new System.Drawing.Size(252, 26);
            this.FullName_textBox.TabIndex = 0;
            this.FullName_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.FullName_textBox_Validating);
            // 
            // Address_textBox
            // 
            this.Address_textBox.Location = new System.Drawing.Point(212, 80);
            this.Address_textBox.Name = "Address_textBox";
            this.Address_textBox.Size = new System.Drawing.Size(252, 26);
            this.Address_textBox.TabIndex = 1;
            this.Address_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.Address_textBox_Validating);
            // 
            // Contacts_textBox
            // 
            this.Contacts_textBox.Location = new System.Drawing.Point(212, 134);
            this.Contacts_textBox.Name = "Contacts_textBox";
            this.Contacts_textBox.Size = new System.Drawing.Size(252, 26);
            this.Contacts_textBox.TabIndex = 2;
            this.Contacts_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.Contacts_textBox_Validating);
            // 
            // Passport_textBox
            // 
            this.Passport_textBox.Location = new System.Drawing.Point(212, 252);
            this.Passport_textBox.Name = "Passport_textBox";
            this.Passport_textBox.Size = new System.Drawing.Size(252, 26);
            this.Passport_textBox.TabIndex = 3;
            this.Passport_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.Passport_textBox_Validating);
            // 
            // FullName_label
            // 
            this.FullName_label.AutoSize = true;
            this.FullName_label.Location = new System.Drawing.Point(145, 36);
            this.FullName_label.Name = "FullName_label";
            this.FullName_label.Size = new System.Drawing.Size(42, 20);
            this.FullName_label.TabIndex = 5;
            this.FullName_label.Text = "ПІП:";
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.Location = new System.Drawing.Point(40, 86);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(166, 20);
            this.Address_label.TabIndex = 6;
            this.Address_label.Text = "Адреса проживання:";
            // 
            // Contacts_label
            // 
            this.Contacts_label.AutoSize = true;
            this.Contacts_label.Location = new System.Drawing.Point(62, 140);
            this.Contacts_label.Name = "Contacts_label";
            this.Contacts_label.Size = new System.Drawing.Size(144, 20);
            this.Contacts_label.TabIndex = 7;
            this.Contacts_label.Text = "Номер телефону:";
            // 
            // DateOfbirth_label
            // 
            this.DateOfbirth_label.AutoSize = true;
            this.DateOfbirth_label.Location = new System.Drawing.Point(56, 199);
            this.DateOfbirth_label.Name = "DateOfbirth_label";
            this.DateOfbirth_label.Size = new System.Drawing.Size(150, 20);
            this.DateOfbirth_label.TabIndex = 8;
            this.DateOfbirth_label.Text = "Дата народження:";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(70, 258);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(136, 20);
            this.Password_label.TabIndex = 9;
            this.Password_label.Text = "Номер паспорту:";
            // 
            // Gender_label
            // 
            this.Gender_label.AutoSize = true;
            this.Gender_label.Location = new System.Drawing.Point(146, 317);
            this.Gender_label.Name = "Gender_label";
            this.Gender_label.Size = new System.Drawing.Size(60, 20);
            this.Gender_label.TabIndex = 10;
            this.Gender_label.Text = "Стать:";
            // 
            // dateOfBirth_picker
            // 
            this.dateOfBirth_picker.Location = new System.Drawing.Point(212, 193);
            this.dateOfBirth_picker.Name = "dateOfBirth_picker";
            this.dateOfBirth_picker.Size = new System.Drawing.Size(252, 26);
            this.dateOfBirth_picker.TabIndex = 11;
            // 
            // Gender_cmb
            // 
            this.Gender_cmb.FormattingEnabled = true;
            this.Gender_cmb.Location = new System.Drawing.Point(212, 314);
            this.Gender_cmb.Name = "Gender_cmb";
            this.Gender_cmb.Size = new System.Drawing.Size(112, 28);
            this.Gender_cmb.TabIndex = 12;
            this.Gender_cmb.Validating += new System.ComponentModel.CancelEventHandler(this.Gender_cmb_Validating);
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.Color.Green;
            this.Save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_btn.Location = new System.Drawing.Point(139, 391);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(185, 56);
            this.Save_btn.TabIndex = 13;
            this.Save_btn.Text = "Зберегти";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.Cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_btn.Location = new System.Drawing.Point(330, 391);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(185, 56);
            this.Cancel_btn.TabIndex = 14;
            this.Cancel_btn.Text = "Відмінити";
            this.Cancel_btn.UseVisualStyleBackColor = false;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // CreateOutpatientCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 492);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Gender_cmb);
            this.Controls.Add(this.dateOfBirth_picker);
            this.Controls.Add(this.Gender_label);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.DateOfbirth_label);
            this.Controls.Add(this.Contacts_label);
            this.Controls.Add(this.Address_label);
            this.Controls.Add(this.FullName_label);
            this.Controls.Add(this.Passport_textBox);
            this.Controls.Add(this.Contacts_textBox);
            this.Controls.Add(this.Address_textBox);
            this.Controls.Add(this.FullName_textBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateOutpatientCard";
            this.Text = "CreateOutpatientCard";
            this.Load += new System.EventHandler(this.CreateOutpatientCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FullName_textBox;
        private System.Windows.Forms.TextBox Address_textBox;
        private System.Windows.Forms.TextBox Contacts_textBox;
        private System.Windows.Forms.TextBox Passport_textBox;
        private System.Windows.Forms.Label FullName_label;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.Label Contacts_label;
        private System.Windows.Forms.Label DateOfbirth_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Label Gender_label;
        private System.Windows.Forms.DateTimePicker dateOfBirth_picker;
        private System.Windows.Forms.ComboBox Gender_cmb;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Cancel_btn;
    }
}