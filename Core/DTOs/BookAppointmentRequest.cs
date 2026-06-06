namespace HospitalManagement.DTOs
{
    public class BookAppointmentRequest
    {
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime Slot { get; set; }
        public string Reason { get; set; }
    }
}
