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

namespace Patient_Record_Management_System
{
    public partial class DoctorLogin : Form
    {
        public DoctorLogin()
        {
            InitializeComponent();
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginGuna2Button_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PRMS"].ToString()))
            {
                string email = EmailTextBox.Text;
                string password = PasswordTextBox.Text;

                if (email == "" || password == "")
                {
                    ErrorLabel2.Text = "";
                    ErrorLabel1.Text = "Please fill all fields!";
                    return;
                }

                string query = "SELECT * FROM Doctor WHERE Email = @Email AND Password = @Password";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                cmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text);

                try
                {
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string doctorName = reader["Doctor Name"].ToString();
                        int doctorID = Convert.ToInt32(reader["Doctor ID"]);

                        DoctorDashboard dash = new DoctorDashboard(doctorName, doctorID);
                        dash.Show();
                        this.Close();
                    }
                    else
                    {
                        ErrorLabel1.Text = "";
                        ErrorLabel2.Text = "Invalid Email or Password!";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void RegisterGuna2Button_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Close();
            register.Show();
        }

        private void CloseLabel_MouseHover(object sender, EventArgs e)
        {
            CloseLabel.ForeColor = Color.Red;
        }

        private void CloseLabel_MouseLeave(object sender, EventArgs e)
        {
            CloseLabel.ForeColor = Color.Gray;

        }

        private void BackGuna2Button_Click(object sender, EventArgs e)
        {
            Choice c = new Choice();
            c.Show();
            this.Close();
        }
    }
}
