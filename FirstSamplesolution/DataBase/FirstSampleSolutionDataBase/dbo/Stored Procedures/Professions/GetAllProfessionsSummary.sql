CREATE PROCEDURE [GetAllProfessionsSummary]

AS

BEGIN

	SELECT [PROF].[ProfessionId], [PROF].[Description]

	FROM [Professions] AS [PROF]

END