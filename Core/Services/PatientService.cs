using HospitalManagement.DTOs;
using HospitalManagement.Interfaces;
using HospitalManagement.Models;

namespace HospitalManagement.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _repository;

        public PatientService(IPatientRepository repository)
        {
            _repository = repository;
        }

        public List<Patient> GetPatients()
        {
            return _repository.GetAll();
        }

        public Patient GetPatient(int id)
        {
            return _repository.GetById(id);
        }

        public List<Patient> Search(string searchText)
        {
            return _repository.Search(searchText);
        }

        public Patient Create(CreatePatientRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.InsuranceNumber))
            {
                throw new Exception("Insurance number is required");
            }

            var patient = new Patient
            {
                Name = request.Name.Trim(),
                DateOfBirth = request.DateOfBirth,
                Gender = request.Gender,
                Mobile = request.Mobile,
                Email = request.Email,
                InsuranceNumber = request.InsuranceNumber,
                IsEmergency = request.IsEmergency,
                CreatedOn = DateTime.Now
            };

            _repository.Add(patient);

            return patient;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
