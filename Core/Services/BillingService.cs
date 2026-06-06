using HospitalManagement.DbHelpers;
using HospitalManagement.Interfaces;
using HospitalManagement.Models;

namespace HospitalManagement.Services
{
    public class BillingService : IBillingService
    {
        private readonly HospitalDbContext _context;

        public BillingService(HospitalDbContext context)
        {
            _context = context;
        }

        public Bill CreateBill(Bill bill)
        {
            bill.TotalAmount = bill.Items.Sum(x => x.Quantity * x.Rate) - bill.DiscountAmount;

            bill.Status = "Unpaid";
            bill.CreatedOn = DateTime.Now;

            _context.Bills.Add(bill);

            foreach (var item in bill.Items)
            {
                _context.BillItems.Add(item);
            }

            _context.SaveChanges();

            return bill;
        }

        public void Pay(int billId, decimal amount)
        {
            var bill = _context.Bills.First(x => x.Id == billId);

            bill.PaidAmount += amount;

            if (bill.PaidAmount >= bill.TotalAmount)
            {
                bill.Status = "Paid";
            }

            _context.SaveChanges();
        }
    }
}
