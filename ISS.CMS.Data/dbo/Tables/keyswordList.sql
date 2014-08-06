CREATE TABLE [dbo].[keyswordList] (
    [id]      INT           IDENTITY (1, 1) NOT NULL,
    [name]    VARCHAR (50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [url]     VARCHAR (200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [addTime] DATETIME      NULL
);

