create proc AddUser
@username nvarchar(50) ,
@password nvarchar(50) ,
@result int output
as
if(EXISTS (select * from TblUser where Username = @username))
set @result = 1
else
begin
set @result =0
insert into TblUser (Username , Password) values (@username , @password)
end
go
