CREATE TABLE [dbo].[Tsys_ADClass] (
    [ID]       INT            IDENTITY (1, 1) NOT NULL,
    [Title]    NVARCHAR (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [StartTag] NVARCHAR (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [EndTag]   NVARCHAR (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [Content]  NVARCHAR (500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [PagePath] VARCHAR (100)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [Encoding] VARCHAR (50)   COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    CONSTRAINT [PK_Tsys_ADClass] PRIMARY KEY CLUSTERED ([ID] ASC)
);

