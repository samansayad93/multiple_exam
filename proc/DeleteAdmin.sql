create proc DeleteAdmin
@username nvarchar(50)
as
delete from TblAdmin where Username = @username
go