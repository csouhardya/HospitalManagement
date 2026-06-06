CREATE TABLE Bills
(
    Id INT IDENTITY PRIMARY KEY,
    PatientId INT,
    TotalAmount DECIMAL(18,2),
    DiscountAmount DECIMAL(18,2),
    TaxAmount DECIMAL(18,2),
    PaidAmount DECIMAL(18,2),
    Status NVARCHAR(50),
    CreatedOn DATETIME
);