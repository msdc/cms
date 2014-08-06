CREATE    proc [dbo].[procPaging]
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
	set @sqlwhere = 'where (' + @where + ') '
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
	set @sqlwhere = 'where (' + @where + ') and '
	set @sqlwhere2 = 'where ' + @where
end
else
begin
	set @sqlwhere = 'where '
	set @sqlwhere2 = ' '
end
if(@order <> '')
begin
	set @sqlorder = ' order by ' + @order
end
else
begin
	set @sqlorder = ' '
end
set @sql = 'select top ' + str(@pagesize) + ' ' + @column + ' from ' + @tablename + ' '
	+ @sqlwhere 
	+ @primarykey + ' not in(select top ' + ltrim(str(@pagesize*(@pageindex_p-1))) + ' ' + @primarykey + ' from ' + @tablename + ' ' + @sqlwhere2 + @sqlorder +  ' )'
	+ @sqlorder
print @sql
print @pageindex_p
exec (@sql)
