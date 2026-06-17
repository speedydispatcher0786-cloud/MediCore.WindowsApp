namespace MediCore.WindowsApp.Forms
{
    partial class BillForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblBill = new System.Windows.Forms.TableLayoutPanel();
            this.tbxTotalBill = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lbService = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbTotalBill = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.cmbxStatus = new System.Windows.Forms.ComboBox();
            this.tbxService = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tblBill.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblBill
            // 
            this.tblBill.ColumnCount = 2;
            this.tblBill.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tblBill.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tblBill.Controls.Add(this.tbxService, 1, 2);
            this.tblBill.Controls.Add(this.cmbxStatus, 1, 4);
            this.tblBill.Controls.Add(this.tbxTotalBill, 1, 3);
            this.tblBill.Controls.Add(this.txbName, 1, 1);
            this.tblBill.Controls.Add(this.lbService, 0, 2);
            this.tblBill.Controls.Add(this.lbName, 0, 1);
            this.tblBill.Controls.Add(this.lbID, 0, 0);
            this.tblBill.Controls.Add(this.lbTotalBill, 0, 3);
            this.tblBill.Controls.Add(this.lbStatus, 0, 4);
            this.tblBill.Controls.Add(this.tbxID, 1, 0);
            this.tblBill.Location = new System.Drawing.Point(3, 3);
            this.tblBill.Name = "tblBill";
            this.tblBill.RowCount = 5;
            this.tblBill.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblBill.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblBill.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblBill.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblBill.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblBill.Size = new System.Drawing.Size(538, 262);
            this.tblBill.TabIndex = 1;
            // 
            // tbxTotalBill
            // 
            this.tbxTotalBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxTotalBill.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTotalBill.Location = new System.Drawing.Point(156, 159);
            this.tbxTotalBill.Name = "tbxTotalBill";
            this.tbxTotalBill.Size = new System.Drawing.Size(379, 25);
            this.tbxTotalBill.TabIndex = 8;
            // 
            // txbName
            // 
            this.txbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txbName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(156, 55);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(379, 25);
            this.txbName.TabIndex = 6;
            // 
            // lbService
            // 
            this.lbService.AutoSize = true;
            this.lbService.Location = new System.Drawing.Point(3, 104);
            this.lbService.Name = "lbService";
            this.lbService.Padding = new System.Windows.Forms.Padding(50, 10, 10, 10);
            this.lbService.Size = new System.Drawing.Size(103, 33);
            this.lbService.TabIndex = 4;
            this.lbService.Text = "Service";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(3, 52);
            this.lbName.Name = "lbName";
            this.lbName.Padding = new System.Windows.Forms.Padding(50, 10, 10, 10);
            this.lbName.Size = new System.Drawing.Size(95, 33);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(3, 0);
            this.lbID.Name = "lbID";
            this.lbID.Padding = new System.Windows.Forms.Padding(50, 10, 10, 10);
            this.lbID.Size = new System.Drawing.Size(78, 33);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID";
            // 
            // lbTotalBill
            // 
            this.lbTotalBill.AutoSize = true;
            this.lbTotalBill.Location = new System.Drawing.Point(3, 156);
            this.lbTotalBill.Name = "lbTotalBill";
            this.lbTotalBill.Padding = new System.Windows.Forms.Padding(50, 10, 10, 10);
            this.lbTotalBill.Size = new System.Drawing.Size(107, 33);
            this.lbTotalBill.TabIndex = 1;
            this.lbTotalBill.Text = "Total Bill";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(3, 208);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Padding = new System.Windows.Forms.Padding(50, 10, 10, 10);
            this.lbStatus.Size = new System.Drawing.Size(97, 33);
            this.lbStatus.TabIndex = 3;
            this.lbStatus.Text = "Status";
            // 
            // tbxID
            // 
            this.tbxID.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxID.Location = new System.Drawing.Point(156, 3);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(379, 25);
            this.tbxID.TabIndex = 5;
            // 
            // cmbxStatus
            // 
            this.cmbxStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbxStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxStatus.FormattingEnabled = true;
            this.cmbxStatus.Location = new System.Drawing.Point(156, 211);
            this.cmbxStatus.Name = "cmbxStatus";
            this.cmbxStatus.Size = new System.Drawing.Size(379, 25);
            this.cmbxStatus.TabIndex = 11;
            // 
            // tbxService
            // 
            this.tbxService.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxService.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxService.Location = new System.Drawing.Point(156, 107);
            this.tbxService.Name = "tbxService";
            this.tbxService.Size = new System.Drawing.Size(379, 25);
            this.tbxService.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(339, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 31);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(439, 281);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 31);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 315);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tblBill);
            this.Name = "BillForm";
            this.Text = "BillForm";
            this.tblBill.ResumeLayout(false);
            this.tblBill.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblBill;
        private System.Windows.Forms.TextBox tbxTotalBill;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lbService;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbTotalBill;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.TextBox tbxService;
        private System.Windows.Forms.ComboBox cmbxStatus;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}