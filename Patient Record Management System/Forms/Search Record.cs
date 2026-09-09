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
    public partial class Search : Form
    {
        int LoggedInDoctorID;
        string LoggedInDoctorName;
        public Search(string DoctorName, int DoctorID)
        {
            InitializeComponent();
            LoggedInDoctorID = DoctorID;
            LoggedInDoctorName = DoctorName;
        }

        private void ClearFields()
        {
            NameTextBox.Clear();
            AgeNumericUpDown.Value = 0;
            PhoneMaskedTextBox.Clear();
            AddressTextBox.Clear();
            DiagnosisTextBox.Clear();
            PrescriptionTextBox.Clear();
        }

        private void SearchGuna2Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PRMS"].ToString()))
            {
                string query = "SELECT * FROM Patient WHERE [Patient CNIC] = @cnic";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cnic", SearchMaskedTextBox.Text);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    NameTextBox.Text = dr["Patient Name"].ToString();
                    AgeNumericUpDown.Value = Convert.ToDecimal(dr["Age"]);
                    PhoneMaskedTextBox.Text = dr["Phone"].ToString();
                    AddressTextBox.Text = dr["Address"].ToString();
                    DiagnosisTextBox.Text = dr["Diagnosis"].ToString();
                    PrescriptionTextBox.Text = dr["Prescription"].ToString();
                    DateTimePicker.Value = Convert.ToDateTime(dr["Visit Date"]);
                }
                else
                {
                    MessageBox.Show("No record found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
        }

        private void UpdateGuna2Button_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PRMS"].ToString()))
            {
                string query = @"UPDATE Patient SET
                                   [Patient Name] = @name,
                                   Age = @age,
                                   Phone = @phone,
                                   Address = @address,
                                   Diagnosis = @diagnosis,
                                   Prescription = @prescription,
                                   [Visit Date] = @visitdate
                                WHERE [Patient CNIC] = @SearchCnic";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@name", NameTextBox.Text);
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(AgeNumericUpDown.Value));
                cmd.Parameters.AddWithValue("@phone", PhoneMaskedTextBox.Text);
                cmd.Parameters.AddWithValue("@address", AddressTextBox.Text);
                cmd.Parameters.AddWithValue("@diagnosis", DiagnosisTextBox.Text);
                cmd.Parameters.AddWithValue("@prescription", PrescriptionTextBox.Text);
                cmd.Parameters.AddWithValue("@visitdate", DateTimePicker.Value.Date);
                cmd.Parameters.AddWithValue("@SearchCnic", SearchMaskedTextBox.Text);

                con.Open();
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Record Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Update Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
        }

        private void BackGuna2Button_Click(object sender, EventArgs e)
        {
            DoctorDashboard db = new DoctorDashboard(LoggedInDoctorName, LoggedInDoctorID);
            db.Show();
            this.Close();
        }

        private void DeleteGuna2Button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PRMS"].ToString()))
                {
                    string query = "DELETE FROM Patient WHERE [Patient CNIC] = @cnic";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@cnic", SearchMaskedTextBox.Text);

                    con.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Record Deleted Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Delete Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();
                }
            }
        }
    }
}
