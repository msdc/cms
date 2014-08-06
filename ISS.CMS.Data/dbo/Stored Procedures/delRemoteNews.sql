-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[delRemoteNews] 
	@speciality varchar(50)
AS
BEGIN
	DELETE OPENQUERY(irsql,'SELECT * FROM ISS_NEWS.dbo.tsys_NewsView') WHERE Speciality=@speciality
	DELETE OPENQUERY(isswebsite,'SELECT * FROM ISS_NEWS.dbo.tsys_NewsView') WHERE Speciality=@speciality
END
