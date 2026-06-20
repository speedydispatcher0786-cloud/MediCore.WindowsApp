using MediCore.App.Core.Models;
using MediCore.App.Services;
using MediCore.WindowsApp.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediCore.WindowsApp.Views
{
    public partial class AppointmentsView : UserControl
    {
        private readonly DBAppointmentService _service;

        public AppointmentsView()
        {
            InitializeComponent();

            // Replace this connection string with your actual one
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=MediCoreDB;Trusted_Connection=True;TrustServerCertificate=True;";

            _service = new DBAppointmentService(connectionString);

            LoadAppointments();

            btnAddappointment.Click += btnAddappointment_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
        }
\\ Load Method
        private void LoadAppointments()
        {
            dgvappointmentsview.Rows.Clear();

            try
            {
                List<Appointment> appointments = _service.GetAllAppointments();

                foreach (Appointment appt in appointments)
                {
                    dgvappointmentsview.Rows.Add(
                        appt.Id,
                        appt.PatientName,
                        appt.DoctorName,
                        appt.AppointmentDate.ToShortDateString(),
                        appt.Time,
                        appt.Status
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointments: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddappointment_Click(object sender, EventArgs e)
        {
            AppointmentForm appointmentForm = new AppointmentForm();

            if (appointmentForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _service.AddAppointment(appointmentForm.ResultAppointment);

                    MessageBox.Show("New Appointment Added Successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadAppointments(); // Refresh the grid
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding appointment: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // FIX: was inverted — should enter the if block when a row IS selected
            if (dgvappointmentsview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment to update.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dgvappointmentsview.SelectedRows[0];

            // Read appointment data from the selected row
            Appointment existing = new Appointment
            {
                Id = Convert.ToInt32(selectedRow.Cells[0].Value),
                PatientName = selectedRow.Cells[1].Value?.ToString(),
                DoctorName = selectedRow.Cells[2].Value?.ToString(),
                AppointmentDate = Convert.ToDateTime(selectedRow.Cells[3].Value),
                Time = selectedRow.Cells[4].Value?.ToString(),
                Status = selectedRow.Cells[5].Value?.ToString()
            };

            AppointmentForm frm = new AppointmentForm(existing); // Pass existing data

            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    frm.ResultAppointment.Id = existing.Id; // Preserve the ID
                    _service.UpdateAppointment(frm.ResultAppointment);

                    MessageBox.Show("Appointment Updated Successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadAppointments();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating appointment: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvappointmentsview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment to delete.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                "Are you sure you want to delete this appointment?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                int id = Convert.ToInt32(dgvappointmentsview.SelectedRows[0].Cells[0].Value);
                _service.DeleteAppointment(id);

                MessageBox.Show("Appointment Deleted Successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAppointments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting appointment: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
