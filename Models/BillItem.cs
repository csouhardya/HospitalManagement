namespace HospitalManagement.Models
{
    public class BillItem
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Rate { get; set; }
    }
}
