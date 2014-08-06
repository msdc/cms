CREATE TABLE [dbo].[tsys_Template] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [Title]    VARCHAR (50) NOT NULL,
    [Encoding] VARCHAR (50) NULL,
    [Content]  TEXT         NULL,
    [Created]  DATETIME     NULL,
    [Modified] DATETIME     NULL,
    CONSTRAINT [PK_tsys_Template] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (FILLFACTOR = 90)
);

