create proc AddQuestion
@groupid int , @questiontext nvarchar(max) , @case1 nvarchar(400) , @case2 nvarchar(400) , @case3 nvarchar(400) , @case4 nvarchar(400) , @answer int
as
insert into TblQuestion(GroupID,QuestionText,Case1,Case2,Case3,Case4,Answer)
values (@groupid,@questiontext,@case1,@case2,@case3,@case4,@answer)
go