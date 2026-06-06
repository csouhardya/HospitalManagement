namespace HospitalManagement.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string InsuranceNumber { get; set; }
        public bool IsEmergency { get; set; }
        public bool IsDeleted { get; set; }
        public decimal OutstandingAmount { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
