using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediCore.WindowsApp.Views
{
    public partial class DashboardView : UserControl
    {
        public DashboardView()
        {
            InitializeComponent();
            LoadDashboardData();
            DesignPanels();
        }

        private void lbDashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dashboard Opened");

        }
        private void LoadDashboardData()
        {
            // Dashboard Statistics
            lbpatient.Text = "247";
            lbdoctor.Text = "12";
            lbappointment.Text = "30";
            lbrevenues.Text = "30000";

            // Appointment Details
            lbKaleem.Text = "Kaleem";
            lbk.Text = "9 AM";
            lbkcomplete.Text = "Completed";

            lbAqib.Text = "Aqib";
            lbA.Text = "10:30 AM";
            lbAC.Text = "Booked";

            lbTooba.Text = "Tooba";
            lbT.Text = "12 PM";
            lbTcancel.Text = "Canceled";
        }

        private void DesignPanels()
        {
            pnlPatients.BackColor = Color.LightSkyBlue;
            pnlDoctors.BackColor = Color.LightGreen;
            pnlAppointments.BackColor = Color.LightSalmon;
            pnlRevenue.BackColor = Color.Khaki;
            pnlTodayappointments.BackColor = Color.White;

            pnlTodayappointments.BorderStyle = BorderStyle.FixedSingle;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lbrevenues_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
