using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Patient_Record_Management_System
{
    public partial class PatientDashboard : Form
    {
        string patientCNIC;
        string patientName;

        public PatientDashboard(string pName, string pCNIC)
        {
            InitializeComponent();
            patientName = pName;
            patientCNIC = pCNIC;
            WelcomeLabel.Text = "Welcome Back, " + patientName;
        }

        private void BackGuna2Button_Click(object sender, EventArgs e)
        {
            PatientLogin p = new PatientLogin();
            this.Close();
            p.Show();
        }

        private void MyRecordsGuna2Panel_MouseHover_1(object sender, EventArgs e)
        {
            Color hover = ColorTranslator.FromHtml("#DBEAFE");
            MyRecordsGuna2Panel.FillColor = hover;
        }

        private void MyRecordsGuna2Panel_MouseLeave_1(object sender, EventArgs e)
        {
            Color normal = Color.White;
            MyRecordsGuna2Panel.FillColor = normal;
        }

        private void MyRecordsGuna2Panel_Click_1(object sender, EventArgs e)
        {
            My my = new My(patientCNIC);
            my.ShowDialog();
        }

        private void AppointmentsGuna2Panel_MouseHover_1(object sender, EventArgs e)
        {
            Color hover = ColorTranslator.FromHtml("#CCFBF1");
            AppointmentsGuna2Panel.FillColor = hover;
        }

        private void AppointmentsGuna2Panel_MouseLeave_1(object sender, EventArgs e)
        {
            Color normal = Color.White;
            AppointmentsGuna2Panel.FillColor = normal;
        }

        private void AppointmentsGuna2Panel_Click_1(object sender, EventArgs e)
        {
            Appointment a = new Appointment(patientCNIC, patientName);
            a.ShowDialog();
        }

        private void ViewGuna2Panel_MouseHover(object sender, EventArgs e)
        {
            Color hover = ColorTranslator.FromHtml("#8BDBEE");
            ViewGuna2Panel.FillColor = hover;
        }

        private void ViewGuna2Panel_MouseLeave(object sender, EventArgs e)
        {
            Color normal = Color.White;
            ViewGuna2Panel.FillColor = normal;
        }

        private void ViewGuna2Panel_Click(object sender, EventArgs e)
        {
            View v = new View(patientCNIC);
            v.ShowDialog();
        }
    }
}
