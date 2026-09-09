namespace Patient_Record_Management_System
{
    partial class DoctorLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorLogin));
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.ErrorLabel1 = new System.Windows.Forms.Label();
            this.ErrorLabel2 = new System.Windows.Forms.Label();
            this.HomePictureBox = new System.Windows.Forms.PictureBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginGuna2Button = new Guna.UI2.WinForms.Guna2Button();
            this.RegisterGuna2Button = new Guna.UI2.WinForms.Guna2Button();
            this.BackGuna2Button = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.HomePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.EmailLabel.Location = new System.Drawing.Point(72, 210);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(45, 19);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "Email";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(76, 232);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(274, 20);
            this.EmailTextBox.TabIndex = 3;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.PasswordTextBox.Location = new System.Drawing.Point(76, 315);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(274, 20);
            this.PasswordTextBox.TabIndex = 5;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.PasswordLabel.Location = new System.Drawing.Point(72, 293);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(73, 19);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password";
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLabel.ForeColor = System.Drawing.Color.Gray;
            this.CloseLabel.Location = new System.Drawing.Point(399, 9);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(27, 26);
            this.CloseLabel.TabIndex = 6;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            this.CloseLabel.MouseLeave += new System.EventHandler(this.CloseLabel_MouseLeave);
            this.CloseLabel.MouseHover += new System.EventHandler(this.CloseLabel_MouseHover);
            // 
            // ErrorLabel1
            // 
            this.ErrorLabel1.AutoSize = true;
            this.ErrorLabel1.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel1.Location = new System.Drawing.Point(165, 363);
            this.ErrorLabel1.Name = "ErrorLabel1";
            this.ErrorLabel1.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel1.TabIndex = 9;
            // 
            // ErrorLabel2
            // 
            this.ErrorLabel2.AutoSize = true;
            this.ErrorLabel2.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel2.Location = new System.Drawing.Point(149, 364);
            this.ErrorLabel2.Name = "ErrorLabel2";
            this.ErrorLabel2.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel2.TabIndex = 10;
            // 
            // HomePictureBox
            // 
            this.HomePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("HomePictureBox.Image")));
            this.HomePictureBox.Location = new System.Drawing.Point(161, 12);
            this.HomePictureBox.Name = "HomePictureBox";
            this.HomePictureBox.Size = new System.Drawing.Size(102, 105);
            this.HomePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomePictureBox.TabIndex = 0;
            this.HomePictureBox.TabStop = false;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.LoginLabel.Location = new System.Drawing.Point(136, 130);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(150, 20);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Doctor Secure Login";
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
            this.LoginGuna2Button.Location = new System.Drawing.Point(161, 404);
            this.LoginGuna2Button.Name = "LoginGuna2Button";
            this.LoginGuna2Button.Size = new System.Drawing.Size(102, 40);
            this.LoginGuna2Button.TabIndex = 12;
            this.LoginGuna2Button.Text = "Login";
            this.LoginGuna2Button.Click += new System.EventHandler(this.LoginGuna2Button_Click);
            // 
            // RegisterGuna2Button
            // 
            this.RegisterGuna2Button.AutoRoundedCorners = true;
            this.RegisterGuna2Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.RegisterGuna2Button.BorderThickness = 1;
            this.RegisterGuna2Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterGuna2Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RegisterGuna2Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RegisterGuna2Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RegisterGuna2Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RegisterGuna2Button.FillColor = System.Drawing.Color.White;
            this.RegisterGuna2Button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.RegisterGuna2Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.RegisterGuna2Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.RegisterGuna2Button.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.RegisterGuna2Button.Location = new System.Drawing.Point(248, 475);
            this.RegisterGuna2Button.Name = "RegisterGuna2Button";
            this.RegisterGuna2Button.Size = new System.Drawing.Size(102, 40);
            this.RegisterGuna2Button.TabIndex = 13;
            this.RegisterGuna2Button.Text = "Register";
            this.RegisterGuna2Button.Click += new System.EventHandler(this.RegisterGuna2Button_Click);
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
            this.BackGuna2Button.Location = new System.Drawing.Point(76, 475);
            this.BackGuna2Button.Name = "BackGuna2Button";
            this.BackGuna2Button.Size = new System.Drawing.Size(102, 40);
            this.BackGuna2Button.TabIndex = 14;
            this.BackGuna2Button.Text = "Back";
            this.BackGuna2Button.Click += new System.EventHandler(this.BackGuna2Button_Click);
            // 
            // DoctorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(438, 577);
            this.Controls.Add(this.BackGuna2Button);
            this.Controls.Add(this.RegisterGuna2Button);
            this.Controls.Add(this.LoginGuna2Button);
            this.Controls.Add(this.ErrorLabel2);
            this.Controls.Add(this.ErrorLabel1);
            this.Controls.Add(this.CloseLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.HomePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoctorLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor Login";
            ((System.ComponentModel.ISupportInitialize)(this.HomePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Label ErrorLabel1;
        private System.Windows.Forms.Label ErrorLabel2;
        private System.Windows.Forms.PictureBox HomePictureBox;
        private System.Windows.Forms.Label LoginLabel;
        private Guna.UI2.WinForms.Guna2Button LoginGuna2Button;
        private Guna.UI2.WinForms.Guna2Button RegisterGuna2Button;
        private Guna.UI2.WinForms.Guna2Button BackGuna2Button;
    }
}