CREATE TABLE [dbo].[TBQuestionsAlternatives] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Letter]      VARCHAR (1)   NOT NULL,
    [IsCorret]    BIT           NOT NULL,
    [Question_Id] INT           NOT NULL,
    [Description] VARCHAR (200) NOT NULL,
    CONSTRAINT [PK_TBQuestionsAlternatives] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBQuestionsAlternatives_TBQuestions] FOREIGN KEY ([Question_Id]) REFERENCES [dbo].[TBQuestions] ([Id])
);

