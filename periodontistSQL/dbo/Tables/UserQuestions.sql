CREATE TABLE [dbo].[UserQuestions] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (MAX) NULL,
    [Email]        NVARCHAR (MAX) NULL,
    [Theme]        NVARCHAR (MAX) NULL,
    [QuestionText] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.UserQuestions] PRIMARY KEY CLUSTERED ([Id] ASC)
);

