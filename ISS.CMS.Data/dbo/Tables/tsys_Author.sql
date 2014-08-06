CREATE TABLE [dbo].[tsys_Author] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Title]   VARCHAR (50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [Content] VARCHAR (200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [Email]   VARCHAR (50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [Sex]     CHAR (2)      COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    CONSTRAINT [PK_tsys_Authors] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (FILLFACTOR = 90)
);

