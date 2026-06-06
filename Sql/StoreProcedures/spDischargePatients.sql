CREATE OR ALTER PROCEDURE usp_DischargePatient
    @AdmissionId INT,
    @DischargeDate DATETIME
AS
BEGIN
    UPDATE Admissions
    SET DischargeDate = @DischargeDate,
        Status = 'Discharged'
    WHERE Id = @AdmissionId;

    UPDATE Beds
    SET IsOccupied = 0
    WHERE Id =
    (
        SELECT BedId
        FROM Admissions
        WHERE Id = @AdmissionId
    );
END
GO