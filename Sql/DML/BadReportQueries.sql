SELECT *
FROM Patients
WHERE dbo.fnGetAge(DateOfBirth) > 60;

SELECT *
FROM Appointments WITH (NOLOCK)
WHERE CONVERT(VARCHAR(10), Slot, 120) = CONVERT(VARCHAR(10), GETDATE(), 120);

SELECT *
FROM Bills
WHERE YEAR(CreatedOn) = YEAR(GETDATE());

DECLARE patient_cursor CURSOR FOR
SELECT Id FROM Patients;

OPEN patient_cursor;

DECLARE @PatientId INT;

FETCH NEXT FROM patient_cursor INTO @PatientId;

WHILE @@FETCH_STATUS = 0
BEGIN
    SELECT * FROM Bills WHERE PatientId = @PatientId;

    FETCH NEXT FROM patient_cursor INTO @PatientId;
END;

CLOSE patient_cursor;
DEALLOCATE patient_cursor;