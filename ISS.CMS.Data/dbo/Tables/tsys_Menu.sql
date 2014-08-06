CREATE TABLE [dbo].[tsys_Menu] (
    [ID]           INT           IDENTITY (1, 1) NOT NULL,
    [PageName]     VARCHAR (50)  COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [PageFileDir]  VARCHAR (50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [PageTitle]    VARCHAR (50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [PageType]     VARCHAR (50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [SubPageTitle] VARCHAR (50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [Description]  VARCHAR (200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [ParentID]     INT           NOT NULL,
    [HasPage]      BIT           CONSTRAINT [DF_tsys_menu_yon] DEFAULT ((0)) NOT NULL,
    [OrderID]      INT           NULL,
    CONSTRAINT [PK_tsys_Menu] PRIMARY KEY CLUSTERED ([ID] ASC)
);

