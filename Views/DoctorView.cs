using MediCore.App.Core.Contracts;
using MediCore.App.Core.Models;
using MediCore.App.Services;
using MediCore.WindowsApp.Forms;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Windows.Forms;

namespace MediCore.WindowsApp.Views
{
    public partial class DoctorView : UserControl
    {
        private DBDoctorService doctorService;

        //private static DBDoctorService doctorService = new DBDoctorService();

        public DoctorView()
        {
            InitializeComponent();

            string connectionString =
                "Server=(localdb)\\MSSQLLocalDB;Database=MediCoreDB;Trusted_Connection=True;TrustServerCertificate=True;";

            doctorService =
                new DBDoctorService(connectionString);

            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            //this.btnAddDoctor.Click += new System.EventHandler(this._Click);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            LoadDoctors();
        }

        private void LoadDoctors()
        {
            dgvDoctorview.Rows.Clear();

            var patients = doctorService.GetAllDoctors();
            foreach (var d in doctorService.GetAllDoctors())
            {
                dgvDoctorview.Rows.Add(
                    d.Id,
                    d.Name,
                    d.Specialization,
                    d.Contact,
                    d.AvailableDays
                );
            }
        
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            DoctorForm f = new DoctorForm();
            f.ShowDialog();
            LoadDoctors();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDoctorview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select Doctor");
                return;
            }

            int id = Convert.ToInt32(dgvDoctorview.SelectedRows[0].Cells[0].Value);

            doctorService.DeleteDoctor(id);

            LoadDoctors();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvDoctorview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select Doctor");
                return;
            }

            var row = dgvDoctorview.SelectedRows[0];

            DoctorForm f = new DoctorForm();
            f.SetUpdateData(
                Convert.ToInt32(row.Cells[0].Value),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString()
            );

            f.ShowDialog();
            LoadDoctors();
        }

        
    }
}