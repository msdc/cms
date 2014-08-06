CREATE proc [dbo].[procManagerLogin]
@Name varchar (50),
@Password varchar(50),
@returnvalue varchar(50) output
as
declare @count int
begin
	set @count = (select count(*) from tsys_user where IsLock = 0 AND [name]=@Name AND [password]=@Password)
	if @count >0
	begin
		SELECT 'Login successful'
		set @returnvalue = 'Login failed'
		update tsys_user set lastlogtime = logtime where [name]=@Name
		update tsys_user set logtime = getdate() where [name]=@Name
		update tsys_user set logcount = logcount + 1 where [name]=@Name
	end
	else
	begin
		SELECT 'Login failed'
		set @returnvalue = 'Login successful'
	end
end
