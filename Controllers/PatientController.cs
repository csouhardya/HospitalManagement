using HospitalManagement.DTOs;
using HospitalManagement.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _service;

        public PatientController(IPatientService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetPatients());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_service.GetPatient(id));
        }

        [HttpGet("search")]
        public IActionResult Search(string q)
        {
            return Ok(_service.Search(q));
        }

        [HttpPost]
        public IActionResult Create(CreatePatientRequest request)
        {
            if (request.Name.Length < 2)
            {
                return BadRequest("Invalid name");
            }

            var patient = _service.Create(request);

            return Ok(patient);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);

            return Ok();
        }
    }
}
