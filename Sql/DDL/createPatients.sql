CREATE TABLE Patients
(
    Id INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(200),
    DateOfBirth DATETIME,
    Gender NVARCHAR(20),
    Mobile NVARCHAR(20),
    Email NVARCHAR(200),
    InsuranceNumber NVARCHAR(100),
    IsEmergency BIT,
    IsDeleted BIT,
    OutstandingAmount DECIMAL(18,2),
    CreatedOn DATETIME
);
