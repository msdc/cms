CREATE TABLE [dbo].[tsys_Speciality] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Title]   VARCHAR (50)  COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [Explain] VARCHAR (200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [Parent]  INT           NULL
);

