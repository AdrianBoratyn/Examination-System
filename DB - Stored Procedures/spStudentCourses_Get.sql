USE [Examination System]
GO
/****** Object:  StoredProcedure [dbo].[spStudentCourses_Get]    Script Date: 15.01.2020 09:25:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spStudentCourses_Get]
AS
BEGIN
	
	SET NOCOUNT ON;

	select * 
	from dbo.StudentCourses
   
END
