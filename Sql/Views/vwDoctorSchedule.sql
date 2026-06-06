CREATE OR ALTER VIEW vw_DoctorSchedule
AS
SELECT
    d.Id AS DoctorId,
    d.Name AS DoctorName,
    d.Specialization,
    a.Id AS AppointmentId,
    a.PatientId,
    a.Slot,
    a.Status
FROM Doctors d
LEFT JOIN Appointments a ON d.Id = a.DoctorId;
GO