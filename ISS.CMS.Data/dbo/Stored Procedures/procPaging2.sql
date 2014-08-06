CREATE proc [dbo].[procPaging2]
@tablename varchar(50),
@column varchar(500),
@primarykey varchar(20),
@pagesize int,
@pageindex int,
@where varchar(2000),
@order varchar(1000),
@datacount int output,
@pagecount int output,
@pageindex_p int output
as
declare @sql nvarchar(4000)
declare @sqlwhere varchar(2000)
declare @sqlwhere2 varchar(2000)
declare @sqlorder varchar(1000)
if(@where <> '')
begin
	set @sqlwhere = 'where ' + @where + ' '
end
else
begin 
	set @sqlwhere = ' '
end
set @sql = 'set @datacount=(select count(*) from ' + @tablename + ' ' + @sqlwhere + ')'
exec sp_executesql @sql,N'@datacount int out',@datacount out
if(@datacount % @pagesize <> 0 )
begin
	set @pagecount = @datacount / @pagesize + 1
end
else
begin
	set @pagecount = @datacount / @pagesize
end
if(@pageindex > @pagecount)
begin
	if(@pagecount = 0)
	begin
		set @pageindex_p = 1
	end
	else
	begin
		set @pageindex_p = @pagecount
	end
end
else if(@pageindex < 1)
begin
	set @pageindex_p = 1
end
else
begin
	set @pageindex_p = @pageindex
end
if(@where <> '')
begin
	set @sqlwhere = 'AND ' + @where
	set @sqlwhere2 = @where
end
else
begin
	set @sqlwhere = ''
	set @sqlwhere2 = ''
end
if(@order <> '')
begin
	set @sqlorder = ' order by ' + @order
end
else
begin
	set @sqlorder = ''
end
SET @sql = 'SELECT TOP ' + ltrim(str(@pagesize)) + ' ' + @column + ' FROM ' + @tablename + ' '
	+ 'WHERE [ID] < (SELECT MIN([ID]) FROM (SELECT TOP ' + ltrim(str(@pagesize*(@pageindex_p-1))) + ' [ID] FROM ' + @tablename + ' WHERE ' + + @sqlwhere2 + @sqlorder + ') AS t) ' + @sqlwhere + @sqlorder
print @sql
print @pageindex_p
exec (@sql)
