CREATE TABLE PrescriptionMedicines
(
    Id INT IDENTITY PRIMARY KEY,
    PrescriptionId INT,
    MedicineId INT,
    Dosage NVARCHAR(100),
    Days INT
);