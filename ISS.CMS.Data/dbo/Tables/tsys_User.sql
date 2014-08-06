CREATE TABLE [dbo].[tsys_User] (
    [ID]          INT          IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [NickName]    VARCHAR (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [Password]    VARCHAR (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [RoleID]      INT          NOT NULL,
    [IsLock]      BIT          CONSTRAINT [DF_tsys_user_lock] DEFAULT ((0)) NOT NULL,
    [LogTime]     DATETIME     CONSTRAINT [DF_tsys_user_logintime] DEFAULT (getdate()) NOT NULL,
    [LastLogTime] DATETIME     CONSTRAINT [DF_tsys_user_lastlogintime] DEFAULT (getdate()) NOT NULL,
    [LogCount]    INT          CONSTRAINT [DF_tsys_user_logincount] DEFAULT ((1)) NOT NULL,
    [AddTime]     DATETIME     CONSTRAINT [DF_tsys_user_addtime] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_tsys_user] PRIMARY KEY CLUSTERED ([Name] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_tsys_user_tsys_role] FOREIGN KEY ([RoleID]) REFERENCES [dbo].[tsys_Role] ([ID]) ON UPDATE CASCADE
);

