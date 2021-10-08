﻿CREATE TABLE [dbo].[Competences]
(
	[Id] INT NOT NULL IDENTITY, 
    [Nom] NVARCHAR(50) NOT NULL UNIQUE,
	CONSTRAINT PK_Competence PRIMARY KEY (Id),
	CONSTRAINT UK_Competence_Name UNIQUE (Nom)
)
