namespace MediCore.WindowsApp.Forms
{
    partial class PatientForm
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
            this.pnlPatientform = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tlppatientform = new System.Windows.Forms.TableLayoutPanel();
            this.cbxBloodgroup = new System.Windows.Forms.ComboBox();
            this.tbxContact = new System.Windows.Forms.TextBox();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lbAge = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbContact = new System.Windows.Forms.Label();
            this.lbBlood = new System.Windows.Forms.Label();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.pnlPatientform.SuspendLayout();
            this.tlppatientform.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPatientform
            // 
            this.pnlPatientform.Controls.Add(this.btnSave);
            this.pnlPatientform.Controls.Add(this.btnCancel);
            this.pnlPatientform.Controls.Add(this.tlppatientform);
            this.pnlPatientform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPatientform.Location = new System.Drawing.Point(0, 0);
            this.pnlPatientform.Name = "pnlPatientform";
            this.pnlPatientform.Size = new System.Drawing.Size(557, 344);
            this.pnlPatientform.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(434, 298);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 36);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(338, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 36);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tlppatientform
            // 
            this.tlppatientform.ColumnCount = 2;
            this.tlppatientform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tlppatientform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tlppatientform.Controls.Add(this.cbxBloodgroup, 1, 5);
            this.tlppatientform.Controls.Add(this.tbxContact, 1, 4);
            this.tlppatientform.Controls.Add(this.tbxAge, 1, 2);
            this.tlppatientform.Controls.Add(this.tbxName, 1, 1);
            this.tlppatientform.Controls.Add(this.lbAge, 0, 2);
            this.tlppatientform.Controls.Add(this.label1, 0, 0);
            this.tlppatientform.Controls.Add(this.lbName, 0, 1);
            this.tlppatientform.Controls.Add(this.lbGender, 0, 3);
            this.tlppatientform.Controls.Add(this.lbContact, 0, 4);
            this.tlppatientform.Controls.Add(this.lbBlood, 0, 5);
            this.tlppatientform.Controls.Add(this.tbxID, 1, 0);
            this.tlppatientform.Controls.Add(this.cbxGender, 1, 3);
            this.tlppatientform.Location = new System.Drawing.Point(3, 3);
            this.tlppatientform.Name = "tlppatientform";
            this.tlppatientform.RowCount = 6;
            this.tlppatientform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlppatientform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlppatientform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlppatientform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlppatientform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlppatientform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlppatientform.Size = new System.Drawing.Size(551, 272);
            this.tlppatientform.TabIndex = 0;
            // 
            // cbxBloodgroup
            // 
            this.cbxBloodgroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxBloodgroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBloodgroup.FormattingEnabled = true;
            this.cbxBloodgroup.Items.AddRange(new object[] {
            "A+",
            "AB+",
            "AB-",
            "B+",
            "B-",
            "O+",
            "O-"});
            this.cbxBloodgroup.Location = new System.Drawing.Point(160, 228);
            this.cbxBloodgroup.Name = "cbxBloodgroup";
            this.cbxBloodgroup.Size = new System.Drawing.Size(388, 25);
            this.cbxBloodgroup.TabIndex = 12;
            // 
            // tbxContact
            // 
            this.tbxContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxContact.Location = new System.Drawing.Point(160, 183);
            this.tbxContact.Name = "tbxContact";
            this.tbxContact.Size = new System.Drawing.Size(388, 25);
            this.tbxContact.TabIndex = 10;
            // 
            // tbxAge
            // 
            this.tbxAge.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxAge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAge.Location = new System.Drawing.Point(160, 93);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(388, 25);
            this.tbxAge.TabIndex = 8;
            // 
            // tbxName
            // 
            this.tbxName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(160, 48);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(388, 25);
            this.tbxName.TabIndex = 7;
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(3, 90);
            this.lbAge.Name = "lbAge";
            this.lbAge.Padding = new System.Windows.Forms.Padding(50, 10, 10, 10);
            this.lbAge.Size = new System.Drawing.Size(86, 33);
            this.lbAge.TabIndex = 4;
            this.lbAge.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(50, 10, 10, 10);
            this.label1.Size = new System.Drawing.Size(80, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(3, 45);
            this.lbName.Name = "lbName";
            this.lbName.Padding = new System.Windows.Forms.Padding(50, 10, 10, 10);
            this.lbName.Size = new System.Drawing.Size(95, 33);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(3, 135);
            this.lbGender.Name = "lbGender";
            this.lbGender.Padding = new System.Windows.Forms.Padding(50, 10, 10, 10);
            this.lbGender.Size = new System.Drawing.Size(102, 33);
            this.lbGender.TabIndex = 2;
            this.lbGender.Text = "Gender";
            // 
            // lbContact
            // 
            this.lbContact.AutoSize = true;
            this.lbContact.Location = new System.Drawing.Point(3, 180);
            this.lbContact.Name = "lbContact";
            this.lbContact.Padding = new System.Windows.Forms.Padding(50, 10, 10, 10);
            this.lbContact.Size = new System.Drawing.Size(104, 33);
            this.lbContact.TabIndex = 3;
            this.lbContact.Text = "Contact";
            // 
            // lbBlood
            // 
            this.lbBlood.AutoSize = true;
            this.lbBlood.Location = new System.Drawing.Point(3, 225);
            this.lbBlood.Name = "lbBlood";
            this.lbBlood.Padding = new System.Windows.Forms.Padding(50, 10, 10, 10);
            this.lbBlood.Size = new System.Drawing.Size(126, 33);
            this.lbBlood.TabIndex = 5;
            this.lbBlood.Text = "Blood Group";
            // 
            // tbxID
            // 
            this.tbxID.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxID.Location = new System.Drawing.Point(160, 3);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(388, 25);
            this.tbxID.TabIndex = 6;
            // 
            // cbxGender
            // 
            this.cbxGender.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Trans",
            "Other"});
            this.cbxGender.Location = new System.Drawing.Point(160, 138);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(388, 25);
            this.cbxGender.TabIndex = 11;
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 344);
            this.Controls.Add(this.pnlPatientform);
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.pnlPatientform.ResumeLayout(false);
            this.tlppatientform.ResumeLayout(false);
            this.tlppatientform.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPatientform;
        private System.Windows.Forms.TableLayoutPanel tlppatientform;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbContact;
        private System.Windows.Forms.Label lbBlood;
        private System.Windows.Forms.TextBox tbxContact;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.ComboBox cbxBloodgroup;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}