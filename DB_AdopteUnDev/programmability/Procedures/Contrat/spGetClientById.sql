CREATE PROCEDURE [dbo].[spGetByClientId]
	@Id int
AS
BEGIN
	SELECT Id FROM [Clients] 
	WHERE Id = @Id ;
END