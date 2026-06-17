namespace MediCore.WindowsApp.Forms
{
    partial class DoctorForm
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
            this.pnlDoctorForm = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tblDoctor = new System.Windows.Forms.TableLayoutPanel();
            this.tbxAvailabledays = new System.Windows.Forms.TextBox();
            this.tbxContact = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lbSpecailization = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbContact = new System.Windows.Forms.Label();
            this.lbAvailabledays = new System.Windows.Forms.Label();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.cbxSpecailization = new System.Windows.Forms.ComboBox();
            this.pnlDoctorForm.SuspendLayout();
            this.tblDoctor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDoctorForm
            // 
            this.pnlDoctorForm.Controls.Add(this.btnSave);
            this.pnlDoctorForm.Controls.Add(this.btnCancel);
            this.pnlDoctorForm.Controls.Add(this.tblDoctor);
            this.pnlDoctorForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDoctorForm.Location = new System.Drawing.Point(0, 0);
            this.pnlDoctorForm.Name = "pnlDoctorForm";
            this.pnlDoctorForm.Size = new System.Drawing.Size(544, 325);
            this.pnlDoctorForm.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(439, 282);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 31);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(339, 282);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 31);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tblDoctor
            // 
            this.tblDoctor.ColumnCount = 2;
            this.tblDoctor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tblDoctor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tblDoctor.Controls.Add(this.tbxAvailabledays, 1, 4);
            this.tblDoctor.Controls.Add(this.tbxContact, 1, 3);
            this.tblDoctor.Controls.Add(this.txbName, 1, 1);
            this.tblDoctor.Controls.Add(this.lbSpecailization, 0, 2);
            this.tblDoctor.Controls.Add(this.lbName, 0, 1);
            this.tblDoctor.Controls.Add(this.lbID, 0, 0);
            this.tblDoctor.Controls.Add(this.lbContact, 0, 3);
            this.tblDoctor.Controls.Add(this.lbAvailabledays, 0, 4);
            this.tblDoctor.Controls.Add(this.tbxID, 1, 0);
            this.tblDoctor.Controls.Add(this.cbxSpecailization, 1, 2);
            this.tblDoctor.Location = new System.Drawing.Point(3, 3);
            this.tblDoctor.Name = "tblDoctor";
            this.tblDoctor.RowCount = 5;
            this.tblDoctor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblDoctor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblDoctor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblDoctor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblDoctor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblDoctor.Size = new System.Drawing.Size(538, 262);
            this.tblDoctor.TabIndex = 0;
            // 
            // tbxAvailabledays
            // 
            this.tbxAvailabledays.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxAvailabledays.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAvailabledays.Location = new System.Drawing.Point(156, 211);
            this.tbxAvailabledays.Name = "tbxAvailabledays";
            this.tbxAvailabledays.Size = new System.Drawing.Size(379, 25);
            this.tbxAvailabledays.TabIndex = 9;
            // 
            // tbxContact
            // 
            this.tbxContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxContact.Location = new System.Drawing.Point(156, 159);
            this.tbxContact.Name = "tbxContact";
            this.tbxContact.Size = new System.Drawing.Size(379, 25);
            this.tbxContact.TabIndex = 8;
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
            // lbSpecailization
            // 
            this.lbSpecailization.AutoSize = true;
            this.lbSpecailization.Location = new System.Drawing.Point(3, 104);
            this.lbSpecailization.Name = "lbSpecailization";
            this.lbSpecailization.Padding = new System.Windows.Forms.Padding(50, 10, 10, 10);
            this.lbSpecailization.Size = new System.Drawing.Size(132, 33);
            this.lbSpecailization.TabIndex = 4;
            this.lbSpecailization.Text = "Specialization";
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
            // lbContact
            // 
            this.lbContact.AutoSize = true;
            this.lbContact.Location = new System.Drawing.Point(3, 156);
            this.lbContact.Name = "lbContact";
            this.lbContact.Padding = new System.Windows.Forms.Padding(50, 10, 10, 10);
            this.lbContact.Size = new System.Drawing.Size(104, 33);
            this.lbContact.TabIndex = 1;
            this.lbContact.Text = "Contact";
            // 
            // lbAvailabledays
            // 
            this.lbAvailabledays.AutoSize = true;
            this.lbAvailabledays.Location = new System.Drawing.Point(3, 208);
            this.lbAvailabledays.Name = "lbAvailabledays";
            this.lbAvailabledays.Padding = new System.Windows.Forms.Padding(50, 10, 10, 10);
            this.lbAvailabledays.Size = new System.Drawing.Size(137, 33);
            this.lbAvailabledays.TabIndex = 3;
            this.lbAvailabledays.Text = "Available Days";
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
            // cbxSpecailization
            // 
            this.cbxSpecailization.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxSpecailization.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSpecailization.FormattingEnabled = true;
            this.cbxSpecailization.Items.AddRange(new object[] {
            "Cardiologist",
            "Dermatologist",
            "Neurologist",
            "Orthopedic",
            "Pediatrician",
            "Gynecologist",
            "ENT Specialist",
            "General Physician"});
            this.cbxSpecailization.Location = new System.Drawing.Point(156, 107);
            this.cbxSpecailization.Name = "cbxSpecailization";
            this.cbxSpecailization.Size = new System.Drawing.Size(379, 25);
            this.cbxSpecailization.TabIndex = 10;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 325);
            this.Controls.Add(this.pnlDoctorForm);
            this.Name = "DoctorForm";
            this.Text = "DoctorForm";
            this.pnlDoctorForm.ResumeLayout(false);
            this.tblDoctor.ResumeLayout(false);
            this.tblDoctor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDoctorForm;
        private System.Windows.Forms.TableLayoutPanel tblDoctor;
        private System.Windows.Forms.Label lbSpecailization;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbContact;
        private System.Windows.Forms.Label lbAvailabledays;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbxAvailabledays;
        private System.Windows.Forms.TextBox tbxContact;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.ComboBox cbxSpecailization;
        private System.Windows.Forms.Button btnSave;
    }
}