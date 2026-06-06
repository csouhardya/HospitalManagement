CREATE OR ALTER VIEW vwPatientSummary
AS
SELECT
    p.Id,
    p.Name,
    p.Mobile,
    p.Email,
    dbo.fnGetAge(p.DateOfBirth) AS Age,
    p.OutstandingAmount,
    COUNT(a.Id) AS AppointmentCount
FROM Patients p
LEFT JOIN Appointments a ON p.Id = a.PatientId
GROUP BY
    p.Id,
    p.Name,
    p.Mobile,
    p.Email,
    p.DateOfBirth,
    p.OutstandingAmount;
GO