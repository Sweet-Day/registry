namespace Registry.Forms.Patients
{
    partial class SelectionPatients
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
            this.Patients_grid = new System.Windows.Forms.DataGridView();
            this.Ok_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Patients_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Patients_grid
            // 
            this.Patients_grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Patients_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Patients_grid.Location = new System.Drawing.Point(27, 11);
            this.Patients_grid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Patients_grid.Name = "Patients_grid";
            this.Patients_grid.Size = new System.Drawing.Size(811, 375);
            this.Patients_grid.TabIndex = 0;
            // 
            // Ok_button
            // 
            this.Ok_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Ok_button.BackColor = System.Drawing.Color.ForestGreen;
            this.Ok_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok_button.Location = new System.Drawing.Point(285, 415);
            this.Ok_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ok_button.Name = "Ok_button";
            this.Ok_button.Size = new System.Drawing.Size(315, 76);
            this.Ok_button.TabIndex = 1;
            this.Ok_button.Text = "Обрати";
            this.Ok_button.UseVisualStyleBackColor = false;
            this.Ok_button.Click += new System.EventHandler(this.Ok_button_Click);
            // 
            // SelectionPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(870, 528);
            this.Controls.Add(this.Ok_button);
            this.Controls.Add(this.Patients_grid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SelectionPatients";
            this.Text = "Виберіть пацієнта";
            this.Load += new System.EventHandler(this.EditPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Patients_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Patients_grid;
        private System.Windows.Forms.Button Ok_button;
    }
}