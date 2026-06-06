CREATE OR ALTER FUNCTION fnBillTotal(@BillId INT)
RETURNS DECIMAL(18,2)
AS
BEGIN
    DECLARE @Total DECIMAL(18,2);

    SELECT @Total = SUM(Quantity * Rate)
    FROM BillItems
    WHERE BillId = @BillId;

    RETURN ISNULL(@Total, 0);
END
GO