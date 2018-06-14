CREATE PROCEDURE [dbo].[CreatePerson]
	@name nchar,
	@profession_id int,
	@last_name nchar,
	@address nchar,
	@cellular_phone nchar
AS
BEGIN
	INSERT Persons ([Name], [ProfessionId], [CellularPhone], [LastName], [Address])
	VALUES(@name, @profession_id, @cellular_phone, @last_name, @address)
	RETURN 1
END
