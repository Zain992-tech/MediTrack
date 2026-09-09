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
    public partial class Appointments : Form
    {
        int LoggedInDoctorID;
        string LoggedInDoctorName;
        public Appointments(string DoctorName, int DoctorID)
        {
            InitializeComponent();
            DataGridView.AutoGenerateColumns = false;
            LoggedInDoctorID = DoctorID;
            LoggedInDoctorName = DoctorName;
        }

        public void GridData()
        {
            DataGridView.BorderStyle = BorderStyle.None;
            DataGridView.BackgroundColor = Color.White;
            DataGridView.EnableHeadersVisualStyles = false;
            DataGridView.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2563EB");
            DataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            DataGridView.ColumnHeadersHeight = 42;
            DataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            DataGridView.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#111827");
            DataGridView.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#DBEAFE");
            DataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
            DataGridView.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F9FAFB");
            DataGridView.GridColor = ColorTranslator.FromHtml("#E5E7EB");
            DataGridView.RowHeadersVisible = false;
            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView.RowTemplate.Height = 36;
            DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach (DataGridViewColumn column in DataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void LoadAppointments()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PRMS"].ToString()))
            {
                string query = @"
                               SELECT
                                   [Patient CNIC],
                                   [Patient Name],
                                   [Appointment Date],
                                   [Appointment Time],
                                   [Symptoms],
                                   [Created AT]    

                               FROM Appointments

                               WHERE [Doctor ID] = @DoctorID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                da.SelectCommand.Parameters.AddWithValue("@DoctorID", LoggedInDoctorID);

                DataTable dt = new DataTable();

                try
                {
                    da.Fill(dt);

                    DataGridView.DataSource = dt;

                    DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            GridData();
            LoadAppointments();
        }

        private void BackGuna2Button_Click(object sender, EventArgs e)
        {
            DoctorDashboard db = new DoctorDashboard(LoggedInDoctorName, LoggedInDoctorID);
            db.Show();
            this.Close();
        }

        private void CheckGuna2Button_Click(object sender, EventArgs e)
        {
            if (DataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select an Appointment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string patientCNIC = DataGridView.SelectedRows[0].Cells["PatientCNIC"].Value.ToString();
            DateTime createdDate = Convert.ToDateTime(DataGridView.SelectedRows[0].Cells["CreatedAt"].Value);

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PRMS"].ToString()))
            {
                string query = @"
                               DELETE FROM Appointments
                               WHERE [Patient CNIC] = @CNIC AND [Created At] = @CreatedDate";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CNIC", patientCNIC);
                cmd.Parameters.AddWithValue("@CreatedDate", createdDate);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Checked Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAppointments();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
