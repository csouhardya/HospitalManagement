namespace HospitalManagement.Models
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDiscontinued { get; set; }
        public string AllergyGroup { get; set; }
    }
}
