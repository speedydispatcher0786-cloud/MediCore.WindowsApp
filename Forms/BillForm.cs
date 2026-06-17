using MediCore.App.Core.Models;
using MediCore.App.Services;
using System;
using System.Windows.Forms;

namespace MediCore.WindowsApp.Forms
{
    public partial class BillForm : Form
    {
        public Bill ResultBill { get; private set; }

        private bool isUpdate = false;
        private int editingId = 0;

        public BillForm(Bill existingBill = null)
        {
            InitializeComponent();

            // ComboBox Items
            cmbxStatus.Items.Add("Paid");
            cmbxStatus.Items.Add("Pending");

            tbxID.Text = "AUTO";
            tbxID.ReadOnly = true;

            // If editing an existing bill, pre-fill the fields
            if (existingBill != null)
            {
                isUpdate = true;
                editingId = existingBill.Id;

                tbxID.Text = existingBill.Id.ToString();
                txbName.Text = existingBill.PatientName;
                tbxService.Text = existingBill.Service;
                tbxTotalBill.Text = existingBill.TotalBill.ToString();
                cmbxStatus.Text = existingBill.Status;
            }

            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txbName.Text))
            {
                MessageBox.Show("Please Enter Patient Name",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxService.Text))
            {
                MessageBox.Show("Please Enter Service",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxService.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxTotalBill.Text))
            {
                MessageBox.Show("Please Enter Total Bill",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxTotalBill.Focus();
                return;
            }

            if (!decimal.TryParse(tbxTotalBill.Text, out decimal totalBill))
            {
                MessageBox.Show("Total Bill must be a valid number.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxTotalBill.Focus();
                return;
            }

            if (cmbxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Status",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Build the result bill to pass back to the View
            ResultBill = new Bill
            {
                Id = editingId,
                PatientName = txbName.Text.Trim(),
                Service = tbxService.Text.Trim(),
                TotalBill = totalBill,
                Status = cmbxStatus.Text
            };

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