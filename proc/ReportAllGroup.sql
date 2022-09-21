create proc ReportAllQuestion
as
select GroupName,TblQuestion.GroupID,QuestionText,Case1,Case2,Case3,Case4,Answer  from TblQuestion
inner join TblGroup on TblQuestion.GroupID = TblGroup.GroupID
go