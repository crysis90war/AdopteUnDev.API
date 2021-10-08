CREATE PROCEDURE [dbo].[spDeclineContrat]
	@Id int,
	@Statut bit
AS
BEGIN
	UPDATE [Contrats] 
	Set [Statut] = @Statut
	WHERE Id = @Id ;
END
