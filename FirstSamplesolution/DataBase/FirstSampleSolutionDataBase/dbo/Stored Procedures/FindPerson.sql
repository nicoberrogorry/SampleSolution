CREATE PROCEDURE [FindPerson]
	@name					NVARCHAR(128),
	@professionId			INT = NULL,
    @cellularPhone			VARCHAR(128),
	@email					NVARCHAR(512),
	@lastName				NVARCHAR(128),
    @address				NVARCHAR(512)
AS
BEGIN
	DECLARE @namePattern NVARCHAR(150) = '%' + @name + '%',
	        @cellularPhonePattern NVARCHAR(150) = '%' + @cellularPhone + '%',
	        @emailPattern NVARCHAR(550) = '%' + @email + '%',
	        @lastNamePattern NVARCHAR(150) = '%' + @lastName + '%',
	        @addressPattern NVARCHAR(550) = '%' + @address + '%'
	SELECT *
	FROM [Persons]
	WHERE (@name = '' OR [Name] LIKE @namePattern) AND (@professionId = NULL OR [ProfessionId] = @professionId) AND (@cellularPhone = '' OR [CellularPhone] LIKE @cellularPhonePattern) AND (@email = '' OR [Email] = @emailPattern) AND (@lastName = '' OR [LastName] LIKE @lastNamePattern) AND (@address = '' OR [Address] = @addressPattern)
	OPTION (RECOMPILE)
	RETURN
END
