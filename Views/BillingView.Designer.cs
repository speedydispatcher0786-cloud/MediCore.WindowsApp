namespace MediCore.WindowsApp.Views
{
    partial class BillingView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBillingview = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbBills = new System.Windows.Forms.Label();
            this.dgvBills = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBillingview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBillingview
            // 
            this.pnlBillingview.Controls.Add(this.btnDelete);
            this.pnlBillingview.Controls.Add(this.btnUpdate);
            this.pnlBillingview.Controls.Add(this.btnAdd);
            this.pnlBillingview.Controls.Add(this.lbBills);
            this.pnlBillingview.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBillingview.Location = new System.Drawing.Point(0, 0);
            this.pnlBillingview.Name = "pnlBillingview";
            this.pnlBillingview.Size = new System.Drawing.Size(596, 100);
            this.pnlBillingview.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(223, 64);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(111, 64);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            //this.btnUpdate.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.btnUpdate_ChangeUICues);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Bills";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbBills
            // 
            this.lbBills.AutoSize = true;
            this.lbBills.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBills.Location = new System.Drawing.Point(20, 19);
            this.lbBills.Name = "lbBills";
            this.lbBills.Size = new System.Drawing.Size(148, 21);
            this.lbBills.TabIndex = 0;
            this.lbBills.Text = "Bills Management";
            //this.lbBills.Click += new System.EventHandler(this.lbBills_Click);
            // 
            // dgvBills
            // 
            this.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColName,
            this.ColService,
            this.ColTotal,
            this.ColStatus});
            this.dgvBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBills.Location = new System.Drawing.Point(0, 100);
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.Size = new System.Drawing.Size(596, 293);
            this.dgvBills.TabIndex = 1;
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            // 
            // ColService
            // 
            this.ColService.HeaderText = "Service";
            this.ColService.Name = "ColService";
            // 
            // ColTotal
            // 
            this.ColTotal.HeaderText = "Total Bill";
            this.ColTotal.Name = "ColTotal";
            // 
            // ColStatus
            // 
            this.ColStatus.HeaderText = "Status";
            this.ColStatus.Name = "ColStatus";
            // 
            // BillingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvBills);
            this.Controls.Add(this.pnlBillingview);
            this.Name = "BillingView";
            this.Size = new System.Drawing.Size(596, 393);
            this.pnlBillingview.ResumeLayout(false);
            this.pnlBillingview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBillingview;
        private System.Windows.Forms.Label lbBills;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvBills;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColService;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
    }
}
