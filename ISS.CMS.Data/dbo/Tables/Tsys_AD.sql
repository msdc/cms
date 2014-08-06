CREATE TABLE [dbo].[Tsys_AD] (
    [ID]      INT            IDENTITY (1, 1) NOT NULL,
    [ClassID] INT            NULL,
    [Title]   NVARCHAR (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [Url]     VARCHAR (100)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [Count]   INT            CONSTRAINT [DF_Tsys_AD_Count] DEFAULT ((0)) NULL,
    [Image]   NVARCHAR (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [OrderID] INT            NULL,
    [IsShow]  BIT            NULL,
    [AddTime] DATETIME       NULL,
    CONSTRAINT [PK_Tsys_AD] PRIMARY KEY CLUSTERED ([ID] ASC)
);

