USE [Examination System]
GO
/****** Object:  StoredProcedure [dbo].[spExam_Insert]    Script Date: 15.01.2020 09:20:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[spExam_Insert]
	@AccessCode int,
	@Creator nvarchar(50),
	@Name nvarchar(100),
	@NumberOfQuestions int

AS
BEGIN
	
	SET NOCOUNT ON;

	insert into dbo.Exam(AccessCode, Creator, Name, NumberOfQuestions)
	values (@AccessCode, @Creator, @Name, @NumberOfQuestions);
  
END
