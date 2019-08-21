CREATE TABLE [dbo].[Artist]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [DateOfBirth] DATETIME2 NULL, 
    [DateOfDeath] DATETIME2 NULL
)
