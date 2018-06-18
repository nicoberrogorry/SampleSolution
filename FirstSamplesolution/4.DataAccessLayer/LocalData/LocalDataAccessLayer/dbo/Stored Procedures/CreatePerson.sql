CREATE PROCEDURE [CreatePerson]
	@name          NVARCHAR(128),
	@professionId  INT,
    @cellularPhone VARCHAR(128),
	@email		   NVARCHAR(512),
	@lastName      NVARCHAR(128),
    @address       NVARCHAR(512)
AS
BEGIN
	INSERT INTO [Persons] ([Name], [ProfessionId], [CellularPhone], [LastName], [Address])
	VALUES(@name, @professionId, @cellularPhone, @lastName, @address)
	RETURN
END
