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
    public partial class Add : Form
    {
        int LoggedInDoctorID;
        string LoggedInDoctorName;

        public Add(string DoctorName, int DoctorID)
        {
            InitializeComponent();
            LoggedInDoctorID = DoctorID;
            LoggedInDoctorName = DoctorName;
        }

        private void BackGuna2Button_Click(object sender, EventArgs e)
        {
            DoctorDashboard db = new DoctorDashboard(LoggedInDoctorName, LoggedInDoctorID);
            db.Show();
            this.Close();
        }

        private void SaveGuna2Button_Click(object sender, EventArgs e)
        {
            if (CNICMaskedTextBox.Text == "" || NameTextBox.Text == "" || AgeNumericUpDown.Text == "" || GenderComboBox.Text == "" || PhoneMaskedTextBox.Text == "" || AddressTextBox.Text == "" || DiagnosisTextBox.Text == "" || PrescriptionTextBox.Text == "")
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PRMS"].ToString()))
            {
                string query = @"INSERT INTO Patient 
                               ([Patient CNIC], [Patient Name], Age, Gender, Phone, Address, Diagnosis, Prescription, [Visit Date], [Doctor ID])
                               VALUES 
                               (@CNIC, @Name, @Age, @Gender, @Phone, @Address, @Diagnosis, @Prescription, @VisitDate, @DoctorID)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@CNIC", CNICMaskedTextBox.Text);
                cmd.Parameters.AddWithValue("@Name", NameTextBox.Text);
                cmd.Parameters.AddWithValue("@Age", AgeNumericUpDown.Text);
                cmd.Parameters.AddWithValue("@Gender", GenderComboBox.Text);
                cmd.Parameters.AddWithValue("@Phone", PhoneMaskedTextBox.Text);
                cmd.Parameters.AddWithValue("@Address", AddressTextBox.Text);
                cmd.Parameters.AddWithValue("@Diagnosis", DiagnosisTextBox.Text);
                cmd.Parameters.AddWithValue("@Prescription", PrescriptionTextBox.Text);
                cmd.Parameters.AddWithValue("@VisitDate", DateTimePicker.Value);
                cmd.Parameters.AddWithValue("@DoctorID", LoggedInDoctorID);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Patient Added Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CNICMaskedTextBox.Clear();
                    NameTextBox.Clear();
                    AgeNumericUpDown.Value = 0;
                    GenderComboBox.SelectedIndex = -1;
                    PhoneMaskedTextBox.Clear();
                    AddressTextBox.Clear();
                    DiagnosisTextBox.Clear();
                    PrescriptionTextBox.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void ClearGuna2Button_Click(object sender, EventArgs e)
        {
            CNICMaskedTextBox.Clear();
            NameTextBox.Clear();
            AgeNumericUpDown.Value = 0;
            GenderComboBox.SelectedIndex = -1;
            PhoneMaskedTextBox.Clear();
            AddressTextBox.Clear();
            DiagnosisTextBox.Clear();
            PrescriptionTextBox.Clear();
        }
    }
}
