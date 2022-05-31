CREATE TABLE [dbo].[TBMaterias] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [Name]          VARCHAR (100) NOT NULL,
    [Grade]         VARCHAR (100) NOT NULL,
    [Bimester]      INT           NOT NULL,
    [Discipline_Id] INT           NOT NULL,
    CONSTRAINT [PK_TBMaterias] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBMaterias_TBDisciplines] FOREIGN KEY ([Discipline_Id]) REFERENCES [dbo].[TBDisciplines] ([Id])
);

