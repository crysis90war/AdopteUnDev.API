CREATE PROCEDURE [dbo].[spAddCompetence]
	@Nom NVARCHAR(50)
AS
BEGIN
	INSERT INTO Competences
	VALUES (@Nom);
END
