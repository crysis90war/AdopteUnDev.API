CREATE TABLE [dbo].[Developpeurs]
(
	[Id] INT NOT NULL IDENTITY,
    [LastName] NVARCHAR(50) NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL,
    [BirthDate] DATETIME2 NOT NULL,
    [Tel] NVARCHAR(50) NOT NULL,
	[Email] NVARCHAR(50) NOT NULL UNIQUE, 
    [PasswordHash] BINARY(64) NOT NULL, 
    [SecurityStamp] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT PK_Developpeur PRIMARY KEY (Id)
    
    

)
