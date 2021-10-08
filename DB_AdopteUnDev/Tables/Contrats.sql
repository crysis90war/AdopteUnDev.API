CREATE TABLE [dbo].[Contrats]
(
	[Id] INT NOT NULL IDENTITY, 
    [Intituler] NVARCHAR(50) NOT NULL,
    [Duree] INT NOT NULL, 
    [Statut] BIT NULL, 
    [Description] NVARCHAR(50) NOT NULL,
    CONSTRAINT PK_Contrat PRIMARY KEY (Id)

	
)
