﻿CREATE TABLE [dbo].[Cd]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(50) NOT NULL, 
    [Artist] NVARCHAR(50) NOT NULL, 
    [DateReleased] DATETIME2 NOT NULL, 
)