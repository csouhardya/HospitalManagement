CREATE TABLE BillItems
(
    Id INT IDENTITY PRIMARY KEY,
    BillId INT,
    ItemName NVARCHAR(200),
    Quantity INT,
    Rate DECIMAL(18,2)
);