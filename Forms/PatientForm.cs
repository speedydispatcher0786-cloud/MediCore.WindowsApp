using MediCore.App.Core.Models;
using MediCore.App.Services;
using System;
using System.Windows.Forms;
namespace MediCore.WindowsApp.Forms
{
    public partial class PatientForm : Form
    {
        private DBPatientService patientService;

        private bool isUpdate = false;
        private int editingId = 0;

        public PatientForm()
        {
            InitializeComponent();

            string connectionString =
                "Server=(localdb)\\MSSQLLocalDB;Database=MediCoreDB;Trusted_Connection=True;TrustServerCertificate=True;";

            patientService =
                new DBPatientService(connectionString);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbxName.Text == "")
            {
                MessageBox.Show("Please Enter Patient Name");
                tbxName.Focus();
                return;
            }

            if (tbxAge.Text == "")
            {
                MessageBox.Show("Please Enter Age");
                tbxAge.Focus();
                return;
            }

            if (cbxGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Gender");
                return;
            }

            if (tbxContact.Text == "")
            {
                MessageBox.Show("Please Enter Contact");
                return;
            }

            if (cbxBloodgroup.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Blood Group");
                return;
            }

            Patient patient = new Patient();

            // Only set Id during update
            if (isUpdate)
            {
                patient.Id = editingId;
            }

            patient.Name = tbxName.Text;
            patient.Age = Convert.ToInt32(tbxAge.Text);
            patient.Gender = cbxGender.Text;
            patient.Contact = tbxContact.Text;
            patient.BloodGroup = cbxBloodgroup.Text;

            if (isUpdate)
            {
                patientService.UpdatePatient(patient);

                MessageBox.Show("Patient Updated Successfully");
            }
            else
            {
                patientService.AddPatient(patient);

                MessageBox.Show("Patient Saved Successfully");
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            tbxID.Clear();
            tbxName.Clear();
            tbxAge.Clear();
            tbxContact.Clear();

            cbxGender.SelectedIndex = -1;
            cbxBloodgroup.SelectedIndex = -1;

            tbxName.Focus();
        }

        public void SetUpdateData(
            int id,
            string name,
            int age,
            string gender,
            string contact,
            string blood
        )
        {
            isUpdate = true;

            editingId = id;

            tbxID.Text = id.ToString();
            tbxName.Text = name;
            tbxAge.Text = age.ToString();
            cbxGender.Text = gender;
            tbxContact.Text = contact;
            cbxBloodgroup.Text = blood;
        }
    }
}