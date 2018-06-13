CREATE TABLE [dbo].[Persons] (
    [PersonId]      INT        IDENTITY (1, 1) NOT NULL,
    [Name]          NCHAR (10) NOT NULL,
    [LastName]      NCHAR (10) NOT NULL,
    [Address]       NCHAR (10) NOT NULL,
    [CellularPhone] NCHAR (10) NOT NULL
);

