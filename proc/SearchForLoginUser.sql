create proc SearchForLoginUser
@username nvarchar(50) ,
@password nvarchar(50)
as
select * from TblUser where Username = @username AND Password = @password
go