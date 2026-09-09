using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Patient_Record_Management_System
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterGuna2Button_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;

            if (name == "" || email == "" || password == "")
            {
                MessageLabel.Text = "";
                ErrorLabel.Text = "Please fill all fields!";
                return;
            }

            if (!email.Contains('@') || !email.Contains('.'))
            {
                MessageLabel.Text = "";
                ErrorLabel.Text = "Please enter correct email!";
                return;
            }

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PRMS"].ToString()))
            {
                con.Open();

                string checkQuery = "SELECT COUNT(*) FROM Doctor WHERE Email = @Email";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@Email", email);

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageLabel.Text = "";
                    ErrorLabel.Text = "Email already exists!";
                    return;
                }

                string insertQuery = "INSERT INTO Doctor ([Doctor Name], Email, [Password]) VALUES (@Name, @Email, @Password)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, con);

                insertCmd.Parameters.AddWithValue("@Name", name);
                insertCmd.Parameters.AddWithValue("@Email", email);
                insertCmd.Parameters.AddWithValue("@Password", password);

                try
                {
                    insertCmd.ExecuteNonQuery();
                    ErrorLabel.Text = "";
                    MessageLabel.Text = "Registration successful!";

                    NameTextBox.Clear();
                    EmailTextBox.Clear();
                    PasswordTextBox.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void LoginGuna2Button_Click(object sender, EventArgs e)
        {
            DoctorLogin login = new DoctorLogin();
            this.Close();
            login.Show();
        }

        private void CloseLabel_MouseHover(object sender, EventArgs e)
        {
            CloseLabel.ForeColor = Color.Red;

        }

        private void CloseLabel_MouseLeave(object sender, EventArgs e)
        {
            CloseLabel.ForeColor = Color.Gray;

        }
    }
}
