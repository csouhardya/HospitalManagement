CREATE TABLE Beds
(
    Id INT IDENTITY PRIMARY KEY,
    WardName NVARCHAR(100),
    BedNumber NVARCHAR(50),
    IsOccupied BIT
);