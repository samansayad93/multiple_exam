create proc EditQuestion
@questionid int ,
@groupid int ,
@questiontext nvarchar(max) ,
@case1 nvarchar(400) ,
@case2 nvarchar(400) ,
@case3 nvarchar(400) ,
@case4 nvarchar(400) ,
@answer int
as
update TblQuestion set
GroupID = @groupid ,
QuestionText = @questiontext ,
Case1 = @case1 ,
Case2 = @case2 ,
Case3 = @case3 ,
Case4 = @case4 ,
Answer = @answer
where QuestionID = @questionid
go