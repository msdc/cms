CREATE VIEW [dbo].[Tsys_ADView]
AS
SELECT a.*, ac.Title AS adclasstitle
FROM dbo.Tsys_ADClass ac INNER JOIN
      dbo.Tsys_AD a ON ac.ID = a.ClassID
