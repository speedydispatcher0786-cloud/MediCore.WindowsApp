namespace MediCore.WindowsApp.Views
{
    partial class AppointmentsView
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
            this.pnlAppointments = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddappointment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvappointmentsview = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAppointmentdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvappointmentsview)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAppointments
            // 
            this.pnlAppointments.Controls.Add(this.btnDelete);
            this.pnlAppointments.Controls.Add(this.btnUpdate);
            this.pnlAppointments.Controls.Add(this.btnAddappointment);
            this.pnlAppointments.Controls.Add(this.label1);
            this.pnlAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAppointments.Location = new System.Drawing.Point(0, 0);
            this.pnlAppointments.Name = "pnlAppointments";
            this.pnlAppointments.Size = new System.Drawing.Size(597, 100);
            this.pnlAppointments.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(248, 58);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 33);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(141, 58);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddappointment
            // 
            this.btnAddappointment.Location = new System.Drawing.Point(21, 58);
            this.btnAddappointment.Name = "btnAddappointment";
            this.btnAddappointment.Size = new System.Drawing.Size(93, 33);
            this.btnAddappointment.TabIndex = 2;
            this.btnAddappointment.Text = "AddAppointment";
            this.btnAddappointment.UseVisualStyleBackColor = true;
            this.btnAddappointment.Click += new System.EventHandler(this.btnAddappointment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appointments Management";
            // 
            // dgvappointmentsview
            // 
            this.dgvappointmentsview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvappointmentsview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColPatient,
            this.ColDoctor,
            this.ColAppointmentdate,
            this.ColTime,
            this.ColStatus});
            this.dgvappointmentsview.Location = new System.Drawing.Point(3, 106);
            this.dgvappointmentsview.Name = "dgvappointmentsview";
            this.dgvappointmentsview.Size = new System.Drawing.Size(591, 291);
            this.dgvappointmentsview.TabIndex = 1;
            // 
            // ColId
            // 
            this.ColId.HeaderText = "ID";
            this.ColId.Name = "ColId";
            // 
            // ColPatient
            // 
            this.ColPatient.DataPropertyName = "PatientName";
            this.ColPatient.HeaderText = "Patient";
            this.ColPatient.Name = "ColPatient";
            // 
            // ColDoctor
            // 
            this.ColDoctor.DataPropertyName = "DoctorName";
            this.ColDoctor.HeaderText = "Doctor";
            this.ColDoctor.Name = "ColDoctor";
            // 
            // ColAppointmentdate
            // 
            this.ColAppointmentdate.DataPropertyName = "AppointmentDate";
            this.ColAppointmentdate.HeaderText = "AppointmentDate";
            this.ColAppointmentdate.Name = "ColAppointmentdate";
            // 
            // ColTime
            // 
            this.ColTime.DataPropertyName = "Time";
            this.ColTime.HeaderText = "Time";
            this.ColTime.Name = "ColTime";
            // 
            // ColStatus
            // 
            this.ColStatus.DataPropertyName = "Status";
            this.ColStatus.HeaderText = "Status";
            this.ColStatus.Name = "ColStatus";
            // 
            // AppointmentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvappointmentsview);
            this.Controls.Add(this.pnlAppointments);
            this.Name = "AppointmentsView";
            this.Size = new System.Drawing.Size(597, 400);
            this.pnlAppointments.ResumeLayout(false);
            this.pnlAppointments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvappointmentsview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAppointments;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddappointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvappointmentsview;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAppointmentdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
    }
}
