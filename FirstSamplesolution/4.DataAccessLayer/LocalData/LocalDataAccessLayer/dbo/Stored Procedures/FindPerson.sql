CREATE PROCEDURE [FindPerson]
	@name					NVARCHAR(128),
	@professionDescription  NVARCHAR(512),
    @cellularPhone			VARCHAR(128),
	@email					NVARCHAR(512),
	@lastName				NVARCHAR(128),
    @address				NVARCHAR(512)
AS
BEGIN
	DECLARE @professionId INT;
	EXECUTE FindProfession @professionDescription, @professionMatchedId = @professionId;
	SELECT [Name], [ProfessionId], [LastName], [CellularPhone], [Email], [Address]
	FROM [Persons]
	WHERE (NOT EXISTS(SELECT * FROM [Persons] WHERE [Name] = @name) OR [Name] = @name)
		  AND ([ProfessionId] = @professionId)
		  AND (NOT EXISTS(SELECT * FROM [Persons] WHERE [CellularPhone] = @cellularPhone) OR [CellularPhone] = @cellularPhone)
		  AND (NOT EXISTS(SELECT * FROM [Persons] WHERE [Email] = @email) OR [Email] = @email)
		  AND (NOT EXISTS(SELECT * FROM [Persons] WHERE [LastName] = @lastName) OR [LastName] =@lastName)
		  AND (NOT EXISTS(SELECT * FROM [Persons] WHERE [Address] = @address) OR [Address] = @address)
	RETURN
END