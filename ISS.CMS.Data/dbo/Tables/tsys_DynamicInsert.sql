﻿CREATE TABLE [dbo].[tsys_DynamicInsert] (
    [id]              INT            IDENTITY (1, 1) NOT NULL,
    [title]           VARCHAR (100)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [Length]          INT            NULL,
    [ShortContentLen] INT            NULL,
    [TitleOut]        NVARCHAR (200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [TitleOutType]    NVARCHAR (50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [startelement]    VARCHAR (250)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [endelement]      VARCHAR (250)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [content]         VARCHAR (5000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [pagecontent]     VARCHAR (5000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [PageNumber]      INT            NULL,
    [bytime]          VARCHAR (50)   COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [bysort]          VARCHAR (50)   COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [isCommend]       BIT            CONSTRAINT [DF_tsys_DynamicInsert_isCommend] DEFAULT ((0)) NOT NULL,
    [looptime]        INT            CONSTRAINT [DF_NewInsertList_looptime] DEFAULT ((0)) NULL,
    [ispage]          BIT            NULL,
    [class]           VARCHAR (500)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [speciality]      VARCHAR (500)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [Encoding]        VARCHAR (50)   COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [filelist]        VARCHAR (2000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [NeedUpDate]      BIT            CONSTRAINT [DF_tsys_DynamicInsert_NeedUpDate] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_tsys_DynamicInsert] PRIMARY KEY CLUSTERED ([id] ASC)
);
