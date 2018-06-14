CREATE PROCEDURE [dbo].[CreatePerson]
	@name          NVARCHAR(128),
	@professionId  INT,
    @cellularPhone VARCHAR(128),
	@email		   NVARCHAR(512),
	@lastName      NVARCHAR(128),
    @address       NVARCHAR(512)
AS
BEGIN
	INSERT Persons ([Name], [ProfessionId], [CellularPhone], [LastName], [Address])
	VALUES(@name, @professionId, @cellularPhone, @lastName, @address)
	RETURN 1
END
