CREATE PROCEDURE [dbo].[spAcceptContrat]
	@Id int,
	@Statut bit
AS
BEGIN
	UPDATE [Contrats] 
	Set [Statut] = @Statut
	WHERE Id = @Id ;
END
