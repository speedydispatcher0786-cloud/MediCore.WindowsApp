using MediCore.App.Core.Models;
using MediCore.App.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MediCore.WindowsApp.Forms
{
    public partial class DoctorForm : Form
    {
        //private static DBDoctorService doctorService = new DBDoctorService();
        private DBDoctorService doctorService;

        private bool isUpdate = false;
        private int editingId = 0;

        public DoctorForm()
        {
            InitializeComponent();

            string connectionString =
                "Server=(localdb)\\MSSQLLocalDB;Database=MediCoreDB;Trusted_Connection=True;TrustServerCertificate=True;";

            doctorService =
                new DBDoctorService(connectionString);
        }

        private int GenerateId()
        {
            var list = doctorService.GetAllDoctors();
             
            if (list.Count == 0)
                return 1001;

            return list.Max(x => x.Id) + 1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetUpdateData(int id, string name, string spec, string contact, string days)
        {
            isUpdate = true;
            editingId = id;

            tbxID.Text = id.ToString();
            txbName.Text = name;
            cbxSpecailization.Text = spec;
            tbxContact.Text = contact;
            tbxAvailabledays.Text = days;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
  
            if (txbName.Text == "" ||
        cbxSpecailization.SelectedIndex == -1 ||
        tbxContact.Text == "" ||
        tbxAvailabledays.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            Doctor doctor = new Doctor
            {
                Id = isUpdate ? editingId : GenerateId(),   // 🔥 IMPORTANT FIX
                Name = txbName.Text,
                Specialization = cbxSpecailization.Text,
                Contact = tbxContact.Text,
                AvailableDays = tbxAvailabledays.Text
            };

            if (isUpdate)
            {
                doctorService.UpdateDoctor(doctor);  // 🔥 UPDATE
                MessageBox.Show("Doctor Updated Successfully");
            }
            else
            {
                doctorService.AddDoctor(doctor);    // 🔥 ADD ONLY NEW
                MessageBox.Show("Doctor Saved Successfully");
            }

            this.Close();

        }
    }
    
}
