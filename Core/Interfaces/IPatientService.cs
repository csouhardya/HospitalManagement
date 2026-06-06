using HospitalManagement.DTOs;
using HospitalManagement.Models;

namespace HospitalManagement.Interfaces
{
    public interface IPatientService
    {
        List<Patient> GetPatients();
        Patient GetPatient(int id);
        List<Patient> Search(string searchText);
        Patient Create(CreatePatientRequest request);
        void Delete(int id);
    }
}
