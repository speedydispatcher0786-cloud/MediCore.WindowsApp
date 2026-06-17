namespace MediCore.WindowsApp.Views
{
    partial class PatientsView
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
            this.lbPatientmanagement = new System.Windows.Forms.Label();
            this.pnlpatienttop = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvPatientdetails = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBloodgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlpatienttop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPatientmanagement
            // 
            this.lbPatientmanagement.AutoSize = true;
            this.lbPatientmanagement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPatientmanagement.Location = new System.Drawing.Point(14, 8);
            this.lbPatientmanagement.Name = "lbPatientmanagement";
            this.lbPatientmanagement.Size = new System.Drawing.Size(198, 25);
            this.lbPatientmanagement.TabIndex = 0;
            this.lbPatientmanagement.Text = "Patient Management";
            // 
            // pnlpatienttop
            // 
            this.pnlpatienttop.Controls.Add(this.btnDelete);
            this.pnlpatienttop.Controls.Add(this.btnEdit);
            this.pnlpatienttop.Controls.Add(this.btnAdd);
            this.pnlpatienttop.Controls.Add(this.lbPatientmanagement);
            this.pnlpatienttop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlpatienttop.Location = new System.Drawing.Point(0, 0);
            this.pnlpatienttop.Name = "pnlpatienttop";
            this.pnlpatienttop.Size = new System.Drawing.Size(692, 78);
            this.pnlpatienttop.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(227, 52);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(119, 52);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Patient";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvPatientdetails
            // 
            this.dgvPatientdetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatientdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientdetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.colName,
            this.Colage,
            this.ColGender,
            this.ColContact,
            this.ColBloodgroup});
            this.dgvPatientdetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPatientdetails.Location = new System.Drawing.Point(0, 78);
            this.dgvPatientdetails.Name = "dgvPatientdetails";
            this.dgvPatientdetails.Size = new System.Drawing.Size(692, 373);
            this.dgvPatientdetails.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // Colage
            // 
            this.Colage.HeaderText = "Age";
            this.Colage.Name = "Colage";
            // 
            // ColGender
            // 
            this.ColGender.HeaderText = "Gender";
            this.ColGender.Name = "ColGender";
            // 
            // ColContact
            // 
            this.ColContact.HeaderText = "Contact";
            this.ColContact.Name = "ColContact";
            // 
            // ColBloodgroup
            // 
            this.ColBloodgroup.HeaderText = "Blood Group";
            this.ColBloodgroup.Name = "ColBloodgroup";
            // 
            // PatientsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPatientdetails);
            this.Controls.Add(this.pnlpatienttop);
            this.Name = "PatientsView";
            this.Size = new System.Drawing.Size(692, 451);
            this.pnlpatienttop.ResumeLayout(false);
            this.pnlpatienttop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientdetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbPatientmanagement;
        private System.Windows.Forms.Panel pnlpatienttop;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvPatientdetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBloodgroup;
    }
}
