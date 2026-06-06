using HospitalManagement.DbHelpers;
using HospitalManagement.Interfaces;
using HospitalManagement.Models;
using Dapper;

namespace HospitalManagement.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly HospitalDbContext _context;
        private readonly DapperContext _dapper;

        public PatientRepository(HospitalDbContext context, DapperContext dapper)
        {
            _context = context;
            _dapper = dapper;
        }

        public List<Patient> GetAll()
        {
            return _context.Patients
                .OrderBy(x => x.Name)
                .ToList();
        }

        public Patient GetById(int id)
        {
            return _context.Patients.First(x => x.Id == id);
        }

        public List<Patient> Search(string searchText)
        {
            using var con = _dapper.CreateConnection();

            var sql = "SELECT * FROM Patients WHERE Name LIKE '%" + searchText + "%' OR Mobile LIKE '%" + searchText + "%'";

            return con.Query<Patient>(sql).ToList();
        }

        public void Add(Patient patient)
        {
            _context.Patients.Add(patient);
            _context.SaveChanges();
        }

        public void Update(Patient patient)
        {
            _context.Patients.Update(patient);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var patient = _context.Patients.First(x => x.Id == id);

            patient.IsDeleted = true;

            _context.SaveChanges();
        }
    }
}
