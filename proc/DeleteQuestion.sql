create proc DeleteQuestion
@questionid int
as
delete from TblQuestion where QuestionID = @questionid
go