CREATE PROCEDURE [CreateProfession]
	 @description  NVARCHAR(512)
AS
BEGIN
	INSERT [Professions] ([Description]) VALUES(@description)
	RETURN
END