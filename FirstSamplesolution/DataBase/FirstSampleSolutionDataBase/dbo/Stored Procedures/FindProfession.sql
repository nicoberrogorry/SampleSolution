CREATE PROCEDURE [FindProfession]
	@description NVARCHAR(512)
AS
BEGIN
	DECLARE @descriptionPattern VARCHAR(550) = '%' + @description + '%'
	SELECT *
	FROM [Professions]
	WHERE ([Description] LIKE @descriptionPattern)
	RETURN
END