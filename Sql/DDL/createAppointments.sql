CREATE TABLE Appointments
(
    Id INT IDENTITY PRIMARY KEY,
    PatientId INT,
    DoctorId INT,
    Slot DATETIME,
    Status NVARCHAR(50),
    Reason NVARCHAR(500),
    Fee DECIMAL(18,2)
);