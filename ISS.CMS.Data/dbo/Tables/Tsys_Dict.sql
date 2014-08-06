CREATE TABLE [dbo].[Tsys_Dict] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [DictType]    NVARCHAR (50)  NOT NULL,
    [Name]        NVARCHAR (50)  NOT NULL,
    [Value]       NVARCHAR (50)  NULL,
    [Code]        NVARCHAR (20)  NULL,
    [ParentId]    INT            NOT NULL,
    [SNO]         INT            CONSTRAINT [DF_Tsys_Dict_SNO] DEFAULT ((0)) NULL,
    [Description] NVARCHAR (200) NULL,
    CONSTRAINT [PK_Tsys_ Dict] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
--ALTER TRIGGER TRG_Org
--ON Tsys_Organization
--FOR UPDATE
--AS
--IF UPDATE(Name)
--BEGIN
--	UPDATE Tsys_Job
--	SET BU=i.Name
--	FROM Tsys_Job t1,Deleted d ,Inserted i 
--	WHERE BUID=i.Id 
--END
CREATE TRIGGER TRG_Dict
ON dbo.Tsys_Dict
FOR UPDATE
AS
IF UPDATE(Name)
BEGIN
	DECLARE @type nvarchar(50)
	SET @type=(SELECT DictType FROM Inserted)
	IF @type='Job'
		BEGIN
			UPDATE Tsys_Job
			SET JobType=i.Name
			FROM Tsys_Job,Deleted d,Inserted i
			WHERE JobID=i.Id
		END
	ELSE IF @type='Location'	
		BEGIN
			UPDATE Tsys_Job
			SET Location=i.Name
			FROM Tsys_Job,Deleted d,Inserted i
			WHERE LocationID=i.Id
		END
END

GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Dict Name', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Tsys_Dict', @level2type = N'COLUMN', @level2name = N'Name';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Dict Value', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Tsys_Dict', @level2type = N'COLUMN', @level2name = N'Value';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Dict Code', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Tsys_Dict', @level2type = N'COLUMN', @level2name = N'Code';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Parent Node ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Tsys_Dict', @level2type = N'COLUMN', @level2name = N'ParentId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'serial number', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Tsys_Dict', @level2type = N'COLUMN', @level2name = N'SNO';

