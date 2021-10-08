CREATE PROCEDURE [dbo].[spAddContrat]
	@Intituler NVARCHAR(50),
	@Duree NVARCHAR(50),
	@Description NVARCHAR(50)

AS
BEGIN
	INSERT INTO [Contrats] ([Intituler], [Duree], [Description]) 
	VALUES (@Intituler, @Duree, @Description);
	RETURN 0
END
