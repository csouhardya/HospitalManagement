namespace HospitalManagement.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public string Status { get; set; }
        public DateTime CreatedOn { get; set; }

        public List<BillItem> Items { get; set; } = new();
    }
}
