using MediCore.App.Core.Models;
using System;
using System.Windows.Forms;

namespace MediCore.WindowsApp.Forms
{
    public partial class AppointmentForm : Form
    {
        // This property lets the View read the appointment data back after the form closes
        public Appointment ResultAppointment { get; private set; }

        // Pass an existing appointment to pre-fill fields for editing; null = new appointment
        public AppointmentForm(Appointment existingAppointment = null)
        {
            InitializeComponent();

            tbxID.Text = "AUTO";
            tbxID.ReadOnly = true;
            dtpDate.Value = DateTime.Now;

            if (cbxStatus.Items.Count > 0)
                cbxStatus.SelectedIndex = 0;

            // Pre-fill fields if editing an existing appointment
            if (existingAppointment != null)
            {
                tbxID.Text = existingAppointment.Id.ToString();
                lbPatient.Text = existingAppointment.PatientName;
                cmbDoctor.Text = existingAppointment.DoctorName;
                dtpDate.Value = existingAppointment.AppointmentDate;
                cbxTime.Text = existingAppointment.Time;
                cbxStatus.Text = existingAppointment.Status;
            }

            btnBook.Click += btnBook_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lbPatient.Text))
            {
                MessageBox.Show("Please enter patient name.");
                return;
            }

            if (cmbDoctor.SelectedIndex == -1 && string.IsNullOrWhiteSpace(cmbDoctor.Text))
            {
                MessageBox.Show("Please select a doctor.");
                return;
            }

            if (cbxTime.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a time.");
                return;
            }

            if (cbxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a status.");
                return;
            }

            // Build the appointment object from form fields
            ResultAppointment = new Appointment
            {
                PatientName = lbPatient.Text.Trim(),
                DoctorName = cmbDoctor.Text.Trim(),
                AppointmentDate = dtpDate.Value.Date,
                Time = cbxTime.Text,
                Status = cbxStatus.Text
            };

            // Set the ID only if we're editing (not AUTO)
            if (tbxID.Text != "AUTO" && int.TryParse(tbxID.Text, out int existingId))
                ResultAppointment.Id = existingId;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
