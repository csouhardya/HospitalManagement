CREATE TABLE Admissions
(
    Id INT IDENTITY PRIMARY KEY,
    PatientId INT,
    BedId INT,
    AdmissionDate DATETIME,
    DischargeDate DATETIME NULL,
    Status NVARCHAR(50)
);