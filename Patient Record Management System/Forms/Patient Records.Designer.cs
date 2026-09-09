namespace Patient_Record_Management_System
{
    partial class Records
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Records));
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.PatientRecordsLabel = new System.Windows.Forms.Label();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.GridPanel = new System.Windows.Forms.Panel();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.PCNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackGuna2Button = new Guna.UI2.WinForms.Guna2Button();
            this.TableLayoutPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.GridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 3;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TableLayoutPanel.Controls.Add(this.HeaderPanel, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.GridPanel, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.BackGuna2Button, 1, 2);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 3;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.TableLayoutPanel.TabIndex = 0;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.TableLayoutPanel.SetColumnSpan(this.HeaderPanel, 3);
            this.HeaderPanel.Controls.Add(this.SubtitleLabel);
            this.HeaderPanel.Controls.Add(this.PatientRecordsLabel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(800, 97);
            this.HeaderPanel.TabIndex = 3;
            // 
            // PatientRecordsLabel
            // 
            this.PatientRecordsLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PatientRecordsLabel.AutoSize = true;
            this.PatientRecordsLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientRecordsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.PatientRecordsLabel.Location = new System.Drawing.Point(274, 9);
            this.PatientRecordsLabel.Name = "PatientRecordsLabel";
            this.PatientRecordsLabel.Size = new System.Drawing.Size(253, 45);
            this.PatientRecordsLabel.TabIndex = 2;
            this.PatientRecordsLabel.Text = "Patient Records";
            this.PatientRecordsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.SubtitleLabel.Location = new System.Drawing.Point(266, 65);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(269, 19);
            this.SubtitleLabel.TabIndex = 3;
            this.SubtitleLabel.Text = "View and Manage Patient Medical Records";
            // 
            // GridPanel
            // 
            this.GridPanel.BackColor = System.Drawing.Color.White;
            this.GridPanel.Controls.Add(this.DataGridView);
            this.GridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPanel.Location = new System.Drawing.Point(40, 112);
            this.GridPanel.Margin = new System.Windows.Forms.Padding(0);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Padding = new System.Windows.Forms.Padding(15);
            this.GridPanel.Size = new System.Drawing.Size(720, 270);
            this.GridPanel.TabIndex = 4;
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PCNIC,
            this.PName,
            this.Age,
            this.Gender,
            this.Phone,
            this.Address,
            this.Diagnosis,
            this.Prescription,
            this.VisitDate});
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(15, 15);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(690, 240);
            this.DataGridView.TabIndex = 2;
            // 
            // PCNIC
            // 
            this.PCNIC.DataPropertyName = "Patient CNIC";
            this.PCNIC.HeaderText = "Patient CNIC";
            this.PCNIC.Name = "PCNIC";
            this.PCNIC.ReadOnly = true;
            // 
            // PName
            // 
            this.PName.DataPropertyName = "Patient Name";
            this.PName.HeaderText = "Patient Name";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Diagnosis
            // 
            this.Diagnosis.DataPropertyName = "Diagnosis";
            this.Diagnosis.HeaderText = "Diagnosis";
            this.Diagnosis.Name = "Diagnosis";
            this.Diagnosis.ReadOnly = true;
            // 
            // Prescription
            // 
            this.Prescription.DataPropertyName = "Prescription";
            this.Prescription.HeaderText = "Prescription";
            this.Prescription.Name = "Prescription";
            this.Prescription.ReadOnly = true;
            // 
            // VisitDate
            // 
            this.VisitDate.DataPropertyName = "Visit Date";
            this.VisitDate.HeaderText = "Visit Date";
            this.VisitDate.Name = "VisitDate";
            this.VisitDate.ReadOnly = true;
            // 
            // BackGuna2Button
            // 
            this.BackGuna2Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackGuna2Button.AutoRoundedCorners = true;
            this.BackGuna2Button.BackColor = System.Drawing.Color.Transparent;
            this.BackGuna2Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.BackGuna2Button.BorderThickness = 2;
            this.BackGuna2Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackGuna2Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackGuna2Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackGuna2Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackGuna2Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackGuna2Button.FillColor = System.Drawing.Color.White;
            this.BackGuna2Button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BackGuna2Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.BackGuna2Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.BackGuna2Button.Location = new System.Drawing.Point(317, 393);
            this.BackGuna2Button.Name = "BackGuna2Button";
            this.BackGuna2Button.Size = new System.Drawing.Size(165, 45);
            this.BackGuna2Button.TabIndex = 5;
            this.BackGuna2Button.Text = "Back to Dashboard";
            this.BackGuna2Button.Click += new System.EventHandler(this.BackGuna2Button_Click);
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Records";
            this.Text = "Patient Records";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Patient_Records_Load);
            this.TableLayoutPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.GridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.Label PatientRecordsLabel;
        private System.Windows.Forms.Panel GridPanel;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCNIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitDate;
        private Guna.UI2.WinForms.Guna2Button BackGuna2Button;
    }
}