namespace ClinicManagement.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MedicalLicenseCode { get; set; }
        public string Specialty { get; set; }
        public string PhoneNumber { get; set; }

        public string FullName { get { return "Dr. " + FirstName + " " + LastName + " (" + Specialty + ")"; } }
    }
}
