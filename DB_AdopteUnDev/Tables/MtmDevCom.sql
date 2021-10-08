CREATE TABLE [dbo].[MtmDevCom]
(
	-- nommer une table mtm pour une many to many
	[DeveloppeurId] INT NOT NULL,
	[CompetenceId] INT NOT NULL,
	CONSTRAINT [PK_DevCom] PRIMARY KEY ([CompetenceId], [DeveloppeurId]),
	CONSTRAINT [FK_DevCom_Developpeur] FOREIGN KEY ([DeveloppeurId]) REFERENCES [Developpeurs]([Id]),
	CONSTRAINT [FK_DevCom_Competence] FOREIGN KEY ([CompetenceId]) REFERENCES [Competences]([Id])
)
