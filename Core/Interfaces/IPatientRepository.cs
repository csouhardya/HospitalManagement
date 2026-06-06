using HospitalManagement.Models;

namespace HospitalManagement.Interfaces
{
    public interface IPatientRepository
    {
        List<Patient> GetAll();
        Patient GetById(int id);
        List<Patient> Search(string searchText);
        void Add(Patient patient);
        void Update(Patient patient);
        void Delete(int id);
    }
}
