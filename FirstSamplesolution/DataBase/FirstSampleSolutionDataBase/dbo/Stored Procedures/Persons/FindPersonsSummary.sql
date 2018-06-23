CREATE PROCEDURE [FindPersonsSummary]

	@name					NVARCHAR(128) = NULL,
	@professionId			INT = NULL,
    @cellularPhone			VARCHAR(128) = NULL,
	@email					NVARCHAR(512) = NULL,
	@lastName				NVARCHAR(128) = NULL,
    @address				NVARCHAR(512) = NULL

AS

BEGIN

	SELECT [Pe].[PersonId],
		   [Pe].[Name],
		   [Pe].[LastName],
		   [Pr].[Description] AS [ProfessionDescription]

	FROM [Persons] AS [Pe]

	INNER JOIN [Professions] AS [Pr] ON ([Pe].[ProfessionId] = [Pr].[ProfessionId])

	WHERE (@name IS NULL OR [Pe].[Name] LIKE '%'+ @name +'%')
			AND
		  (@professionId IS NULL OR [Pe].[ProfessionId] = @professionId)
			AND
		  (@cellularPhone IS NULL OR [Pe].[CellularPhone] LIKE '%' + @cellularPhone + '%')
			AND
		  (@email IS NULL OR [Pe].[Email] LIKE '%' + @email + '%')
			AND
		  (@lastName IS NULL OR [Pe].[LastName] LIKE  '%' + @lastName + '%')
			AND
		  (@address IS NULL OR [Pe].[Address] LIKE '%' + @address + '%')
	
END
