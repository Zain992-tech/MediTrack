using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Record_Management_System
{
    public partial class Summary : Form
    {
        int LoggedInDoctorID;
        string LoggedInDoctorName;
        public Summary(string DoctorName, int DoctorID)
        {
            InitializeComponent();
            LoggedInDoctorID = DoctorID;
            LoggedInDoctorName = DoctorName;
        }

        private void StyleDataGrid()
        {
            DataGridView.BorderStyle = BorderStyle.None;
            DataGridView.BackgroundColor = Color.White;
            DataGridView.EnableHeadersVisualStyles = false;
            DataGridView.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2563EB");
            DataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold);
            DataGridView.ColumnHeadersHeight = 42;
            DataGridView.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
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

        private void LoadTotalPatients()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PRMS"].ToString()))
            {
                string query = @"
                               SELECT COUNT(*) 
                               FROM Patient
                               WHERE [Doctor ID] = @DoctorID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@DoctorID", LoggedInDoctorID);

                try
                {
                    con.Open();

                    int total = (int)cmd.ExecuteScalar();
                    TotalPLabel.Text = total.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LoadTotalAppointments()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PRMS"].ToString()))
            {
                string query = @"
                               SELECT COUNT(*)
                               FROM Appointments
                               WHERE [Doctor ID] = @DoctorID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@DoctorID", LoggedInDoctorID);

                try
                {
                    con.Open();

                    int total = (int)cmd.ExecuteScalar();
                    TotalALabel.Text = total.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LoadPatients(string order = "ASC")
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PRMS"].ToString()))
            {
                string query = $@"
                               SELECT
                                   [Patient CNIC],
                                   [Patient Name],
                                   [Age],
                                   [Gender],
                                   [Phone],
                                   [Address],
                                   [Diagnosis],
                                   [Prescription],
                                   [Visit Date]
                               FROM Patient
                               WHERE [Doctor ID] = @DoctorID
                               ORDER BY [Patient Name] {order}";

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

        private void LoadCities()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PRMS"].ToString()))
            {
                string query = @"
                               SELECT DISTINCT [Address]
                               FROM Patient
                               WHERE [Doctor ID] = @DoctorID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@DoctorID", LoggedInDoctorID);
                DataTable dt = new DataTable();
                da.Fill(dt);
                FilterGuna2ComboBox.DataSource = dt;
                FilterGuna2ComboBox.DisplayMember = "Address";
                FilterGuna2ComboBox.SelectedIndex = -1;
                FilterGuna2ComboBox.Text = "Select City";
            }
        }

        private void Summary_Load(object sender, EventArgs e)
        {
            StyleDataGrid();
            LoadTotalPatients();
            LoadTotalAppointments();
            LoadCities();
            LoadPatients();
        }

        private void SortGuna2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SortGuna2ComboBox.Text == "A-Z")
            {
                LoadPatients("ASC");
            }
            else
            {
                LoadPatients("DESC");
            }
        }

        private void FilterGuna2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterGuna2ComboBox.SelectedIndex == -1)
            {
                return;
            }

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PRMS"].ToString()))
            {
                string query = @"
                               SELECT
                                   [Patient CNIC],
                                   [Patient Name],
                                   [Age],
                                   [Gender],
                                   [Phone],
                                   [Address],
                                   [Diagnosis],
                                   [Prescription],
                                   [Visit Date]
                               FROM Patient
                               WHERE [Doctor ID] = @DoctorID
                               AND [Address] = @City";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@DoctorID", LoggedInDoctorID);
                da.SelectCommand.Parameters.AddWithValue("@City", FilterGuna2ComboBox.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGridView.DataSource = dt;
            }
        }

        private void BackGuna2Button_Click(object sender, EventArgs e)
        {
            DoctorDashboard db = new DoctorDashboard(LoggedInDoctorName, LoggedInDoctorID);
            db.Show();
            this.Close();
        }

        private void PrintGuna2Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF Files|*.pdf";
            save.Title = "Save Summary Report";
            save.FileName = "DoctorSummary.pdf";

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Document doc = new Document(PageSize.A4.Rotate());
                    PdfWriter.GetInstance(doc, new FileStream(save.FileName, FileMode.Create));

                    doc.Open();

                    iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 22);
                    Paragraph title = new Paragraph("Doctor Summary Report", titleFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    doc.Add(title);
                    doc.Add(new Paragraph("\n"));

                    iTextSharp.text.Font textFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                    doc.Add(new Paragraph("Doctor Name: " + LoggedInDoctorName, textFont));
                    doc.Add(new Paragraph("Total Patients: " + TotalPLabel.Text, textFont));
                    doc.Add(new Paragraph("Total Appointments: " + TotalALabel.Text, textFont));
                    doc.Add(new Paragraph("Generated On: " + DateTime.Now.ToString(), textFont));
                    doc.Add(new Paragraph("\n"));

                    PdfPTable table = new PdfPTable(DataGridView.Columns.Count);
                    table.WidthPercentage = 100;

                    foreach (DataGridViewColumn column in DataGridView.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        table.AddCell(cell);
                    }

                    foreach (DataGridViewRow row in DataGridView.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                table.AddCell(cell.Value?.ToString() ?? "");
                            }
                        }
                    }

                    doc.Add(table);
                    doc.Close();

                    MessageBox.Show("PDF Downloaded Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}