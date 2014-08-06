CREATE TABLE [dbo].[tsys_StaticInsert] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Title]        VARCHAR (50)   COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [Content]      TEXT           COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [FileList]     VARCHAR (2000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [Encoding]     VARCHAR (50)   COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [StartElement] VARCHAR (255)  COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [EndElement]   VARCHAR (255)  COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
);

