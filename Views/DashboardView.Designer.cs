namespace MediCore.WindowsApp.Views
{
    partial class DashboardView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDashboard = new System.Windows.Forms.Label();
            this.pnlPatients = new System.Windows.Forms.Panel();
            this.pnlDoctors = new System.Windows.Forms.Panel();
            this.pnlAppointments = new System.Windows.Forms.Panel();
            this.pnlRevenue = new System.Windows.Forms.Panel();
            this.lbTotalpatient = new System.Windows.Forms.Label();
            this.lbpatient = new System.Windows.Forms.Label();
            this.lbpatients = new System.Windows.Forms.Label();
            this.lbDoctors = new System.Windows.Forms.Label();
            this.lbAppointments = new System.Windows.Forms.Label();
            this.lbdoctor = new System.Windows.Forms.Label();
            this.lbdoctorduty = new System.Windows.Forms.Label();
            this.lbappointment = new System.Windows.Forms.Label();
            this.lbapptoday = new System.Windows.Forms.Label();
            this.lbRevenue = new System.Windows.Forms.Label();
            this.lbrevenues = new System.Windows.Forms.Label();
            this.lbprice = new System.Windows.Forms.Label();
            this.pnlTodayappointments = new System.Windows.Forms.Panel();
            this.lbKaleem = new System.Windows.Forms.Label();
            this.lbk = new System.Windows.Forms.Label();
            this.lbAqib = new System.Windows.Forms.Label();
            this.lbkcomplete = new System.Windows.Forms.Label();
            this.lbAC = new System.Windows.Forms.Label();
            this.lbA = new System.Windows.Forms.Label();
            this.lbTcancel = new System.Windows.Forms.Label();
            this.lbT = new System.Windows.Forms.Label();
            this.lbTooba = new System.Windows.Forms.Label();
            this.lbTodayappointments = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlPatients.SuspendLayout();
            this.pnlDoctors.SuspendLayout();
            this.pnlAppointments.SuspendLayout();
            this.pnlRevenue.SuspendLayout();
            this.pnlTodayappointments.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlTodayappointments);
            this.panel1.Controls.Add(this.pnlRevenue);
            this.panel1.Controls.Add(this.pnlAppointments);
            this.panel1.Controls.Add(this.pnlDoctors);
            this.panel1.Controls.Add(this.pnlPatients);
            this.panel1.Controls.Add(this.lbDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 448);
            this.panel1.TabIndex = 0;
            // 
            // lbDashboard
            // 
            this.lbDashboard.AutoSize = true;
            this.lbDashboard.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDashboard.Location = new System.Drawing.Point(20, 11);
            this.lbDashboard.Name = "lbDashboard";
            this.lbDashboard.Size = new System.Drawing.Size(138, 32);
            this.lbDashboard.TabIndex = 0;
            this.lbDashboard.Text = "Dashboard";
            this.lbDashboard.Click += new System.EventHandler(this.lbDashboard_Click);
            // 
            // pnlPatients
            // 
            this.pnlPatients.Controls.Add(this.lbpatients);
            this.pnlPatients.Controls.Add(this.lbpatient);
            this.pnlPatients.Controls.Add(this.lbTotalpatient);
            this.pnlPatients.Location = new System.Drawing.Point(13, 85);
            this.pnlPatients.Name = "pnlPatients";
            this.pnlPatients.Size = new System.Drawing.Size(129, 100);
            this.pnlPatients.TabIndex = 1;
            // 
            // pnlDoctors
            // 
            this.pnlDoctors.Controls.Add(this.lbdoctorduty);
            this.pnlDoctors.Controls.Add(this.lbdoctor);
            this.pnlDoctors.Controls.Add(this.lbDoctors);
            this.pnlDoctors.Location = new System.Drawing.Point(170, 85);
            this.pnlDoctors.Name = "pnlDoctors";
            this.pnlDoctors.Size = new System.Drawing.Size(129, 100);
            this.pnlDoctors.TabIndex = 2;
            // 
            // pnlAppointments
            // 
            this.pnlAppointments.Controls.Add(this.lbapptoday);
            this.pnlAppointments.Controls.Add(this.lbappointment);
            this.pnlAppointments.Controls.Add(this.lbAppointments);
            this.pnlAppointments.Location = new System.Drawing.Point(319, 85);
            this.pnlAppointments.Name = "pnlAppointments";
            this.pnlAppointments.Size = new System.Drawing.Size(129, 100);
            this.pnlAppointments.TabIndex = 3;
            // 
            // pnlRevenue
            // 
            this.pnlRevenue.Controls.Add(this.lbprice);
            this.pnlRevenue.Controls.Add(this.lbrevenues);
            this.pnlRevenue.Controls.Add(this.lbRevenue);
            this.pnlRevenue.Location = new System.Drawing.Point(469, 85);
            this.pnlRevenue.Name = "pnlRevenue";
            this.pnlRevenue.Size = new System.Drawing.Size(129, 100);
            this.pnlRevenue.TabIndex = 4;
            // 
            // lbTotalpatient
            // 
            this.lbTotalpatient.AutoSize = true;
            this.lbTotalpatient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalpatient.Location = new System.Drawing.Point(22, 9);
            this.lbTotalpatient.Name = "lbTotalpatient";
            this.lbTotalpatient.Size = new System.Drawing.Size(82, 15);
            this.lbTotalpatient.TabIndex = 0;
            this.lbTotalpatient.Text = "Total Patients";
            // 
            // lbpatient
            // 
            this.lbpatient.AutoSize = true;
            this.lbpatient.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpatient.Location = new System.Drawing.Point(21, 39);
            this.lbpatient.Name = "lbpatient";
            this.lbpatient.Size = new System.Drawing.Size(36, 20);
            this.lbpatient.TabIndex = 1;
            this.lbpatient.Text = "247";
            this.lbpatient.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbpatients
            // 
            this.lbpatients.AutoSize = true;
            this.lbpatients.Location = new System.Drawing.Point(22, 70);
            this.lbpatients.Name = "lbpatients";
            this.lbpatients.Size = new System.Drawing.Size(46, 13);
            this.lbpatients.TabIndex = 2;
            this.lbpatients.Text = "+3 Days";
            this.lbpatients.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbDoctors
            // 
            this.lbDoctors.AutoSize = true;
            this.lbDoctors.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoctors.Location = new System.Drawing.Point(47, 10);
            this.lbDoctors.Name = "lbDoctors";
            this.lbDoctors.Size = new System.Drawing.Size(56, 17);
            this.lbDoctors.TabIndex = 0;
            this.lbDoctors.Text = "Doctors";
            this.lbDoctors.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbAppointments
            // 
            this.lbAppointments.AutoSize = true;
            this.lbAppointments.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppointments.Location = new System.Drawing.Point(20, 10);
            this.lbAppointments.Name = "lbAppointments";
            this.lbAppointments.Size = new System.Drawing.Size(96, 17);
            this.lbAppointments.TabIndex = 0;
            this.lbAppointments.Text = "Appointments";
            // 
            // lbdoctor
            // 
            this.lbdoctor.AutoSize = true;
            this.lbdoctor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdoctor.Location = new System.Drawing.Point(46, 39);
            this.lbdoctor.Name = "lbdoctor";
            this.lbdoctor.Size = new System.Drawing.Size(27, 20);
            this.lbdoctor.TabIndex = 1;
            this.lbdoctor.Text = "12";
            // 
            // lbdoctorduty
            // 
            this.lbdoctorduty.AutoSize = true;
            this.lbdoctorduty.Location = new System.Drawing.Point(47, 70);
            this.lbdoctorduty.Name = "lbdoctorduty";
            this.lbdoctorduty.Size = new System.Drawing.Size(51, 13);
            this.lbdoctorduty.TabIndex = 2;
            this.lbdoctorduty.Text = "8 on duty";
            // 
            // lbappointment
            // 
            this.lbappointment.AutoSize = true;
            this.lbappointment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbappointment.Location = new System.Drawing.Point(40, 39);
            this.lbappointment.Name = "lbappointment";
            this.lbappointment.Size = new System.Drawing.Size(27, 20);
            this.lbappointment.TabIndex = 1;
            this.lbappointment.Text = "30";
            // 
            // lbapptoday
            // 
            this.lbapptoday.AutoSize = true;
            this.lbapptoday.Location = new System.Drawing.Point(40, 70);
            this.lbapptoday.Name = "lbapptoday";
            this.lbapptoday.Size = new System.Drawing.Size(37, 13);
            this.lbapptoday.TabIndex = 2;
            this.lbapptoday.Text = "Today";
            // 
            // lbRevenue
            // 
            this.lbRevenue.AutoSize = true;
            this.lbRevenue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRevenue.Location = new System.Drawing.Point(33, 10);
            this.lbRevenue.Name = "lbRevenue";
            this.lbRevenue.Size = new System.Drawing.Size(60, 17);
            this.lbRevenue.TabIndex = 1;
            this.lbRevenue.Text = "Revenue";
            this.lbRevenue.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbrevenues
            // 
            this.lbrevenues.AutoSize = true;
            this.lbrevenues.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrevenues.Location = new System.Drawing.Point(32, 39);
            this.lbrevenues.Name = "lbrevenues";
            this.lbrevenues.Size = new System.Drawing.Size(54, 20);
            this.lbrevenues.TabIndex = 2;
            this.lbrevenues.Text = "30000";
            this.lbrevenues.Click += new System.EventHandler(this.lbrevenues_Click);
            // 
            // lbprice
            // 
            this.lbprice.AutoSize = true;
            this.lbprice.Location = new System.Drawing.Point(33, 70);
            this.lbprice.Name = "lbprice";
            this.lbprice.Size = new System.Drawing.Size(62, 13);
            this.lbprice.TabIndex = 3;
            this.lbprice.Text = "PKR Today";
            this.lbprice.Click += new System.EventHandler(this.label9_Click);
            // 
            // pnlTodayappointments
            // 
            this.pnlTodayappointments.Controls.Add(this.lbTodayappointments);
            this.pnlTodayappointments.Controls.Add(this.lbTooba);
            this.pnlTodayappointments.Controls.Add(this.lbT);
            this.pnlTodayappointments.Controls.Add(this.lbTcancel);
            this.pnlTodayappointments.Controls.Add(this.lbA);
            this.pnlTodayappointments.Controls.Add(this.lbAC);
            this.pnlTodayappointments.Controls.Add(this.lbkcomplete);
            this.pnlTodayappointments.Controls.Add(this.lbAqib);
            this.pnlTodayappointments.Controls.Add(this.lbk);
            this.pnlTodayappointments.Controls.Add(this.lbKaleem);
            this.pnlTodayappointments.Location = new System.Drawing.Point(176, 229);
            this.pnlTodayappointments.Name = "pnlTodayappointments";
            this.pnlTodayappointments.Size = new System.Drawing.Size(220, 173);
            this.pnlTodayappointments.TabIndex = 5;
            // 
            // lbKaleem
            // 
            this.lbKaleem.AutoSize = true;
            this.lbKaleem.Location = new System.Drawing.Point(10, 53);
            this.lbKaleem.Name = "lbKaleem";
            this.lbKaleem.Size = new System.Drawing.Size(42, 13);
            this.lbKaleem.TabIndex = 0;
            this.lbKaleem.Text = "Kaleem";
            this.lbKaleem.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbk
            // 
            this.lbk.AutoSize = true;
            this.lbk.Location = new System.Drawing.Point(82, 53);
            this.lbk.Name = "lbk";
            this.lbk.Size = new System.Drawing.Size(29, 13);
            this.lbk.TabIndex = 1;
            this.lbk.Text = "9AM";
            this.lbk.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lbAqib
            // 
            this.lbAqib.AutoSize = true;
            this.lbAqib.Location = new System.Drawing.Point(10, 93);
            this.lbAqib.Name = "lbAqib";
            this.lbAqib.Size = new System.Drawing.Size(31, 13);
            this.lbAqib.TabIndex = 2;
            this.lbAqib.Text = "Aqib ";
            this.lbAqib.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // lbkcomplete
            // 
            this.lbkcomplete.AutoSize = true;
            this.lbkcomplete.Location = new System.Drawing.Point(143, 53);
            this.lbkcomplete.Name = "lbkcomplete";
            this.lbkcomplete.Size = new System.Drawing.Size(57, 13);
            this.lbkcomplete.TabIndex = 3;
            this.lbkcomplete.Text = "Completed";
            this.lbkcomplete.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbAC
            // 
            this.lbAC.AutoSize = true;
            this.lbAC.Location = new System.Drawing.Point(143, 93);
            this.lbAC.Name = "lbAC";
            this.lbAC.Size = new System.Drawing.Size(32, 13);
            this.lbAC.TabIndex = 4;
            this.lbAC.Text = "Book";
            this.lbAC.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(82, 93);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(53, 13);
            this.lbA.TabIndex = 5;
            this.lbA.Text = "10:30 AM";
            // 
            // lbTcancel
            // 
            this.lbTcancel.AutoSize = true;
            this.lbTcancel.Location = new System.Drawing.Point(143, 132);
            this.lbTcancel.Name = "lbTcancel";
            this.lbTcancel.Size = new System.Drawing.Size(40, 13);
            this.lbTcancel.TabIndex = 6;
            this.lbTcancel.Text = "Cancel";
            // 
            // lbT
            // 
            this.lbT.AutoSize = true;
            this.lbT.Location = new System.Drawing.Point(82, 132);
            this.lbT.Name = "lbT";
            this.lbT.Size = new System.Drawing.Size(35, 13);
            this.lbT.TabIndex = 7;
            this.lbT.Text = "12PM";
            this.lbT.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbTooba
            // 
            this.lbTooba.AutoSize = true;
            this.lbTooba.Location = new System.Drawing.Point(10, 132);
            this.lbTooba.Name = "lbTooba";
            this.lbTooba.Size = new System.Drawing.Size(41, 13);
            this.lbTooba.TabIndex = 8;
            this.lbTooba.Text = "Tooba ";
            this.lbTooba.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // lbTodayappointments
            // 
            this.lbTodayappointments.AutoSize = true;
            this.lbTodayappointments.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTodayappointments.Location = new System.Drawing.Point(16, 13);
            this.lbTodayappointments.Name = "lbTodayappointments";
            this.lbTodayappointments.Size = new System.Drawing.Size(156, 20);
            this.lbTodayappointments.TabIndex = 9;
            this.lbTodayappointments.Text = "Today Appointments";
            this.lbTodayappointments.Click += new System.EventHandler(this.label10_Click);
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel1);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(614, 448);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPatients.ResumeLayout(false);
            this.pnlPatients.PerformLayout();
            this.pnlDoctors.ResumeLayout(false);
            this.pnlDoctors.PerformLayout();
            this.pnlAppointments.ResumeLayout(false);
            this.pnlAppointments.PerformLayout();
            this.pnlRevenue.ResumeLayout(false);
            this.pnlRevenue.PerformLayout();
            this.pnlTodayappointments.ResumeLayout(false);
            this.pnlTodayappointments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDashboard;
        private System.Windows.Forms.Panel pnlRevenue;
        private System.Windows.Forms.Panel pnlAppointments;
        private System.Windows.Forms.Panel pnlDoctors;
        private System.Windows.Forms.Panel pnlPatients;
        private System.Windows.Forms.Label lbpatients;
        private System.Windows.Forms.Label lbpatient;
        private System.Windows.Forms.Label lbTotalpatient;
        private System.Windows.Forms.Label lbprice;
        private System.Windows.Forms.Label lbrevenues;
        private System.Windows.Forms.Label lbRevenue;
        private System.Windows.Forms.Label lbapptoday;
        private System.Windows.Forms.Label lbappointment;
        private System.Windows.Forms.Label lbAppointments;
        private System.Windows.Forms.Label lbdoctorduty;
        private System.Windows.Forms.Label lbdoctor;
        private System.Windows.Forms.Label lbDoctors;
        private System.Windows.Forms.Panel pnlTodayappointments;
        private System.Windows.Forms.Label lbk;
        private System.Windows.Forms.Label lbKaleem;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbAC;
        private System.Windows.Forms.Label lbkcomplete;
        private System.Windows.Forms.Label lbAqib;
        private System.Windows.Forms.Label lbTooba;
        private System.Windows.Forms.Label lbT;
        private System.Windows.Forms.Label lbTcancel;
        private System.Windows.Forms.Label lbTodayappointments;
    }
}
