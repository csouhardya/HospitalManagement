CREATE OR ALTER PROCEDURE sp_SearchPatients
    @SearchText NVARCHAR(200)
AS
BEGIN
    SELECT *
    FROM Patients WITH (NOLOCK)
    WHERE Name LIKE '%' + @SearchText + '%'
       OR Mobile LIKE '%' + @SearchText + '%'
       OR Email LIKE '%' + @SearchText + '%'
END
GO