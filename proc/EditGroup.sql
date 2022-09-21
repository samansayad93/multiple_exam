create proc EditGroup
@groupid int , @groupname nvarchar(50)
as
update TblGroup set GroupName = @groupname where GroupID = @groupid
go