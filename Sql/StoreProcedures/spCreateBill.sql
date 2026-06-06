CREATE OR ALTER PROCEDURE usp_CreateBill
    @PatientId INT,
    @DiscountAmount DECIMAL(18,2)
AS
BEGIN
    DECLARE @BillId INT;

    INSERT INTO Bills(PatientId, TotalAmount, DiscountAmount, TaxAmount, PaidAmount, Status, CreatedOn)
    VALUES(@PatientId, 0, @DiscountAmount, 0, 0, 'Unpaid', GETDATE());

    SET @BillId = SCOPE_IDENTITY();

    SELECT @BillId AS BillId;
END
GO