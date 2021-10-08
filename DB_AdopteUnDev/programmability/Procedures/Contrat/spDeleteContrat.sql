CREATE PROCEDURE [dbo].[spDeleteContrat]
	@Id int
AS
BEGIN
	Delete From Contrats Where Id = @Id
END

