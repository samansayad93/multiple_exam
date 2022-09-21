create proc AddAdmin
@username nvarchar(50) ,
@password nvarchar(50) ,
@result int output
as
if(EXISTS ( select * from TblAdmin where Username = @username))
set @result = 1
else
begin
set @result = 0
insert into TblAdmin (Username , Password) values (@username , @password)
end
go