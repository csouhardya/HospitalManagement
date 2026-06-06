using HospitalManagement.DTOs;
using HospitalManagement.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _service;

        public AppointmentController(IAppointmentService service)
        {
            _service = service;
        }

        [HttpPost("book")]
        public IActionResult Book(BookAppointmentRequest request)
        {
            var appointment = _service.Book(request);

            return Ok(appointment);
        }

        [HttpPost("{id}/cancel")]
        public IActionResult Cancel(int id)
        {
            _service.Cancel(id);

            return Ok();
        }
    }
}
