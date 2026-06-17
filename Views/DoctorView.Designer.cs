namespace MediCore.WindowsApp.Views
{
    partial class DoctorView
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
            this.pnldoctortop = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddDoctor = new System.Windows.Forms.Button();
            this.lbDoctormanagement = new System.Windows.Forms.Label();
            this.dgvDoctorview = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSpecailization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAvailabledays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnldoctortop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorview)).BeginInit();
            this.SuspendLayout();
            // 
            // pnldoctortop
            // 
            this.pnldoctortop.Controls.Add(this.btnDelete);
            this.pnldoctortop.Controls.Add(this.btnUpdate);
            this.pnldoctortop.Controls.Add(this.btnAddDoctor);
            this.pnldoctortop.Controls.Add(this.lbDoctormanagement);
            this.pnldoctortop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnldoctortop.Location = new System.Drawing.Point(0, 0);
            this.pnldoctortop.Name = "pnldoctortop";
            this.pnldoctortop.Size = new System.Drawing.Size(611, 100);
            this.pnldoctortop.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(220, 67);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(125, 67);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.Location = new System.Drawing.Point(23, 67);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(75, 23);
            this.btnAddDoctor.TabIndex = 2;
            this.btnAddDoctor.Text = "Add Doctor";
            this.btnAddDoctor.UseVisualStyleBackColor = true;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // lbDoctormanagement
            // 
            this.lbDoctormanagement.AutoSize = true;
            this.lbDoctormanagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoctormanagement.Location = new System.Drawing.Point(39, 14);
            this.lbDoctormanagement.Name = "lbDoctormanagement";
            this.lbDoctormanagement.Size = new System.Drawing.Size(175, 21);
            this.lbDoctormanagement.TabIndex = 0;
            this.lbDoctormanagement.Text = "Doctors Management";
            // 
            // dgvDoctorview
            // 
            this.dgvDoctorview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctorview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColName,
            this.ColSpecailization,
            this.ColContact,
            this.ColAvailabledays});
            this.dgvDoctorview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoctorview.Location = new System.Drawing.Point(0, 100);
            this.dgvDoctorview.Name = "dgvDoctorview";
            this.dgvDoctorview.Size = new System.Drawing.Size(611, 293);
            this.dgvDoctorview.TabIndex = 1;
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
            // ColSpecailization
            // 
            this.ColSpecailization.HeaderText = "Specialization";
            this.ColSpecailization.Name = "ColSpecailization";
            // 
            // ColContact
            // 
            this.ColContact.HeaderText = "Contact";
            this.ColContact.Name = "ColContact";
            // 
            // ColAvailabledays
            // 
            this.ColAvailabledays.HeaderText = "AvailableDays";
            this.ColAvailabledays.Name = "ColAvailabledays";
            // 
            // DoctorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDoctorview);
            this.Controls.Add(this.pnldoctortop);
            this.Name = "DoctorView";
            this.Size = new System.Drawing.Size(611, 393);
            this.pnldoctortop.ResumeLayout(false);
            this.pnldoctortop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnldoctortop;
        private System.Windows.Forms.Label lbDoctormanagement;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddDoctor;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvDoctorview;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSpecailization;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAvailabledays;
    }
}
