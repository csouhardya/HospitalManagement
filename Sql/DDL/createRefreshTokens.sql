CREATE TABLE RefreshTokens
(
    Id INT IDENTITY PRIMARY KEY,
    UserId INT,
    Token NVARCHAR(MAX),
    ExpiresOn DATETIME,
    IsRevoked BIT
);