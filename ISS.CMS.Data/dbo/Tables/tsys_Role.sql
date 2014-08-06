CREATE TABLE [dbo].[tsys_Role] (
    [ID]            INT             IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (50)   COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [Description]   NVARCHAR (500)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [PageID]        NVARCHAR (1000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [ClassID]       NVARCHAR (1000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [IsAllowCheck]  BIT             NULL,
    [IsAllowCreate] BIT             NULL,
    [IsAllowDel]    BIT             NULL,
    [TemplateID]    NVARCHAR (1000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    CONSTRAINT [PK_tsys_role] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90)
);

