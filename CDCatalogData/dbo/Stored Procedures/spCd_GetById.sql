CREATE PROCEDURE [dbo].[spCd_GetById]
	@Id int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT Id, Title, Artist, DateReleased
	FROM dbo.Cd
	WHERE Id = @Id;
END
