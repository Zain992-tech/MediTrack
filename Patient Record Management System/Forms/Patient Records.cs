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
    public partial class Records : Form
    {
        int LoggedInDoctorID;
        string LoggedInDoctorName;
        public Records(string DoctorName,int DoctorID)
        {
            InitializeComponent();
            DataGridView.AutoGenerateColumns = false;
            LoggedInDoctorID = DoctorID;
            LoggedInDoctorName = DoctorName;
        }

        private void LoadPatients()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PRMS"].ToString()))
            {
                string query = "SELECT * FROM Patient WHERE [Doctor ID] = @DoctorID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@DoctorID", LoggedInDoctorID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataGridView.DataSource = dt;
            }
        }

        private void StyleDataGrid()
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

        private void Patient_Records_Load(object sender, EventArgs e)
        {
            StyleDataGrid();
            LoadPatients();
        }

        private void BackGuna2Button_Click(object sender, EventArgs e)
        {
            DoctorDashboard db = new DoctorDashboard(LoggedInDoctorName, LoggedInDoctorID);
            db.Show();
            this.Close();
        }
    }
}
