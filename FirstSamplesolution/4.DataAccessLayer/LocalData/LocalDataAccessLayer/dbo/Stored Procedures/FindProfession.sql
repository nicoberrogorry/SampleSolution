CREATE PROCEDURE [FindProfession]
	@description NVARCHAR(512),
	@professionMatchedId INT OUTPUT
AS
BEGIN
	SELECT TOP 1 @professionMatchedId = [ProfessionId]
	FROM [Professions]
	WHERE ([Description] = @description)
	RETURN
END