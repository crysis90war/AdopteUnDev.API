CREATE PROCEDURE [dbo].[spDeveloppeurRegister]

    @LastName NVARCHAR(50), 
    @FirstName NVARCHAR(50),
    @BirthDate DATETIME2,
    @Tel NVARCHAR(50),
    @Email NVARCHAR(50),
    @Password VARCHAR(50)

AS

BEGIN
    DECLARE @passwordHash BINARY(64), @securityStamp UNIQUEIDENTIFIER;

    SET @securityStamp = NEWID()
    SET @passwordHash = dbo.fHasher (TRIM(@password), @securityStamp)

    INSERT INTO [Developpeurs] (LastName, FirstName, BirthDate, Tel, Email, PasswordHash, SecurityStamp)
    VALUES (TRIM(@LastName), TRIM(@FirstName), @BirthDate, TRIM(@Tel), TRIM(@Email), @passwordHash, @securityStamp)
END