CREATE TABLE [dbo].[Clients]
(
    [Id] INT NOT NULL IDENTITY, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL,
    [Compagny] NVARCHAR(50) NULL,
    [Tel] NVARCHAR(50) NOT NULL,
    [Email] NVARCHAR(50) NOT NULL UNIQUE, 
    [PasswordHash] BINARY(64) NOT NULL, 
    [SecurityStamp] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT PK_Client PRIMARY KEY (Id)
)
