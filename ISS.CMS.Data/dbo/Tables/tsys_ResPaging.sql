CREATE TABLE [dbo].[tsys_ResPaging] (
    [ID]        INT            IDENTITY (1, 1) NOT NULL,
    [ResID]     INT            NULL,
    [Title]     NVARCHAR (500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [Content]   TEXT           COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [PageIndex] INT            NULL,
    CONSTRAINT [PK_tsys_ResPaging] PRIMARY KEY CLUSTERED ([ID] ASC)
);

