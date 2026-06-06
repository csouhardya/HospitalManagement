namespace HospitalManagement.Models
{
    public class Prescription
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime CreatedOn { get; set; }
        public List<PrescriptionMedicine> Medicines { get; set; } = new();
    }
}
