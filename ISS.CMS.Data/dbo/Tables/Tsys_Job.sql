CREATE TABLE [dbo].[Tsys_Job] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (200) NULL,
    [PostedDate]  DATETIME       CONSTRAINT [DF_Tsys_Job_PostedDate] DEFAULT (getdate()) NULL,
    [JobID]       INT            NOT NULL,
    [JobType]     NVARCHAR (100) NULL,
    [LocationID]  INT            NOT NULL,
    [Location]    NVARCHAR (100) NULL,
    [BUID]        INT            NOT NULL,
    [BU]          NVARCHAR (100) NULL,
    [EMail]       NVARCHAR (100) NULL,
    [Tel]         NVARCHAR (20)  NULL,
    [Description] NVARCHAR (MAX) NULL,
    [JobState]    BIT            CONSTRAINT [DF_Tsys_Job_State] DEFAULT ((1)) NULL,
    CONSTRAINT [PK_Tsys_Job] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Job Title', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Tsys_Job', @level2type = N'COLUMN', @level2name = N'Title';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'BU segment', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Tsys_Job', @level2type = N'COLUMN', @level2name = N'BU';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Email adress', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Tsys_Job', @level2type = N'COLUMN', @level2name = N'EMail';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Tel number', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Tsys_Job', @level2type = N'COLUMN', @level2name = N'Tel';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Job is open or not.0 is closed,1 is open', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Tsys_Job', @level2type = N'COLUMN', @level2name = N'JobState';

