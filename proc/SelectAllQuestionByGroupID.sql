create proc SelectAllQuestionByGroupID
@groupid int
as
select * from TblQuestion where GroupID = @groupid
go