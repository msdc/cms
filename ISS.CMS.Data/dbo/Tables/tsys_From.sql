CREATE TABLE [dbo].[tsys_From] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Title]   VARCHAR (50)  COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [Content] VARCHAR (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    CONSTRAINT [PK_tsys_From] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (FILLFACTOR = 90)
);

