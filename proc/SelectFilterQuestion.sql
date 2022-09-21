create proc SelectFilterQuestion
@listquestionnumber nvarchar(300)
as
declare @myquestion nvarchar(400)
set @myquestion = 'select * from TblQuestion where QuestionID IN (' + @listquestionnumber + ')'
exec (@myquestion)
go