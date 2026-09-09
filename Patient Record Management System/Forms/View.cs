using Guna.UI2.WinForms;
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
    public partial class View : Form
    {
        string patientCNIC;

        public View(string pCNIC)
        {
            InitializeComponent();
            patientCNIC = pCNIC;
        }

        private void GridLoad()
        {
            Guna2DataGridView.BorderStyle = BorderStyle.None;
            Guna2DataGridView.BackgroundColor = Color.White;
            Guna2DataGridView.EnableHeadersVisualStyles = false;
            Guna2DataGridView.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2563EB");
            Guna2DataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Guna2DataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            Guna2DataGridView.ColumnHeadersHeight = 42;
            Guna2DataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            Guna2DataGridView.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#111827");
            Guna2DataGridView.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#DBEAFE");
            Guna2DataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
            Guna2DataGridView.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F9FAFB");
            Guna2DataGridView.GridColor = ColorTranslator.FromHtml("#E5E7EB");
            Guna2DataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Guna2DataGridView.RowHeadersVisible = false;
            Guna2DataGridView.RowTemplate.Height = 36;
            Guna2DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Guna2DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Guna2DataGridView.MultiSelect = false;
            Guna2DataGridView.AllowUserToAddRows = false;
            Guna2DataGridView.AllowUserToResizeRows = false;
        }

        private void LoadAppointments(string patientCNIC)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PRMS"].ToString()))
            {
                string query = @"SELECT 
                                     [Doctor Name],
                                     [Appointment Date],
                                     [Appointment Time],
                                     [Symptoms],
                                     [Created At]
                                FROM Appointments
                                WHERE [Patient CNIC] = @PatientCNIC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                da.SelectCommand.Parameters.AddWithValue(
                    "@PatientCNIC",
                    patientCNIC);

                DataTable dt = new DataTable();

                da.Fill(dt);

                Guna2DataGridView.DataSource = dt;
            }
        }

        private void View_Load(object sender, EventArgs e)
        {
            GridLoad();
            LoadAppointments(patientCNIC);
        }
    }
}
