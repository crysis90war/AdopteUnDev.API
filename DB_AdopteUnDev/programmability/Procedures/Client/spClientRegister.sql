CREATE PROCEDURE [dbo].[spClientRegister]
    @LastName NVARCHAR(50),
    @FirstName NVARCHAR(50),
    @Compagny NVARCHAR(50),
    @Tel NVARCHAR(50),
    @Email NVARCHAR(50),
    @Password VARCHAR(50)
AS

BEGIN
    DECLARE @passwordHash BINARY(64), @securityStamp UNIQUEIDENTIFIER;

    SET @securityStamp = NEWID()
    SET @passwordHash = dbo.fHasher (TRIM(@Password), @securityStamp)

    INSERT INTO [Clients] (LastName, FirstName, Compagny, Tel, Email, PasswordHash, SecurityStamp)
    VALUES (TRIM(@LastName), TRIM(@FirstName), TRIM(@Compagny),TRIM(@Tel),TRIM(@Email), @passwordHash, @securityStamp)
END

