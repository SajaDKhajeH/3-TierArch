using System;
using System.Collections.Generic;
using ClinicManagement.Models;

namespace ClinicManagement.Data
{
    public class ClinicRepository
    {
        public List<Patient> Patients { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<Appointment> Appointments { get; set; }

        public ClinicRepository()
        {
            Patients = new List<Patient>();
            Doctors = new List<Doctor>();
            Appointments = new List<Appointment>();
            SeedData();
        }

        private void SeedData()
        {
            Doctors.Add(new Doctor { Id = 1, FirstName = "Ali", LastName = "Rezai", Specialty = "General Practitioner", MedicalLicenseCode = "DOC-1001", PhoneNumber = "09120000001" });
            Doctors.Add(new Doctor { Id = 2, FirstName = "Sara", LastName = "Ahmadi", Specialty = "Cardiology", MedicalLicenseCode = "DOC-1002", PhoneNumber = "09120000002" });

            Patients.Add(new Patient { Id = 1, FirstName = "Mohammad", LastName = "Hosseini", NationalId = "0011223344", PhoneNumber = "09350000001", Gender = "Male", BirthDate = new DateTime(1990, 5, 12), Address = "Tehran, Iran" });
            Patients.Add(new Patient { Id = 2, FirstName = "Maryam", LastName = "Karimi", NationalId = "0055667788", PhoneNumber = "09350000002", Gender = "Female", BirthDate = new DateTime(1985, 10, 25), Address = "Isfahan, Iran" });

            Appointments.Add(new Appointment { Id = 1, PatientId = 1, DoctorId = 1, AppointmentDate = DateTime.Now.AddDays(1), Status = "Scheduled", Notes = "Routine Checkup" });
        }
    }
}
