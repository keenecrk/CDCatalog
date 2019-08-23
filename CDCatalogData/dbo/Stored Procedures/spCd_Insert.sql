CREATE PROCEDURE [dbo].[spCd_Insert]
	@Title nvarchar(50),
	@Artist nvarchar(50),
	@DateReleased datetime2
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.Cd(Title, Artist, DateReleased)
	VALUES(@Title, @Artist, @DateReleased);

	SELECT CAST(SCOPE_IDENTITY() AS int);
END
