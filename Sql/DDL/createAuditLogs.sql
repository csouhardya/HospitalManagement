CREATE TABLE AuditLogs
(
    Id INT IDENTITY PRIMARY KEY,
    EntityName NVARCHAR(200),
    EntityId INT,
    ActionName NVARCHAR(100),
    CreatedOn DATETIME,
    CreatedBy INT
);