USE [Examination System]
GO
/****** Object:  StoredProcedure [dbo].[spStudentCourses_Check]    Script Date: 15.01.2020 09:25:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[spStudentCourses_Check]
	@ExamName nvarchar(100),
	@StudentUserName nvarchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;

    select*
	from dbo.StudentCourses
	where ExamName = @ExamName and StudentUserName = @StudentUserName
	RETURN @@ROWCOUNT

END
