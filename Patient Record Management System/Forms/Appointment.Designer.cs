namespace Patient_Record_Management_System
{
    partial class Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.AppointmentGuna2Button = new Guna.UI2.WinForms.Guna2Button();
            this.SymptomsLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DoctorLabel = new System.Windows.Forms.Label();
            this.TimeGuna2ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SymptomsGuna2TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.DateGuna2DateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.SelectDoctorGuna2ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.AppointmentGuna2Button);
            this.MainPanel.Controls.Add(this.SymptomsLabel);
            this.MainPanel.Controls.Add(this.TimeLabel);
            this.MainPanel.Controls.Add(this.DateLabel);
            this.MainPanel.Controls.Add(this.DoctorLabel);
            this.MainPanel.Controls.Add(this.TimeGuna2ComboBox);
            this.MainPanel.Controls.Add(this.SymptomsGuna2TextBox);
            this.MainPanel.Controls.Add(this.DateGuna2DateTimePicker);
            this.MainPanel.Controls.Add(this.SelectDoctorGuna2ComboBox);
            this.MainPanel.Controls.Add(this.SubtitleLabel);
            this.MainPanel.Controls.Add(this.TitleLabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(25);
            this.MainPanel.Size = new System.Drawing.Size(604, 618);
            this.MainPanel.TabIndex = 0;
            // 
            // AppointmentGuna2Button
            // 
            this.AppointmentGuna2Button.AutoRoundedCorners = true;
            this.AppointmentGuna2Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppointmentGuna2Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AppointmentGuna2Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AppointmentGuna2Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AppointmentGuna2Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AppointmentGuna2Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.AppointmentGuna2Button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.AppointmentGuna2Button.ForeColor = System.Drawing.Color.White;
            this.AppointmentGuna2Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.AppointmentGuna2Button.Location = new System.Drawing.Point(221, 479);
            this.AppointmentGuna2Button.Name = "AppointmentGuna2Button";
            this.AppointmentGuna2Button.Size = new System.Drawing.Size(153, 60);
            this.AppointmentGuna2Button.TabIndex = 16;
            this.AppointmentGuna2Button.Text = "Book Appointment";
            this.AppointmentGuna2Button.Click += new System.EventHandler(this.AppointmentGuna2Button_Click);
            // 
            // SymptomsLabel
            // 
            this.SymptomsLabel.AutoSize = true;
            this.SymptomsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SymptomsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.SymptomsLabel.Location = new System.Drawing.Point(167, 352);
            this.SymptomsLabel.Name = "SymptomsLabel";
            this.SymptomsLabel.Size = new System.Drawing.Size(80, 19);
            this.SymptomsLabel.TabIndex = 15;
            this.SymptomsLabel.Text = "Symptoms";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.TimeLabel.Location = new System.Drawing.Point(167, 282);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(42, 19);
            this.TimeLabel.TabIndex = 14;
            this.TimeLabel.Text = "Time";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.DateLabel.Location = new System.Drawing.Point(167, 197);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(40, 19);
            this.DateLabel.TabIndex = 13;
            this.DateLabel.Text = "Date";
            // 
            // DoctorLabel
            // 
            this.DoctorLabel.AutoSize = true;
            this.DoctorLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.DoctorLabel.Location = new System.Drawing.Point(167, 126);
            this.DoctorLabel.Name = "DoctorLabel";
            this.DoctorLabel.Size = new System.Drawing.Size(99, 19);
            this.DoctorLabel.TabIndex = 12;
            this.DoctorLabel.Text = "Select Doctor";
            // 
            // TimeGuna2ComboBox
            // 
            this.TimeGuna2ComboBox.BackColor = System.Drawing.Color.White;
            this.TimeGuna2ComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.TimeGuna2ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TimeGuna2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeGuna2ComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.TimeGuna2ComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.TimeGuna2ComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TimeGuna2ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.TimeGuna2ComboBox.ItemHeight = 30;
            this.TimeGuna2ComboBox.Location = new System.Drawing.Point(171, 304);
            this.TimeGuna2ComboBox.Name = "TimeGuna2ComboBox";
            this.TimeGuna2ComboBox.Size = new System.Drawing.Size(265, 36);
            this.TimeGuna2ComboBox.TabIndex = 9;
            // 
            // SymptomsGuna2TextBox
            // 
            this.SymptomsGuna2TextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.SymptomsGuna2TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SymptomsGuna2TextBox.DefaultText = "";
            this.SymptomsGuna2TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SymptomsGuna2TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SymptomsGuna2TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SymptomsGuna2TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SymptomsGuna2TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.SymptomsGuna2TextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SymptomsGuna2TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.SymptomsGuna2TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SymptomsGuna2TextBox.Location = new System.Drawing.Point(171, 374);
            this.SymptomsGuna2TextBox.Multiline = true;
            this.SymptomsGuna2TextBox.Name = "SymptomsGuna2TextBox";
            this.SymptomsGuna2TextBox.PlaceholderText = "";
            this.SymptomsGuna2TextBox.SelectedText = "";
            this.SymptomsGuna2TextBox.Size = new System.Drawing.Size(265, 34);
            this.SymptomsGuna2TextBox.TabIndex = 8;
            // 
            // DateGuna2DateTimePicker
            // 
            this.DateGuna2DateTimePicker.Checked = true;
            this.DateGuna2DateTimePicker.FillColor = System.Drawing.Color.White;
            this.DateGuna2DateTimePicker.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DateGuna2DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateGuna2DateTimePicker.Location = new System.Drawing.Point(171, 219);
            this.DateGuna2DateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateGuna2DateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateGuna2DateTimePicker.Name = "DateGuna2DateTimePicker";
            this.DateGuna2DateTimePicker.Size = new System.Drawing.Size(265, 50);
            this.DateGuna2DateTimePicker.TabIndex = 5;
            this.DateGuna2DateTimePicker.Value = new System.DateTime(2026, 5, 16, 22, 30, 10, 791);
            // 
            // SelectDoctorGuna2ComboBox
            // 
            this.SelectDoctorGuna2ComboBox.BackColor = System.Drawing.Color.White;
            this.SelectDoctorGuna2ComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.SelectDoctorGuna2ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SelectDoctorGuna2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectDoctorGuna2ComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.SelectDoctorGuna2ComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.SelectDoctorGuna2ComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SelectDoctorGuna2ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.SelectDoctorGuna2ComboBox.ItemHeight = 30;
            this.SelectDoctorGuna2ComboBox.Location = new System.Drawing.Point(171, 148);
            this.SelectDoctorGuna2ComboBox.Name = "SelectDoctorGuna2ComboBox";
            this.SelectDoctorGuna2ComboBox.Size = new System.Drawing.Size(265, 36);
            this.SelectDoctorGuna2ComboBox.TabIndex = 4;
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.SubtitleLabel.Location = new System.Drawing.Point(144, 50);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(323, 19);
            this.SubtitleLabel.TabIndex = 1;
            this.SubtitleLabel.Text = "Book your Consultation with a Healthcare Specialist";
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.TitleLabel.Location = new System.Drawing.Point(136, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(342, 41);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Schedule Appointment";
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(604, 618);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Appointment";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make Appointment";
            this.Load += new System.EventHandler(this.Appointment_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.Label TitleLabel;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateGuna2DateTimePicker;
        private Guna.UI2.WinForms.Guna2ComboBox SelectDoctorGuna2ComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox TimeGuna2ComboBox;
        private Guna.UI2.WinForms.Guna2TextBox SymptomsGuna2TextBox;
        private System.Windows.Forms.Label SymptomsLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label DoctorLabel;
        private Guna.UI2.WinForms.Guna2Button AppointmentGuna2Button;
    }
}