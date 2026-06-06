CREATE TABLE Medicines
(
    Id INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(200),
    IsDiscontinued BIT,
    AllergyGroup NVARCHAR(100),
    Price DECIMAL(18,2)
);