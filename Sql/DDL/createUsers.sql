CREATE TABLE Users
(
    Id INT IDENTITY PRIMARY KEY,
    UserName NVARCHAR(100),
    Password NVARCHAR(200),
    RoleId INT,
    IsActive BIT,
    CreatedOn DATETIME
);