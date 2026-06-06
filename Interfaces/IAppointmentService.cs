using HospitalManagement.DTOs;
using HospitalManagement.Models;

namespace HospitalManagement.Interfaces
{
    public interface IAppointmentService
    {
        Appointment Book(BookAppointmentRequest request);
        void Cancel(int id);
    }
}
