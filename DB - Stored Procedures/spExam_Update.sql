USE [Examination System]
GO
/****** Object:  StoredProcedure [dbo].[spExam_Update]    Script Date: 15.01.2020 09:21:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spExam_Update]
	@AccessCode int,
	@Creator nvarchar(50),
	@Name nvarchar(100),
	@NumberOfQuestions int,
	@OldName nvarchar(100)
AS
BEGIN
	
	SET NOCOUNT ON;

	
	Update dbo.Exam
	SET
	AccessCode = @AccessCode,
	Creator = @Creator,
	Name = @Name,
	NumberOfQuestions = @NumberOfQuestions
	WHERE Name = @OldName
    
END
