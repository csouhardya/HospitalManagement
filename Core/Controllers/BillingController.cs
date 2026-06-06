using HospitalManagement.Interfaces;
using HospitalManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BillingController : ControllerBase
    {
        private readonly IBillingService _service;

        public BillingController(IBillingService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Create(Bill bill)
        {
            return Ok(_service.CreateBill(bill));
        }

        [HttpPost("{id}/pay")]
        public IActionResult Pay(int id, decimal amount)
        {
            _service.Pay(id, amount);

            return Ok();
        }
    }
}
