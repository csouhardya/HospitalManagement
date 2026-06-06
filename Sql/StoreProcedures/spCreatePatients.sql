CREATE OR ALTER PROCEDURE sp_CreatePatient
    @Name NVARCHAR(200),
    @DateOfBirth DATETIME,
    @Gender NVARCHAR(20),
    @Mobile NVARCHAR(20),
    @Email NVARCHAR(200),
    @InsuranceNumber NVARCHAR(100),
    @IsEmergency BIT
AS
BEGIN
    INSERT INTO Patients
    (
        Name,
        DateOfBirth,
        Gender,
        Mobile,
        Email,
        InsuranceNumber,
        IsEmergency,
        IsDeleted,
        OutstandingAmount,
        CreatedOn
    )
    VALUES
    (
        @Name,
        @DateOfBirth,
        @Gender,
        @Mobile,
        @Email,
        @InsuranceNumber,
        @IsEmergency,
        0,
        0,
        GETDATE()
    )
END
GO