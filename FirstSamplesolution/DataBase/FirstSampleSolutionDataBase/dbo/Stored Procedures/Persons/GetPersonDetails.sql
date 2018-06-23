CREATE PROCEDURE [dbo].[GetPersonDetails]

	@PersonId INT

AS

BEGIN

	SELECT [PERS].[Name],
		   [PERS].[LastName],
		   [PROF].[Description],
		   [PERS].[CellularPhone],
		   [PERS].[Email],
		   [PERS].[Address]

	FROM [Persons] AS [PERS]

	LEFT JOIN [Professions] AS [PROF] ON [PERS].ProfessionId = [PROF].ProfessionId

	WHERE [PERS].[PersonId] = @PersonId

END
