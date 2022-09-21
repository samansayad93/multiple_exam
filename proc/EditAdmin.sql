create proc EditAdmin
@username nvarchar(50) ,
@password nvarchar(50)
as
update TblAdmin set Password = @password where Username = @username
go