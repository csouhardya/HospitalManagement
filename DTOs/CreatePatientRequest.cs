namespace HospitalManagement.DTOs
{
    public class CreatePatientRequest
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string InsuranceNumber { get; set; }
        public bool IsEmergency { get; set; }
    }
}
