CREATE PROCEDURE [dbo].[spSong_GetAllByCdId]
	@CdId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT Title
	From dbo.Song
	WHERE CdId = @CdId;
END
