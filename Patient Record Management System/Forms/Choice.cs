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
    public partial class Choice : Form
    {
        public Choice()
        {
            InitializeComponent();
        }

        string selectedRole = "";

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseLabel_MouseHover(object sender, EventArgs e)
        {
            CloseLabel.ForeColor = Color.Red;
        }

        private void ContinueGuna2Button_Click(object sender, EventArgs e)
        {
            if (selectedRole == "")
            {
                MessageBox.Show("Please Select a Role First.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedRole == "Patient")
            {
                PatientLogin p = new PatientLogin();
                p.Show();
                this.Hide();
            }
            else if (selectedRole == "Doctor")
            {
                DoctorLogin d = new DoctorLogin();
                d.Show();
                this.Hide();
            }
        }

        private void DoctorPanel_Click(object sender, EventArgs e)
        {
            selectedRole = "Doctor";

            DoctorPanel.BackColor = Color.LightBlue;
            PatientPanel.BackColor = SystemColors.Control;
        }

        private void PatientPanel_Click(object sender, EventArgs e)
        {
            selectedRole = "Patient";

            PatientPanel.BackColor = Color.LightGreen;
            DoctorPanel.BackColor = SystemColors.Control;
        }

        private void Choice_Load(object sender, EventArgs e)
        {
            PatientPanel.Click += PatientPanel_Click;
            DoctorPanel.Click += DoctorPanel_Click;

            PatientLabel.Click += PatientPanel_Click;
            DoctorLabel.Click += DoctorPanel_Click;
        }

        private void CloseLabel_MouseLeave(object sender, EventArgs e)
        {
            CloseLabel.ForeColor = Color.Gray;

        }
    }
}
