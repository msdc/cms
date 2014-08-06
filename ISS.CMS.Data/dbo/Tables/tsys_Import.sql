CREATE TABLE [dbo].[tsys_Import] (
    [ID]       INT           IDENTITY (1, 1) NOT NULL,
    [Title]    VARCHAR (50)  COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [Url]      VARCHAR (250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [OpenFlag] INT           CONSTRAINT [DF_tsys_Import_openflag] DEFAULT ((1)) NOT NULL,
    [IsDel]    INT           CONSTRAINT [DF_tsys_Import_isdel] DEFAULT ((1)) NOT NULL,
    [AddTime]  DATETIME      CONSTRAINT [DF_tsys_Import_addtime] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_Tsys_Import] PRIMARY KEY CLUSTERED ([ID] ASC)
);

