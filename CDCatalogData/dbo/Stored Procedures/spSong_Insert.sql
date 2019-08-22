CREATE PROCEDURE [dbo].[spSong_Insert]
	@Title nvarchar(50),
	@CdId int
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.Song(Title, CdId)
	VALUES(@Title, @CdId);
END
