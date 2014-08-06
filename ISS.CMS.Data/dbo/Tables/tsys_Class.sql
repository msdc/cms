CREATE TABLE [dbo].[tsys_Class] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Title]     VARCHAR (200) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [Title2]    VARCHAR (50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [Parent]    INT           NULL,
    [OrderID]   INT           NULL,
    [Template]  INT           NULL,
    [Directory] VARCHAR (200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [Map]       VARCHAR (500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    CONSTRAINT [PK_tsys_Class] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (FILLFACTOR = 90)
);

