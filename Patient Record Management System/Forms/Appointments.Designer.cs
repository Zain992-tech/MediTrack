namespace Patient_Record_Management_System
{
    partial class Appointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointments));
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.GridPanel = new System.Windows.Forms.Panel();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.PatientCNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Symptoms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.BackGuna2Button = new Guna.UI2.WinForms.Guna2Button();
            this.CheckGuna2Button = new Guna.UI2.WinForms.Guna2Button();
            this.TableLayoutPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.GridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.guna2Panel1.SuspendLayout();
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
            this.TableLayoutPanel.Controls.Add(this.guna2Panel1, 1, 2);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 3;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.TableLayoutPanel.TabIndex = 1;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.TableLayoutPanel.SetColumnSpan(this.HeaderPanel, 3);
            this.HeaderPanel.Controls.Add(this.SubtitleLabel);
            this.HeaderPanel.Controls.Add(this.TitleLabel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(800, 97);
            this.HeaderPanel.TabIndex = 3;
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.SubtitleLabel.Location = new System.Drawing.Point(263, 65);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(317, 19);
            this.SubtitleLabel.TabIndex = 3;
            this.SubtitleLabel.Text = "Manage and Track Patient Appointment Schedules";
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.TitleLabel.Location = new System.Drawing.Point(243, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(355, 45);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Today\'s Appointments";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.PatientCNIC,
            this.PatientName,
            this.AppointmentDate,
            this.AppointmentTime,
            this.Symptoms,
            this.CreatedAt});
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(15, 15);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(690, 240);
            this.DataGridView.TabIndex = 2;
            // 
            // PatientCNIC
            // 
            this.PatientCNIC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PatientCNIC.DataPropertyName = "Patient CNIC";
            this.PatientCNIC.HeaderText = "Patient CNIC";
            this.PatientCNIC.Name = "PatientCNIC";
            this.PatientCNIC.ReadOnly = true;
            // 
            // PatientName
            // 
            this.PatientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PatientName.DataPropertyName = "Patient Name";
            this.PatientName.HeaderText = "Patient Name";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            // 
            // AppointmentDate
            // 
            this.AppointmentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AppointmentDate.DataPropertyName = "Appointment Date";
            this.AppointmentDate.HeaderText = "Appointment Date";
            this.AppointmentDate.Name = "AppointmentDate";
            this.AppointmentDate.ReadOnly = true;
            // 
            // AppointmentTime
            // 
            this.AppointmentTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AppointmentTime.DataPropertyName = "Appointment Time";
            this.AppointmentTime.HeaderText = "Appointment Time";
            this.AppointmentTime.Name = "AppointmentTime";
            this.AppointmentTime.ReadOnly = true;
            // 
            // Symptoms
            // 
            this.Symptoms.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Symptoms.DataPropertyName = "Symptoms";
            this.Symptoms.HeaderText = "Symptoms";
            this.Symptoms.Name = "Symptoms";
            this.Symptoms.ReadOnly = true;
            // 
            // CreatedAt
            // 
            this.CreatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CreatedAt.DataPropertyName = "Created At";
            this.CreatedAt.HeaderText = "Created At";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.BackGuna2Button);
            this.guna2Panel1.Controls.Add(this.CheckGuna2Button);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(43, 385);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(714, 62);
            this.guna2Panel1.TabIndex = 7;
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
            this.BackGuna2Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.BackGuna2Button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BackGuna2Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.BackGuna2Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.BackGuna2Button.Location = new System.Drawing.Point(101, 8);
            this.BackGuna2Button.Name = "BackGuna2Button";
            this.BackGuna2Button.Size = new System.Drawing.Size(137, 45);
            this.BackGuna2Button.TabIndex = 5;
            this.BackGuna2Button.Text = "Back to Dashboard";
            this.BackGuna2Button.Click += new System.EventHandler(this.BackGuna2Button_Click);
            // 
            // CheckGuna2Button
            // 
            this.CheckGuna2Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CheckGuna2Button.AutoRoundedCorners = true;
            this.CheckGuna2Button.BackColor = System.Drawing.Color.Transparent;
            this.CheckGuna2Button.BorderColor = System.Drawing.Color.White;
            this.CheckGuna2Button.BorderThickness = 2;
            this.CheckGuna2Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckGuna2Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CheckGuna2Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CheckGuna2Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CheckGuna2Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CheckGuna2Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.CheckGuna2Button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.CheckGuna2Button.ForeColor = System.Drawing.Color.White;
            this.CheckGuna2Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.CheckGuna2Button.Location = new System.Drawing.Point(485, 8);
            this.CheckGuna2Button.Name = "CheckGuna2Button";
            this.CheckGuna2Button.Size = new System.Drawing.Size(124, 45);
            this.CheckGuna2Button.TabIndex = 6;
            this.CheckGuna2Button.Text = "Check Patient";
            this.CheckGuna2Button.Click += new System.EventHandler(this.CheckGuna2Button_Click);
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Appointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointments";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Appointments_Load);
            this.TableLayoutPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.GridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel GridPanel;
        private System.Windows.Forms.DataGridView DataGridView;
        private Guna.UI2.WinForms.Guna2Button BackGuna2Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientCNIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symptoms;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button CheckGuna2Button;
    }
}