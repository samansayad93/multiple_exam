create proc EditUser
@username nvarchar(50) ,
@password nvarchar(50)
as
update TblUser set Password = @password where Username = @username
go