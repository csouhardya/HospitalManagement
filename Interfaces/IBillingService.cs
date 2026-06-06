using HospitalManagement.Models;

namespace HospitalManagement.Interfaces
{
    public interface IBillingService
    {
        Bill CreateBill(Bill bill);
        void Pay(int billId, decimal amount);
    }
}
