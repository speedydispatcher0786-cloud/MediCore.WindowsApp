namespace MediCore.WindowsApp.Forms
{
    partial class AppointmentForm
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
            this.tblDoctor = new System.Windows.Forms.TableLayoutPanel();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lbAppointmentdate = new System.Windows.Forms.Label();
            this.lbDoctor = new System.Windows.Forms.Label();
            this.lbPatient = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.cbxTime = new System.Windows.Forms.ComboBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.tbxPatient = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.tblDoctor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblDoctor
            // 
            this.tblDoctor.ColumnCount = 2;
            this.tblDoctor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tblDoctor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tblDoctor.Controls.Add(this.lbId, 0, 0);
            this.tblDoctor.Controls.Add(this.tbxPatient, 1, 1);
            this.tblDoctor.Controls.Add(this.cmbDoctor, 1, 2);
            this.tblDoctor.Controls.Add(this.tbxID, 1, 0);
            this.tblDoctor.Controls.Add(this.cbxStatus, 1, 5);
            this.tblDoctor.Controls.Add(this.lbStatus, 0, 5);
            this.tblDoctor.Controls.Add(this.cbxTime, 1, 4);
            this.tblDoctor.Controls.Add(this.lbTime, 0, 4);
            this.tblDoctor.Controls.Add(this.dtpDate, 1, 3);
            this.tblDoctor.Controls.Add(this.lbAppointmentdate, 0, 3);
            this.tblDoctor.Controls.Add(this.lbDoctor, 0, 2);
            this.tblDoctor.Controls.Add(this.lbPatient, 0, 1);
            this.tblDoctor.Location = new System.Drawing.Point(3, 3);
            this.tblDoctor.Name = "tblDoctor";
            this.tblDoctor.RowCount = 6;
            this.tblDoctor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblDoctor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblDoctor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblDoctor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblDoctor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblDoctor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblDoctor.Size = new System.Drawing.Size(538, 262);
            this.tblDoctor.TabIndex = 1;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(156, 132);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(379, 25);
            this.dtpDate.TabIndex = 2;
            // 
            // lbAppointmentdate
            // 
            this.lbAppointmentdate.AutoSize = true;
            this.lbAppointmentdate.Location = new System.Drawing.Point(3, 129);
            this.lbAppointmentdate.Name = "lbAppointmentdate";
            this.lbAppointmentdate.Padding = new System.Windows.Forms.Padding(50, 10, 10, 10);
            this.lbAppointmentdate.Size = new System.Drawing.Size(129, 43);
            this.lbAppointmentdate.TabIndex = 4;
            this.lbAppointmentdate.Text = "Appointment Date";
            // 
            // lbDoctor
            // 
            this.lbDoctor.AutoSize = true;
            this.lbDoctor.Location = new System.Drawing.Point(3, 86);
            this.lbDoctor.Name = "lbDoctor";
            this.lbDoctor.Padding = new System.Windows.Forms.Padding(50, 10, 10, 10);
            this.lbDoctor.Size = new System.Drawing.Size(99, 33);
            this.lbDoctor.TabIndex = 2;
            this.lbDoctor.Text = "Doctor";
            // 
            // lbPatient
            // 
            this.lbPatient.AutoSize = true;
            this.lbPatient.Location = new System.Drawing.Point(3, 43);
            this.lbPatient.Name = "lbPatient";
            this.lbPatient.Padding = new System.Windows.Forms.Padding(50, 10, 10, 10);
            this.lbPatient.Size = new System.Drawing.Size(100, 33);
            this.lbPatient.TabIndex = 0;
            this.lbPatient.Text = "Patient";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(3, 172);
            this.lbTime.Name = "lbTime";
            this.lbTime.Padding = new System.Windows.Forms.Padding(50, 10, 10, 10);
            this.lbTime.Size = new System.Drawing.Size(90, 33);
            this.lbTime.TabIndex = 1;
            this.lbTime.Text = "Time";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(3, 215);
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
            // cbxTime
            // 
            this.cbxTime.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTime.FormattingEnabled = true;
            this.cbxTime.Items.AddRange(new object[] {
            "8AM",
            "9AM",
            "10AM",
            "11AM",
            "12PM",
            "1PM",
            "2PM"});
            this.cbxTime.Location = new System.Drawing.Point(156, 175);
            this.cbxTime.Name = "cbxTime";
            this.cbxTime.Size = new System.Drawing.Size(379, 28);
            this.cbxTime.TabIndex = 12;
            // 
            // cbxStatus
            // 
            this.cbxStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Booked",
            "Completed",
            "Canceled"});
            this.cbxStatus.Location = new System.Drawing.Point(156, 218);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(379, 25);
            this.cbxStatus.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(346, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 31);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBook
            // 
            this.btnBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(446, 298);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 31);
            this.btnBook.TabIndex = 3;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbDoctor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Items.AddRange(new object[] {
            "Prof Dr.Umair Abbas",
            "Dr.Uzair Qurehi",
            "Dr.Khizer Abbas",
            "Dr.Shazina ",
            "Dr.Maria Aftab",
            "Dr.Razaq"});
            this.cmbDoctor.Location = new System.Drawing.Point(156, 89);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(379, 25);
            this.cmbDoctor.TabIndex = 17;
            // 
            // tbxPatient
            // 
            this.tbxPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxPatient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPatient.Location = new System.Drawing.Point(156, 46);
            this.tbxPatient.Name = "tbxPatient";
            this.tbxPatient.Size = new System.Drawing.Size(379, 25);
            this.tbxPatient.TabIndex = 19;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(3, 0);
            this.lbId.Name = "lbId";
            this.lbId.Padding = new System.Windows.Forms.Padding(50, 10, 10, 10);
            this.lbId.Size = new System.Drawing.Size(78, 33);
            this.lbId.TabIndex = 20;
            this.lbId.Text = "ID";
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 341);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tblDoctor);
            this.Name = "AppointmentForm";
            this.Text = "AppointmentForm";
            this.tblDoctor.ResumeLayout(false);
            this.tblDoctor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDoctor;
        private System.Windows.Forms.Label lbAppointmentdate;
        private System.Windows.Forms.Label lbDoctor;
        private System.Windows.Forms.Label lbPatient;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbxTime;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbxPatient;
        private System.Windows.Forms.ComboBox cmbDoctor;
    }
}