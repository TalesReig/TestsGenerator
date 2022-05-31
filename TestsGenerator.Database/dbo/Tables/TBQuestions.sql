CREATE TABLE [dbo].[TBQuestions] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Description] VARCHAR (700) NOT NULL,
    [Grade]       VARCHAR (200) NOT NULL,
    [Bimester]    INT           NOT NULL,
    [Materia_Id]  INT           NOT NULL,
    CONSTRAINT [PK_TBQuestions] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBQuestions_TBMaterias] FOREIGN KEY ([Materia_Id]) REFERENCES [dbo].[TBMaterias] ([Id])
);

