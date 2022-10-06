namespace Registry.Forms
{
    partial class MainForm
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
            this.Registry_mainPanel = new System.Windows.Forms.TabControl();
            this.Appointment_tab = new System.Windows.Forms.TabPage();
            this.Search_appointment_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Select_datePicker = new System.Windows.Forms.DateTimePicker();
            this.Doctors_cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Appointments_grid = new System.Windows.Forms.DataGridView();
            this.Doctors_tab = new System.Windows.Forms.TabPage();
            this.Doctors_grid = new System.Windows.Forms.DataGridView();
            this.OutpatientCard_tab = new System.Windows.Forms.TabPage();
            this.CreateCard_btn = new System.Windows.Forms.Button();
            this.Outpatient_cards_grid = new System.Windows.Forms.DataGridView();
            this.Registry_mainPanel.SuspendLayout();
            this.Appointment_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Appointments_grid)).BeginInit();
            this.Doctors_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Doctors_grid)).BeginInit();
            this.OutpatientCard_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Outpatient_cards_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Registry_mainPanel
            // 
            this.Registry_mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Registry_mainPanel.Controls.Add(this.Appointment_tab);
            this.Registry_mainPanel.Controls.Add(this.Doctors_tab);
            this.Registry_mainPanel.Controls.Add(this.OutpatientCard_tab);
            this.Registry_mainPanel.Location = new System.Drawing.Point(3, 4);
            this.Registry_mainPanel.Name = "Registry_mainPanel";
            this.Registry_mainPanel.SelectedIndex = 0;
            this.Registry_mainPanel.Size = new System.Drawing.Size(857, 510);
            this.Registry_mainPanel.TabIndex = 0;
            // 
            // Appointment_tab
            // 
            this.Appointment_tab.Controls.Add(this.Search_appointment_btn);
            this.Appointment_tab.Controls.Add(this.label2);
            this.Appointment_tab.Controls.Add(this.Select_datePicker);
            this.Appointment_tab.Controls.Add(this.Doctors_cmb);
            this.Appointment_tab.Controls.Add(this.label1);
            this.Appointment_tab.Controls.Add(this.Appointments_grid);
            this.Appointment_tab.Location = new System.Drawing.Point(4, 29);
            this.Appointment_tab.Name = "Appointment_tab";
            this.Appointment_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Appointment_tab.Size = new System.Drawing.Size(849, 477);
            this.Appointment_tab.TabIndex = 0;
            this.Appointment_tab.Text = "Записи";
            this.Appointment_tab.UseVisualStyleBackColor = true;
            // 
            // Search_appointment_btn
            // 
            this.Search_appointment_btn.Location = new System.Drawing.Point(642, 24);
            this.Search_appointment_btn.Name = "Search_appointment_btn";
            this.Search_appointment_btn.Size = new System.Drawing.Size(111, 29);
            this.Search_appointment_btn.TabIndex = 5;
            this.Search_appointment_btn.Text = "Знайти";
            this.Search_appointment_btn.UseVisualStyleBackColor = true;
            this.Search_appointment_btn.Click += new System.EventHandler(this.Search_appointment_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(345, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата:";
            // 
            // Select_datePicker
            // 
            this.Select_datePicker.Location = new System.Drawing.Point(408, 23);
            this.Select_datePicker.Name = "Select_datePicker";
            this.Select_datePicker.Size = new System.Drawing.Size(200, 26);
            this.Select_datePicker.TabIndex = 3;
            // 
            // Doctors_cmb
            // 
            this.Doctors_cmb.FormattingEnabled = true;
            this.Doctors_cmb.Location = new System.Drawing.Point(121, 24);
            this.Doctors_cmb.Name = "Doctors_cmb";
            this.Doctors_cmb.Size = new System.Drawing.Size(197, 28);
            this.Doctors_cmb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(58, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Лікар:";
            // 
            // Appointments_grid
            // 
            this.Appointments_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Appointments_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Appointments_grid.Location = new System.Drawing.Point(8, 59);
            this.Appointments_grid.Name = "Appointments_grid";
            this.Appointments_grid.Size = new System.Drawing.Size(835, 411);
            this.Appointments_grid.TabIndex = 0;
            this.Appointments_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Appointments_grid_CellContentClick);
            // 
            // Doctors_tab
            // 
            this.Doctors_tab.Controls.Add(this.Doctors_grid);
            this.Doctors_tab.Location = new System.Drawing.Point(4, 29);
            this.Doctors_tab.Name = "Doctors_tab";
            this.Doctors_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Doctors_tab.Size = new System.Drawing.Size(849, 477);
            this.Doctors_tab.TabIndex = 1;
            this.Doctors_tab.Text = "Лікарі";
            this.Doctors_tab.UseVisualStyleBackColor = true;
            // 
            // Doctors_grid
            // 
            this.Doctors_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Doctors_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Doctors_grid.Location = new System.Drawing.Point(6, 6);
            this.Doctors_grid.Name = "Doctors_grid";
            this.Doctors_grid.Size = new System.Drawing.Size(837, 465);
            this.Doctors_grid.TabIndex = 1;
            this.Doctors_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Doctors_grid_CellContentClick);
            // 
            // OutpatientCard_tab
            // 
            this.OutpatientCard_tab.BackColor = System.Drawing.Color.Gainsboro;
            this.OutpatientCard_tab.Controls.Add(this.CreateCard_btn);
            this.OutpatientCard_tab.Controls.Add(this.Outpatient_cards_grid);
            this.OutpatientCard_tab.Location = new System.Drawing.Point(4, 29);
            this.OutpatientCard_tab.Name = "OutpatientCard_tab";
            this.OutpatientCard_tab.Padding = new System.Windows.Forms.Padding(3);
            this.OutpatientCard_tab.Size = new System.Drawing.Size(849, 477);
            this.OutpatientCard_tab.TabIndex = 2;
            this.OutpatientCard_tab.Text = "Амбулаторні картки";
            // 
            // CreateCard_btn
            // 
            this.CreateCard_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CreateCard_btn.BackColor = System.Drawing.Color.Orange;
            this.CreateCard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateCard_btn.Location = new System.Drawing.Point(257, 373);
            this.CreateCard_btn.Name = "CreateCard_btn";
            this.CreateCard_btn.Size = new System.Drawing.Size(354, 48);
            this.CreateCard_btn.TabIndex = 1;
            this.CreateCard_btn.Text = "Створити картку";
            this.CreateCard_btn.UseVisualStyleBackColor = false;
            this.CreateCard_btn.Click += new System.EventHandler(this.CreateCard_btn_Click);
            // 
            // Outpatient_cards_grid
            // 
            this.Outpatient_cards_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Outpatient_cards_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Outpatient_cards_grid.Location = new System.Drawing.Point(6, 6);
            this.Outpatient_cards_grid.Name = "Outpatient_cards_grid";
            this.Outpatient_cards_grid.Size = new System.Drawing.Size(835, 361);
            this.Outpatient_cards_grid.TabIndex = 0;
            this.Outpatient_cards_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Outpatient_cards_grid_CellContentClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 515);
            this.Controls.Add(this.Registry_mainPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Registry_mainPanel.ResumeLayout(false);
            this.Appointment_tab.ResumeLayout(false);
            this.Appointment_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Appointments_grid)).EndInit();
            this.Doctors_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Doctors_grid)).EndInit();
            this.OutpatientCard_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Outpatient_cards_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Registry_mainPanel;
        private System.Windows.Forms.TabPage Appointment_tab;
        private System.Windows.Forms.TabPage Doctors_tab;
        private System.Windows.Forms.TabPage OutpatientCard_tab;
        private System.Windows.Forms.DataGridView Doctors_grid;
        private System.Windows.Forms.DataGridView Appointments_grid;
        private System.Windows.Forms.DataGridView Outpatient_cards_grid;
        private System.Windows.Forms.Button CreateCard_btn;
        private System.Windows.Forms.ComboBox Doctors_cmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Select_datePicker;
        private System.Windows.Forms.Button Search_appointment_btn;
        private System.Windows.Forms.Label label2;
    }
}