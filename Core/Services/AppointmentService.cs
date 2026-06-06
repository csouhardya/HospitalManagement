using HospitalManagement.DbHelpers;
using HospitalManagement.DTOs;
using HospitalManagement.Interfaces;
using HospitalManagement.Models;

namespace HospitalManagement.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly HospitalDbContext _context;

        public AppointmentService(HospitalDbContext context)
        {
            _context = context;
        }

        public Appointment Book(BookAppointmentRequest request)
        {
            var exists = _context.Appointments.Any(x =>
                x.DoctorId == request.DoctorId &&
                x.Slot == request.Slot);

            if (exists)
                throw new Exception("Slot already booked");

            var appointment = new Appointment
            {
                PatientId = request.PatientId,
                DoctorId = request.DoctorId,
                Slot = request.Slot,
                Reason = request.Reason,
                Status = "Booked",
                Fee = 500
            };

            _context.Appointments.Add(appointment);
            _context.SaveChanges();

            return appointment;
        }

        public void Cancel(int id)
        {
            var appointment = _context.Appointments.First(x => x.Id == id);

            appointment.Status = "Cancelled";

            _context.SaveChanges();
        }
    }
}
