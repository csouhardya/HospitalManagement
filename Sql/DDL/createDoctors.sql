CREATE TABLE Doctors
(
    Id INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(200),
    Specialization NVARCHAR(100),
    IsActive BIT,
    ConsultationDurationMinutes INT
);