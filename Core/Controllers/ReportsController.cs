using HospitalManagement.DbHelpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportsController : ControllerBase
    {
        private readonly HospitalDbContext _context;

        public ReportsController(HospitalDbContext context)
        {
            _context = context;
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            var patients = _context.Patients.ToList();
            var appointments = _context.Appointments.ToList();
            var bills = _context.Bills.ToList();

            return Ok(new
            {
                totalPatients = patients.Count,
                totalAppointments = appointments.Count,
                revenue = bills.Sum(x => x.PaidAmount)
            });
        }
    }
}
