USE [FirstSampleSolutionDataBase]

GO

INSERT INTO [dbo].[Professions]

([Description])

VALUES

	('Roofer'),
	('Carpenter'),
	('Gardener'),
	('Plumber'),
	('Electrician'),
	('Pest Control'),
	('Cleaning Service'),
	('Painter')

GO

USE [FirstSampleSolutionDataBase]

GO

INSERT INTO [dbo].[Persons]

([Name], [LastName], [ProfessionId], [CellularPhone], [Address], [Email])

VALUES

	('Senio', 'Rita', 3, '094 123 321', 'Calle Sita 2552 esq Inita', 'senio.r@email.com'),
	('Pepe', 'Epep', 5, '091 888 999', 'Collo Soto 142 esq Onoto', 'epep.p@email.com')

GO