using MediCore.App.Core.Models;
using MediCore.App.Services;
using MediCore.WindowsApp.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MediCore.WindowsApp.Views
{
    public partial class PatientsView : UserControl
    {
        //private DBPatientService patientService = new DBPatientService();
        private DBPatientService patientService;

        public PatientsView()
        {
            InitializeComponent();

            string connectionString =
                "Server=(localdb)\\MSSQLLocalDB;Database=MediCoreDB;Trusted_Connection=True;TrustServerCertificate=True;";

            patientService =
                new DBPatientService(connectionString);

            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            LoadPatients();
        }
        // LOAD PATIENTS IN GRID
        private void LoadPatients()
        {
            dgvPatientdetails.Rows.Clear();

            var patients = patientService.GetAllPatients();

            foreach (var patient in patients)
            {
                dgvPatientdetails.Rows.Add(
                    patient.Id,
                    patient.Name,
                    patient.Age,
                    patient.Gender,
                    patient.Contact,
                    patient.BloodGroup
                );
            }
        }

        // ADD BUTTON
        private void btnAdd_Click(object sender, EventArgs e)
        {
            PatientForm patient = new PatientForm();

            patient.ShowDialog();

            LoadPatients();
        }

        // EDIT BUTTON
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPatientdetails.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select Patient");
                return;
            }

            DataGridViewRow row = dgvPatientdetails.SelectedRows[0];

            PatientForm form = new PatientForm();

            form.SetUpdateData(
                Convert.ToInt32(row.Cells[0].Value),
                row.Cells[1].Value.ToString(),
                Convert.ToInt32(row.Cells[2].Value),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString(),
                row.Cells[5].Value.ToString()
            );

            form.ShowDialog();

            LoadPatients();
        }

        // DELETE BUTTON
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPatientdetails.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select Patient");
                return;
            }

            int id = Convert.ToInt32(
                dgvPatientdetails.SelectedRows[0].Cells[0].Value
            );

            patientService.DeletePatient(id);

            LoadPatients();

            MessageBox.Show("Patient Deleted Successfully");
        }

        
        
    }
}
