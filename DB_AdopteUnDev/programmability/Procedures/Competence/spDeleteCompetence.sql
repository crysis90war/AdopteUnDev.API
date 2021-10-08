CREATE PROCEDURE [dbo].[spDeleteCompetence]
	@Id int
AS
BEGIN
	Delete From Competences Where Id = @Id
END

