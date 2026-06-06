namespace HospitalManagement.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public bool IsActive { get; set; }
        public int ConsultationDurationMinutes { get; set; }
    }
}
