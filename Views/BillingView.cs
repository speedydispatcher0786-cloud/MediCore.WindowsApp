using MediCore.App.Core.Models;
using MediCore.App.Services;
using MediCore.WindowsApp.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MediCore.WindowsApp.Views
{
    public partial class BillingView : UserControl
    {
        private readonly DBBillService _billService;

        public BillingView()
        {
            InitializeComponent();

            // Replace with your actual connection string
            string connectionString =
                "Server=(localdb)\\MSSQLLocalDB;Database=MediCoreDB;Trusted_Connection=True;TrustServerCertificate=True;";

            _billService = new DBBillService(connectionString);

            DesignControls();
            LoadBillsData();

            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
        }

        private void LoadBillsData()
        {
            dgvBills.Rows.Clear();

            try
            {
                List<Bill> bills = _billService.GetAllBills();

                foreach (Bill bill in bills)
                {
                    dgvBills.Rows.Add(
                        bill.Id,            // Hidden column 0 — Id
                        bill.PatientName,   // Column 1 — Patient Name
                        bill.Service,       // Column 2 — Service
                        bill.TotalBill,     // Column 3 — Total Bill
                        bill.Status         // Column 4 — Status
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bills: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DesignControls()
        {
            pnlBillingview.BackColor = Color.LightSteelBlue;

            dgvBills.BackgroundColor = Color.White;
            dgvBills.BorderStyle = BorderStyle.None;
            dgvBills.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            btnAdd.BackColor = Color.LightGreen;
            btnUpdate.BackColor = Color.Khaki;
            btnDelete.BackColor = Color.LightCoral;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BillForm billForm = new BillForm(); // Open blank form

            if (billForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _billService.AddBill(billForm.ResultBill);

                    MessageBox.Show("Bill Added Successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadBillsData(); // Refresh grid
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding bill: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvBills.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a bill to update.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dgvBills.SelectedRows[0];

            // Read the selected row into a Bill object
            Bill existing = new Bill
            {
                Id = Convert.ToInt32(selectedRow.Cells[0].Value),
                PatientName = selectedRow.Cells[1].Value?.ToString(),
                Service = selectedRow.Cells[2].Value?.ToString(),
                TotalBill = Convert.ToDecimal(selectedRow.Cells[3].Value),
                Status = selectedRow.Cells[4].Value?.ToString()
            };

            BillForm billForm = new BillForm(existing); // Open pre-filled form

            if (billForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    billForm.ResultBill.Id = existing.Id; // Preserve Id
                    _billService.UpdateBill(billForm.ResultBill);

                    MessageBox.Show("Bill Updated Successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadBillsData(); // Refresh grid
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating bill: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBills.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a bill to delete.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                "Are you sure you want to delete this bill?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                int id = Convert.ToInt32(dgvBills.SelectedRows[0].Cells[0].Value);
                _billService.DeleteBill(id);

                MessageBox.Show("Bill Deleted Successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadBillsData(); // Refresh grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting bill: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}