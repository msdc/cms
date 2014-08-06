CREATE VIEW [dbo].[viManagerPermission]
AS
SELECT role.ID AS roleID, menu.*
FROM dbo.tsys_Role role CROSS JOIN
      dbo.tsys_Menu menu
WHERE (',' + role.PageID + ',' LIKE '%,' + CONVERT(varchar(10), menu.ID) + ',%')
