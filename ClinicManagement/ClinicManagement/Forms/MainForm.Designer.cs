namespace ClinicManagement.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPatients = new System.Windows.Forms.TabPage();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtNationalId = new System.Windows.Forms.TextBox();
            this.lblNationalId = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.gridPatients = new System.Windows.Forms.DataGridView();
            this.tabDoctors = new System.Windows.Forms.TabPage();
            this.gridDoctors = new System.Windows.Forms.DataGridView();
            this.tabControlMain.SuspendLayout();
            this.tabPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPatients)).BeginInit();
            this.tabDoctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPatients);
            this.tabControlMain.Controls.Add(this.tabDoctors);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(900, 550);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPatients
            // 
            this.tabPatients.Controls.Add(this.btnAddPatient);
            this.tabPatients.Controls.Add(this.txtAddress);
            this.tabPatients.Controls.Add(this.lblAddress);
            this.tabPatients.Controls.Add(this.dtpBirthDate);
            this.tabPatients.Controls.Add(this.lblBirthDate);
            this.tabPatients.Controls.Add(this.cmbGender);
            this.tabPatients.Controls.Add(this.lblGender);
            this.tabPatients.Controls.Add(this.txtPhone);
            this.tabPatients.Controls.Add(this.lblPhone);
            this.tabPatients.Controls.Add(this.txtNationalId);
            this.tabPatients.Controls.Add(this.lblNationalId);
            this.tabPatients.Controls.Add(this.txtLastName);
            this.tabPatients.Controls.Add(this.lblLastName);
            this.tabPatients.Controls.Add(this.txtFirstName);
            this.tabPatients.Controls.Add(this.lblFirstName);
            this.tabPatients.Controls.Add(this.gridPatients);
            this.tabPatients.Location = new System.Drawing.Point(4, 25);
            this.tabPatients.Name = "tabPatients";
            this.tabPatients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatients.Size = new System.Drawing.Size(892, 521);
            this.tabPatients.TabIndex = 0;
            this.tabPatients.Text = "Patients";
            this.tabPatients.UseVisualStyleBackColor = true;
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(120, 340);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(180, 35);
            this.btnAddPatient.TabIndex = 0;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(120, 260);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(180, 60);
            this.txtAddress.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(20, 260);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 23);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address:";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(120, 220);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(180, 22);
            this.dtpBirthDate.TabIndex = 3;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.Location = new System.Drawing.Point(20, 220);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(100, 23);
            this.lblBirthDate.TabIndex = 4;
            this.lblBirthDate.Text = "Birth Date:";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(120, 180);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(180, 24);
            this.cmbGender.TabIndex = 5;
            // 
            // lblGender
            // 
            this.lblGender.Location = new System.Drawing.Point(20, 180);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(100, 23);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(120, 140);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(180, 22);
            this.txtPhone.TabIndex = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(20, 140);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(100, 23);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Phone:";
            // 
            // txtNationalId
            // 
            this.txtNationalId.Location = new System.Drawing.Point(120, 100);
            this.txtNationalId.Name = "txtNationalId";
            this.txtNationalId.Size = new System.Drawing.Size(180, 22);
            this.txtNationalId.TabIndex = 9;
            // 
            // lblNationalId
            // 
            this.lblNationalId.Location = new System.Drawing.Point(20, 100);
            this.lblNationalId.Name = "lblNationalId";
            this.lblNationalId.Size = new System.Drawing.Size(100, 23);
            this.lblNationalId.TabIndex = 10;
            this.lblNationalId.Text = "National ID:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(120, 60);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(180, 22);
            this.txtLastName.TabIndex = 11;
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(20, 60);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 23);
            this.lblLastName.TabIndex = 12;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(120, 20);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(180, 22);
            this.txtFirstName.TabIndex = 13;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(20, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(100, 23);
            this.lblFirstName.TabIndex = 14;
            this.lblFirstName.Text = "First Name:";
            // 
            // gridPatients
            // 
            this.gridPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPatients.Location = new System.Drawing.Point(320, 20);
            this.gridPatients.Name = "gridPatients";
            this.gridPatients.RowHeadersWidth = 51;
            this.gridPatients.Size = new System.Drawing.Size(550, 470);
            this.gridPatients.TabIndex = 0;
            // 
            // tabDoctors
            // 
            this.tabDoctors.Controls.Add(this.gridDoctors);
            this.tabDoctors.Location = new System.Drawing.Point(4, 25);
            this.tabDoctors.Name = "tabDoctors";
            this.tabDoctors.Size = new System.Drawing.Size(892, 521);
            this.tabDoctors.TabIndex = 1;
            this.tabDoctors.Text = "Doctors";
            // 
            // gridDoctors
            // 
            this.gridDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDoctors.Location = new System.Drawing.Point(0, 0);
            this.gridDoctors.Name = "gridDoctors";
            this.gridDoctors.RowHeadersWidth = 51;
            this.gridDoctors.Size = new System.Drawing.Size(892, 521);
            this.gridDoctors.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinic Management System (.NET Framework 4.8)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPatients.ResumeLayout(false);
            this.tabPatients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPatients)).EndInit();
            this.tabDoctors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDoctors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPatients;
        private System.Windows.Forms.TabPage tabDoctors;
        private System.Windows.Forms.DataGridView gridPatients;
        private System.Windows.Forms.DataGridView gridDoctors;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblNationalId;
        private System.Windows.Forms.TextBox txtNationalId;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAddPatient;
    }
}
