CREATE TABLE [dbo].[TBDisciplines] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_TBDisciplines] PRIMARY KEY CLUSTERED ([Id] ASC)
);

