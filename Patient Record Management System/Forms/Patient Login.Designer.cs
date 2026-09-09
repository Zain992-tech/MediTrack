namespace Patient_Record_Management_System
{
    partial class PatientLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientLogin));
            this.CloseLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.HomePictureBox = new System.Windows.Forms.PictureBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LoginGuna2Button = new Guna.UI2.WinForms.Guna2Button();
            this.BackGuna2Button = new Guna.UI2.WinForms.Guna2Button();
            this.ErrorLabel1 = new System.Windows.Forms.Label();
            this.ErrorLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HomePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLabel.ForeColor = System.Drawing.Color.Gray;
            this.CloseLabel.Location = new System.Drawing.Point(402, 9);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(27, 26);
            this.CloseLabel.TabIndex = 9;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            this.CloseLabel.MouseLeave += new System.EventHandler(this.CloseLabel_MouseLeave);
            this.CloseLabel.MouseHover += new System.EventHandler(this.CloseLabel_MouseHover);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.LoginLabel.Location = new System.Drawing.Point(139, 130);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(152, 20);
            this.LoginLabel.TabIndex = 8;
            this.LoginLabel.Text = "Patient Secure Login";
            // 
            // HomePictureBox
            // 
            this.HomePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("HomePictureBox.Image")));
            this.HomePictureBox.Location = new System.Drawing.Point(164, 12);
            this.HomePictureBox.Name = "HomePictureBox";
            this.HomePictureBox.Size = new System.Drawing.Size(102, 105);
            this.HomePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomePictureBox.TabIndex = 7;
            this.HomePictureBox.TabStop = false;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.PasswordTextBox.Location = new System.Drawing.Point(84, 331);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(274, 20);
            this.PasswordTextBox.TabIndex = 13;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.PasswordLabel.Location = new System.Drawing.Point(80, 309);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(73, 19);
            this.PasswordLabel.TabIndex = 12;
            this.PasswordLabel.Text = "Password";
            // 
            // NameTextBox
            // 
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(84, 248);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(274, 20);
            this.NameTextBox.TabIndex = 11;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.NameLabel.Location = new System.Drawing.Point(80, 226);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 19);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "Name";
            // 
            // LoginGuna2Button
            // 
            this.LoginGuna2Button.AutoRoundedCorners = true;
            this.LoginGuna2Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginGuna2Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginGuna2Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginGuna2Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginGuna2Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginGuna2Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.LoginGuna2Button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LoginGuna2Button.ForeColor = System.Drawing.Color.White;
            this.LoginGuna2Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.LoginGuna2Button.Location = new System.Drawing.Point(256, 451);
            this.LoginGuna2Button.Name = "LoginGuna2Button";
            this.LoginGuna2Button.Size = new System.Drawing.Size(102, 40);
            this.LoginGuna2Button.TabIndex = 14;
            this.LoginGuna2Button.Text = "Login";
            this.LoginGuna2Button.Click += new System.EventHandler(this.LoginGuna2Button_Click);
            // 
            // BackGuna2Button
            // 
            this.BackGuna2Button.AutoRoundedCorners = true;
            this.BackGuna2Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.BackGuna2Button.BorderThickness = 1;
            this.BackGuna2Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackGuna2Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackGuna2Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackGuna2Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackGuna2Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackGuna2Button.FillColor = System.Drawing.Color.White;
            this.BackGuna2Button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.BackGuna2Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.BackGuna2Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.BackGuna2Button.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.BackGuna2Button.Location = new System.Drawing.Point(84, 451);
            this.BackGuna2Button.Name = "BackGuna2Button";
            this.BackGuna2Button.Size = new System.Drawing.Size(102, 40);
            this.BackGuna2Button.TabIndex = 15;
            this.BackGuna2Button.Text = "Back";
            this.BackGuna2Button.Click += new System.EventHandler(this.BackGuna2Button_Click);
            // 
            // ErrorLabel1
            // 
            this.ErrorLabel1.AutoSize = true;
            this.ErrorLabel1.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel1.Location = new System.Drawing.Point(170, 396);
            this.ErrorLabel1.Name = "ErrorLabel1";
            this.ErrorLabel1.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel1.TabIndex = 16;
            // 
            // ErrorLabel2
            // 
            this.ErrorLabel2.AutoSize = true;
            this.ErrorLabel2.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel2.Location = new System.Drawing.Point(161, 396);
            this.ErrorLabel2.Name = "ErrorLabel2";
            this.ErrorLabel2.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel2.TabIndex = 17;
            // 
            // PatientLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(438, 577);
            this.Controls.Add(this.ErrorLabel2);
            this.Controls.Add(this.ErrorLabel1);
            this.Controls.Add(this.BackGuna2Button);
            this.Controls.Add(this.LoginGuna2Button);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CloseLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.HomePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Login";
            ((System.ComponentModel.ISupportInitialize)(this.HomePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.PictureBox HomePictureBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private Guna.UI2.WinForms.Guna2Button LoginGuna2Button;
        private Guna.UI2.WinForms.Guna2Button BackGuna2Button;
        private System.Windows.Forms.Label ErrorLabel1;
        private System.Windows.Forms.Label ErrorLabel2;
    }
}