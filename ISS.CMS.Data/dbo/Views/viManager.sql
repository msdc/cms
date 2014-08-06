CREATE VIEW [dbo].[viManager]
AS
SELECT u.Name, u.LogTime, u.LastLogTime, u.LogCount, u.AddTime, 
      r.Name AS RoleName, u.NickName, r.PageID, r.ClassID, r.IsAllowCheck, 
      r.IsAllowCreate, r.IsAllowDel, u.ID, u.IsLock, u.RoleID
FROM dbo.tsys_User u INNER JOIN
      dbo.tsys_Role r ON u.RoleID = r.ID
