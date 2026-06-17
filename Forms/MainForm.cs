using MediCore.WindowsApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediCore.WindowsApp.Forms
{
    public partial class MainForm : Form
    {
        private object _views;

        public MainForm()
        {
            InitializeComponent();
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            this.btnBilling.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.UseVisualStyleBackColor = true;

            // Show Dashboard First
            ShowView(new DashboardView());
        }

        // Method to Show Views
        private void ShowView(UserControl view)
        {
            pnlContainer.Controls.Clear();

            view.Dock = DockStyle.Fill;

            pnlContainer.Controls.Add(view);

            view.BringToFront();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowView(new DashboardView());
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            ShowView(new PatientsView());
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            ShowView(new DoctorView());
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            ShowView(new AppointmentsView());
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            ShowView(new BillingView());

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //LoginForm login = new LoginForm();

            //login.Show();

            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }
    }
}
