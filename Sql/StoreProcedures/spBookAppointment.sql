CREATE OR ALTER PROCEDURE usp_BookAppointment
    @PatientId INT,
    @DoctorId INT,
    @Slot DATETIME,
    @Reason NVARCHAR(500)
AS
BEGIN
    IF NOT EXISTS
    (
        SELECT 1
        FROM Appointments
        WHERE DoctorId = @DoctorId
          AND Slot = @Slot
    )
    BEGIN
        INSERT INTO Appointments
        (
            PatientId,
            DoctorId,
            Slot,
            Status,
            Reason,
            Fee
        )
        VALUES
        (
            @PatientId,
            @DoctorId,
            @Slot,
            'Booked',
            @Reason,
            500
        )
    END
END
GO