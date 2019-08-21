﻿CREATE TABLE [dbo].[Cd]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(50) NOT NULL, 
    [ArtistId] INT NOT NULL, 
    [DateReleased] DATETIME2 NULL, 
    CONSTRAINT [FK_Cd_ToArtist] FOREIGN KEY (ArtistId) REFERENCES Artist(Id)
)
