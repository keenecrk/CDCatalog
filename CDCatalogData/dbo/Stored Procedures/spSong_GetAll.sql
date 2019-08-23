CREATE PROCEDURE [dbo].[spSong_GetAll]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT Song.Title AS SongTitle, Cd.Title AS CdTitle, Cd.Artist, Cd.DateReleased
	FROM dbo.Song
	INNER JOIN dbo.Cd
	ON Song.CdId = Cd.Id
	ORDER BY Song.Title;
END
