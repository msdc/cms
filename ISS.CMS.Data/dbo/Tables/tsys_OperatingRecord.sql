CREATE TABLE [dbo].[tsys_OperatingRecord] (
    [ID]      INT            IDENTITY (1, 1) NOT NULL,
    [Manager] NVARCHAR (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [Type]    NVARCHAR (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [Content] NVARCHAR (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [AddTime] DATETIME       CONSTRAINT [DF_tsys_OperatingRecord_AddTime] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_tsys_OperatingRecord] PRIMARY KEY CLUSTERED ([ID] ASC)
);

