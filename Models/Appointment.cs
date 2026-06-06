namespace HospitalManagement.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime Slot { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
        public decimal Fee { get; set; }
    }
}
