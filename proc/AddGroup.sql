create proc AddGroup
@groupname nvarchar(50)
as
insert into TblGroup(GroupName) values (@groupname)
go