CREATE TABLE [dbo].[tsys_CommonTemplate] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [Title]    VARCHAR (50) NOT NULL,
    [Content]  TEXT         NULL,
    [Created]  DATETIME     NULL,
    [Modified] DATETIME     NULL,
    CONSTRAINT [PK_tsys_CommonTemplate] PRIMARY KEY CLUSTERED ([Id] ASC)
);

