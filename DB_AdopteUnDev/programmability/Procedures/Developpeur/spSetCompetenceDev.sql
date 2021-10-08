CREATE PROCEDURE [dbo].[spSetCompetenceDev]
	@Id int,
	@Nom NVARCHAR(50)
AS
BEGIN
	UPDATE Competences
	SET Nom = @Nom
	WHERE Id = @Id
END
