using System;
using System.Windows.Forms;
using ClinicManagement.Data;
using ClinicManagement.Models;

namespace ClinicManagement.Forms
{
    public partial class MainForm : Form
    {
        private ClinicRepository _repository;

        public MainForm()
        {
            InitializeComponent();
            _repository = new ClinicRepository();
            LoadData();
        }

        private void LoadData()
        {
            gridPatients.DataSource = null;
            gridPatients.DataSource = _repository.Patients;

            gridDoctors.DataSource = null;
            gridDoctors.DataSource = _repository.Doctors;
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter First Name and Last Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Patient newPatient = new Patient();
            newPatient.Id = _repository.Patients.Count + 1;
            newPatient.FirstName = txtFirstName.Text;
            newPatient.LastName = txtLastName.Text;
            newPatient.NationalId = txtNationalId.Text;
            newPatient.PhoneNumber = txtPhone.Text;
            newPatient.Gender = cmbGender.SelectedItem != null ? cmbGender.SelectedItem.ToString() : "Unknown";
            newPatient.BirthDate = dtpBirthDate.Value;
            newPatient.Address = txtAddress.Text;

            _repository.Patients.Add(newPatient);
            LoadData();
            ClearForm();
            MessageBox.Show("Patient added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtNationalId.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
