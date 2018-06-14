CREATE TABLE [dbo].[Professions] (
    [ProfessionId] INT         IDENTITY (1, 1) NOT NULL,
    [Description]  NVARCHAR(512) NULL, 
    CONSTRAINT [PK_Professions] PRIMARY KEY ([ProfessionId])
);

