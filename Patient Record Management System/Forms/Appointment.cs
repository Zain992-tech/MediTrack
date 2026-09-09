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
    public partial class Appointment : Form
    {
        string patientCNIC;
        string patientName;
        public Appointment(string pCNIC, string pName)
        {
            InitializeComponent();
            patientName = pName;
            patientCNIC = pCNIC;
        }

        private void LoadDoctors()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PRMS"].ToString()))
            {
                string query = "SELECT [Doctor ID], [Doctor Name] FROM Doctor";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                SelectDoctorGuna2ComboBox.DataSource = dt;
                SelectDoctorGuna2ComboBox.DisplayMember = "Doctor Name";
                SelectDoctorGuna2ComboBox.ValueMember = "Doctor ID";
            }
        }

        private void AppointmentGuna2Button_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PRMS"].ToString()))
            {
                if (
                    SelectDoctorGuna2ComboBox.Text == "" ||
                    TimeGuna2ComboBox.Text == "")
                {
                    MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = @"
                               INSERT INTO Appointments
                               ([Patient CNIC], [Patient Name], [Doctor ID], [Doctor Name], [Appointment Date], [Appointment Time], [Symptoms])
                               VALUES
                               (@CNIC, @PName, @DID, @DName, @Date, @Time, @Symptoms)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@CNIC", patientCNIC);
                cmd.Parameters.AddWithValue("@PName", patientName);
                cmd.Parameters.AddWithValue("@DID", SelectDoctorGuna2ComboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@DName", SelectDoctorGuna2ComboBox.Text);
                cmd.Parameters.AddWithValue("@Date", DateGuna2DateTimePicker.Value.Date);
                cmd.Parameters.AddWithValue("@Time", TimeGuna2ComboBox.Text);
                cmd.Parameters.AddWithValue("@Symptoms", SymptomsGuna2TextBox.Text);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Appointment Booked Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SymptomsGuna2TextBox.Clear();
                    SelectDoctorGuna2ComboBox.SelectedIndex = -1;
                    TimeGuna2ComboBox.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            LoadDoctors();

            TimeGuna2ComboBox.Items.Add("09:00 AM");
            TimeGuna2ComboBox.Items.Add("10:00 AM");
            TimeGuna2ComboBox.Items.Add("11:00 AM");
            TimeGuna2ComboBox.Items.Add("12:00 PM");
            TimeGuna2ComboBox.Items.Add("01:00 PM");
            TimeGuna2ComboBox.Items.Add("02:00 PM");
            TimeGuna2ComboBox.Items.Add("03:00 PM");
            TimeGuna2ComboBox.Items.Add("04:00 PM");
        }
    }
}