CREATE PROCEDURE [dbo].[spCd_GetAll]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT Id, Title, Artist, DateReleased
	FROM dbo.Cd
	ORDER BY Title;
END
