

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[proc_publishnewsview]
	@speciality varchar(50)
AS
BEGIN 
	IF @speciality<>'' AND @speciality IS NOT NULL AND
			EXISTS(SELECT * FROM ISS_NEWS.dbo.tsys_NewsView WHERE Speciality=@speciality)
	BEGIN
		IF NOT EXISTS(SELECT * FROM OPENQUERY(irsql,'SELECT * FROM ISS_NEWS.dbo.tsys_NewsView') WHERE Speciality=@speciality) AND
			EXISTS(SELECT * FROM ISS_NEWS.dbo.tsys_NewsView WHERE Speciality=@speciality)
		BEGIN
			INSERT OPENQUERY(irsql,'SELECT [TemplateID]
		  ,[Title]
		  ,[TitleTab]
		  ,[Url]
		  ,[Content]
		  ,[Author]
		  ,[From]
		  ,[Count]
		  ,[KeyWord]
		  ,[Editor]
		  ,[IsCreate]
		  ,[SmallImg]
		  ,[BigImg]
		  ,[ShortContent]
		  ,[Speciality]
		  ,[IsCheck]
		  ,[IsDel]
		  ,[IsCommend]
		  ,[PageCount]
		  ,[FilePath]
		  ,[AddTime]
		  ,[UpTime]
		  ,[Field1]
		  ,[Field2]
		  ,[Field3] FROM ISS_NEWS.dbo.tsys_NewsView')
			SELECT [TemplateID]
		  ,[Title]
		  ,[TitleTab]
		  ,[Url]
		  ,[Content]
		  ,[Author]
		  ,[From]
		  ,[Count]
		  ,[KeyWord]
		  ,[Editor]
		  ,[IsCreate]
		  ,[SmallImg]
		  ,[BigImg]
		  ,[ShortContent]
		  ,[Speciality]
		  ,[IsCheck]
		  ,[IsDel]
		  ,[IsCommend]
		  ,[PageCount]
		  ,[FilePath]
		  ,[AddTime]
		  ,[UpTime]
		  ,[Field1]
		  ,[Field2]
		  ,[Field3] FROM ISS_NEWS.dbo.tsys_NewsView
		  WHERE Speciality=@speciality
		END
		ELSE
		BEGIN
			UPDATE IRSQL.ISS_NEWS.dbo.tsys_NewsView
			SET TemplateID=t2.TemplateID
				,Title=t2.Title
				,TitleTab=t2.TitleTab
				,Url=t2.Url
				,Content=t2.Content
				,Author=t2.Author
				,[From]=t2.[From]
				,[Count]=t2.[Count]
				,KeyWord=t2.KeyWord
				,Editor=t2.Editor
				,IsCreate=t2.IsCreate
				,SmallImg=t2.SmallImg
				,BigImg=t2.BigImg
				,ShortContent=t2.ShortContent
				,Speciality=t2.Speciality
				,IsCheck=t2.IsCheck
				,IsDel=t2.IsDel
				,IsCommend=t2.IsCommend
				,[PageCount]=t2.[PageCount]
				,FilePath=t2.FilePath
				,AddTime=t2.AddTime
				,UpTime=t2.UpTime
				,Field1=t2.Field1
				,Field2=t2.Field2
				,Field3=t2.Field3
			FROM IRSQL.ISS_NEWS.dbo.tsys_NewsView t1 
				INNER JOIN ISS_NEWS.dbo.tsys_NewsView t2
				ON t1.Speciality=t2.Speciality
			WHERE 	t1.Speciality=@speciality
				AND t2.Speciality=@speciality
		END
		
		IF NOT EXISTS(SELECT * FROM OPENQUERY(isswebsite,'SELECT * FROM ISS_NEWS.dbo.tsys_NewsView') WHERE Speciality=@speciality) AND
			EXISTS(SELECT * FROM ISS_NEWS.dbo.tsys_NewsView WHERE Speciality=@speciality)
		BEGIN
			INSERT OPENQUERY(isswebsite,'SELECT [TemplateID]
		  ,[Title]
		  ,[TitleTab]
		  ,[Url]
		  ,[Content]
		  ,[Author]
		  ,[From]
		  ,[Count]
		  ,[KeyWord]
		  ,[Editor]
		  ,[IsCreate]
		  ,[SmallImg]
		  ,[BigImg]
		  ,[ShortContent]
		  ,[Speciality]
		  ,[IsCheck]
		  ,[IsDel]
		  ,[IsCommend]
		  ,[PageCount]
		  ,[FilePath]
		  ,[AddTime]
		  ,[UpTime]
		  ,[Field1]
		  ,[Field2]
		  ,[Field3] FROM ISS_NEWS.dbo.tsys_NewsView')
			SELECT [TemplateID]
		  ,[Title]
		  ,[TitleTab]
		  ,[Url]
		  ,[Content]
		  ,[Author]
		  ,[From]
		  ,[Count]
		  ,[KeyWord]
		  ,[Editor]
		  ,[IsCreate]
		  ,[SmallImg]
		  ,[BigImg]
		  ,[ShortContent]
		  ,[Speciality]
		  ,[IsCheck]
		  ,[IsDel]
		  ,[IsCommend]
		  ,[PageCount]
		  ,[FilePath]
		  ,[AddTime]
		  ,[UpTime]
		  ,[Field1]
		  ,[Field2]
		  ,[Field3] FROM ISS_NEWS.dbo.tsys_NewsView
		  WHERE Speciality=@speciality
		END
		ELSE
		BEGIN
			UPDATE isswebsite.ISS_NEWS.dbo.tsys_NewsView
			SET TemplateID=t2.TemplateID
				,Title=t2.Title
				,TitleTab=t2.TitleTab
				,Url=t2.Url
				,Content=t2.Content
				,Author=t2.Author
				,[From]=t2.[From]
				,[Count]=t2.[Count]
				,KeyWord=t2.KeyWord
				,Editor=t2.Editor
				,IsCreate=t2.IsCreate
				,SmallImg=t2.SmallImg
				,BigImg=t2.BigImg
				,ShortContent=t2.ShortContent
				,Speciality=t2.Speciality
				,IsCheck=t2.IsCheck
				,IsDel=t2.IsDel
				,IsCommend=t2.IsCommend
				,[PageCount]=t2.[PageCount]
				,FilePath=t2.FilePath
				,AddTime=t2.AddTime
				,UpTime=t2.UpTime
				,Field1=t2.Field1
				,Field2=t2.Field2
				,Field3=t2.Field3
			FROM isswebsite.ISS_NEWS.dbo.tsys_NewsView t1 
				INNER JOIN ISS_NEWS.dbo.tsys_NewsView t2
				ON t1.Speciality=t2.Speciality
			WHERE 	t1.Speciality=@speciality
				AND t2.Speciality=@speciality
		END
	END
END
	


