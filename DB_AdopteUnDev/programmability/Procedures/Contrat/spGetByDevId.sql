CREATE PROCEDURE [dbo].[spGetByDevId]
	@Id int
AS
BEGIN
	SELECT Id FROM [Developpeurs] 
	WHERE Id = @Id ;
END