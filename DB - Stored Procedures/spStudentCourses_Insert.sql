USE [Examination System]
GO
/****** Object:  StoredProcedure [dbo].[spStudentCourses_Insert]    Script Date: 15.01.2020 09:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spStudentCourses_Insert]
	@ExamName nvarchar(100),
	@ExamCreator nvarchar(50),
	@StudentUserName nvarchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;

    insert into dbo.StudentCourses (ExamName, ExamCreator, StudentUserName)
	values (@ExamName, @ExamCreator, @StudentUserName);

END
