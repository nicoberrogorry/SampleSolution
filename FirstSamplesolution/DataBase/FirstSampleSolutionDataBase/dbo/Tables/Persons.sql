CREATE TABLE [dbo].[Persons] (
    [PersonId]      INT IDENTITY (1, 1) NOT NULL,
    [ProfessionId]  INT NOT NULL,
	[Name]          NVARCHAR(128) NOT NULL,
    [CellularPhone] VARCHAR(128) NOT NULL,
	[Email]			VARCHAR(256) NOT NULL,
	[LastName]      NVARCHAR(128) NOT NULL,
    [Address]       NVARCHAR(128) NOT NULL,
    CONSTRAINT [PK_Persons] PRIMARY KEY ([PersonId]), 
    CONSTRAINT [FK_Professions] FOREIGN KEY ([ProfessionId])
		REFERENCES [Professions]([ProfessionId])
);