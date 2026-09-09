using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Record_Management_System
{
    public partial class DoctorDashboard : Form
    {
        int doctorId;
        string doctorName;
        public DoctorDashboard(string dName, int dID)
        {
            InitializeComponent();
            doctorId = dID;
            doctorName = dName;
            DoctorNameLabel.Text = "Welcome back, Dr. " + dName;
        }

        private void PatientRecordGuna2CustomGradientPanel_MouseHover(object sender, EventArgs e)
        {
            Color hover = ColorTranslator.FromHtml("#DBEAFE");

            PatientRecordGuna2CustomGradientPanel.FillColor = hover;
            PatientRecordGuna2CustomGradientPanel.FillColor2 = hover;
            PatientRecordGuna2CustomGradientPanel.FillColor3 = hover;
            PatientRecordGuna2CustomGradientPanel.FillColor4 = hover;
        }

        private void PatientRecordGuna2CustomGradientPanel_MouseLeave(object sender, EventArgs e)
        {
            Color normal = Color.White;

            PatientRecordGuna2CustomGradientPanel.FillColor = normal;
            PatientRecordGuna2CustomGradientPanel.FillColor2 = normal;
            PatientRecordGuna2CustomGradientPanel.FillColor3 = normal;
            PatientRecordGuna2CustomGradientPanel.FillColor4 = normal;
        }

        private void AddRecordGuna2CustomGradientPanel_MouseHover(object sender, EventArgs e)
        {
            Color hover = ColorTranslator.FromHtml("#DCFCE7");

            AddRecordGuna2CustomGradientPanel.FillColor = hover;
            AddRecordGuna2CustomGradientPanel.FillColor2 = hover;
            AddRecordGuna2CustomGradientPanel.FillColor3 = hover;
            AddRecordGuna2CustomGradientPanel.FillColor4 = hover;
        }

        private void AddRecordGuna2CustomGradientPanel_MouseLeave(object sender, EventArgs e)
        {
            Color normal = Color.White;

            AddRecordGuna2CustomGradientPanel.FillColor = normal;
            AddRecordGuna2CustomGradientPanel.FillColor2 = normal;
            AddRecordGuna2CustomGradientPanel.FillColor3 = normal;
            AddRecordGuna2CustomGradientPanel.FillColor4 = normal;
        }

        private void SearchRecordGuna2CustomGradientPanel_MouseHover(object sender, EventArgs e)
        {
            Color hover = ColorTranslator.FromHtml("#CFFAFE");

            SearchRecordGuna2CustomGradientPanel.FillColor = hover;
            SearchRecordGuna2CustomGradientPanel.FillColor2 = hover;
            SearchRecordGuna2CustomGradientPanel.FillColor3 = hover;
            SearchRecordGuna2CustomGradientPanel.FillColor4 = hover;
        }

        private void SearchRecordGuna2CustomGradientPanel_MouseLeave(object sender, EventArgs e)
        {
            Color normal = Color.White;

            SearchRecordGuna2CustomGradientPanel.FillColor = normal;
            SearchRecordGuna2CustomGradientPanel.FillColor2 = normal;
            SearchRecordGuna2CustomGradientPanel.FillColor3 = normal;
            SearchRecordGuna2CustomGradientPanel.FillColor4 = normal;
        }

        private void AppointmentsGuna2CustomGradientPanel_MouseHover(object sender, EventArgs e)
        {
            Color hover = ColorTranslator.FromHtml("#E0E7FF");

            AppointmentsGuna2CustomGradientPanel.FillColor = hover;
            AppointmentsGuna2CustomGradientPanel.FillColor2 = hover;
            AppointmentsGuna2CustomGradientPanel.FillColor3 = hover;
            AppointmentsGuna2CustomGradientPanel.FillColor4 = hover;
        }

        private void AppointmentsGuna2CustomGradientPanel_MouseLeave(object sender, EventArgs e)
        {
            Color normal = Color.White;

            AppointmentsGuna2CustomGradientPanel.FillColor = normal;
            AppointmentsGuna2CustomGradientPanel.FillColor2 = normal;
            AppointmentsGuna2CustomGradientPanel.FillColor3 = normal;
            AppointmentsGuna2CustomGradientPanel.FillColor4 = normal;
        }

        private void SummaryGuna2CustomGradientPanel_MouseHover(object sender, EventArgs e)
        {
            Color hover = ColorTranslator.FromHtml("#CCFBF1");

            SummaryGuna2CustomGradientPanel.FillColor = hover;
            SummaryGuna2CustomGradientPanel.FillColor2 = hover;
            SummaryGuna2CustomGradientPanel.FillColor3 = hover;
            SummaryGuna2CustomGradientPanel.FillColor4 = hover;
        }

        private void SummaryGuna2CustomGradientPanel_MouseLeave(object sender, EventArgs e)
        {
            Color normal = Color.White;

            SummaryGuna2CustomGradientPanel.FillColor = normal;
            SummaryGuna2CustomGradientPanel.FillColor2 = normal;
            SummaryGuna2CustomGradientPanel.FillColor3 = normal;
            SummaryGuna2CustomGradientPanel.FillColor4 = normal;
        }

        private void LogoutGuna2CustomGradientPanel_MouseHover(object sender, EventArgs e)
        {
            Color hover = ColorTranslator.FromHtml("#FEE2E2");

            LogoutGuna2CustomGradientPanel.FillColor = hover;
            LogoutGuna2CustomGradientPanel.FillColor2 = hover;
            LogoutGuna2CustomGradientPanel.FillColor3 = hover;
            LogoutGuna2CustomGradientPanel.FillColor4 = hover;
        }

        private void LogoutGuna2CustomGradientPanel_MouseLeave(object sender, EventArgs e)
        {
            Color normal = Color.White;

            LogoutGuna2CustomGradientPanel.FillColor = normal;
            LogoutGuna2CustomGradientPanel.FillColor2 = normal;
            LogoutGuna2CustomGradientPanel.FillColor3 = normal;
            LogoutGuna2CustomGradientPanel.FillColor4 = normal;
        }

        private void PatientRecordGuna2CustomGradientPanel_Click(object sender, EventArgs e)
        {
            Records pr = new Records(doctorName, doctorId);
            this.Hide();
            pr.Show();
        }

        private void AddRecordGuna2CustomGradientPanel_Click(object sender, EventArgs e)
        {
            Add add = new Add(doctorName, doctorId);
            this.Hide();
            add.Show();
        }

        private void SearchRecordGuna2CustomGradientPanel_Click(object sender, EventArgs e)
        {
            Search search = new Search(doctorName, doctorId);
            this.Hide();
            search.Show();
        }

        private void LogoutGuna2CustomGradientPanel_Click(object sender, EventArgs e)
        {
            DoctorLogin login = new DoctorLogin();
            this.Close();
            login.Show();
        }

        private void AppointmentsGuna2CustomGradientPanel_Click(object sender, EventArgs e)
        {
            Appointments appointment = new Appointments(doctorName, doctorId);
            this.Close();
            appointment.Show();
        }

        private void SummaryGuna2CustomGradientPanel_Click(object sender, EventArgs e)
        {
            Summary summary = new Summary(doctorName, doctorId);
            this.Close();
            summary.Show();
        }
    }
}
