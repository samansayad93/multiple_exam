create proc SearchForLoginAdmin
@username nvarchar(50) , 
@password nvarchar(50)
as
select * from TblAdmin where Username = @username AND Password = @password
go