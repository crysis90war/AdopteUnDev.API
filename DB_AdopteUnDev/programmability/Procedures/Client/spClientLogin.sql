CREATE PROCEDURE [dbo].[spClientLogin]
    @email NVARCHAR(50),
    @password VARCHAR(50)
AS

BEGIN
    SET NOCOUNT OFF;

    DECLARE @passwordHash BINARY(64), @securityStamp UNIQUEIDENTIFIER;

    SET @securityStamp = (SELECT SecurityStamp FROM [Clients] WHERE Email = @email)
    SET @passwordHash = dbo.fHasher(@password, @securityStamp)

    IF EXISTS (SELECT TOP 1 * FROM [Clients] WHERE Email = @email AND PasswordHash = @passwordHash)
    BEGIN
        SELECT * INTO #TempUser
        FROM [Clients]
        WHERE Email LIKE @email
        ALTER TABLE #TempUser
        DROP COLUMN PasswordHash, SecurityStamp
        SELECT * FROM #TempUser
        DROP TABLE #TempUser
    END
    ELSE
    BEGIN
        SELECT 0 AS 'State', 'Email / Password est incorrect.' AS 'Message'
    END
END