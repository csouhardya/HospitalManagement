CREATE TABLE Prescriptions
(
    Id INT IDENTITY PRIMARY KEY,
    PatientId INT,
    DoctorId INT,
    CreatedOn DATETIME
);