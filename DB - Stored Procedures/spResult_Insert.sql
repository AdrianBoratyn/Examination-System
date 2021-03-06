USE [Examination System]
GO
/****** Object:  StoredProcedure [dbo].[spResult_Insert]    Script Date: 15.01.2020 09:22:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spResult_Insert]
	@ExamName nvarchar(100),
	@StudentUserName nvarchar(50),
	@Score int,
	@ExamDate nvarchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;

    insert into dbo.Result(Data, ExamName, StudentUserName, Score)
	values (@ExamDate, @ExamName, @StudentUserName, @Score);

END
