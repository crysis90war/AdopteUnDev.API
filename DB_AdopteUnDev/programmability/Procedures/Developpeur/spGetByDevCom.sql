CREATE PROCEDURE [dbo].[spGetByDevCom]
	@CompetenceId int
AS
BEGIN

	SELECT  LastName, FirstName
	FROM Developpeurs AS D
	INNER JOIN MtmDevCom AS DC ON D.Id = DeveloppeurId
	INNER JOIN Competences AS C ON C.Id = CompetenceId
	WHERE CompetenceId = @CompetenceId;

END
