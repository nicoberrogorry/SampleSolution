IF NOT EXISTS((SELECT name FROM [master].[sys].[server_principals] WHERE name = 'Developer'))
BEGIN
	CREATE LOGIN [Developer] WITH PASSWORD = 'developer'
END
GO
USE [FirstSampleSolutionDataBase]
GO
CREATE USER [Developer] FOR LOGIN [Developer]
GO
ALTER ROLE [db_owner] ADD MEMBER [Developer]
GO