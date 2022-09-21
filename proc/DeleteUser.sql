create proc DeleteUser
@username nvarchar(50)
as
delete from TblUser where Username = @username
go