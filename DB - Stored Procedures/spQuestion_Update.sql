USE [Examination System]
GO
/****** Object:  StoredProcedure [dbo].[spQuestion_Update]    Script Date: 15.01.2020 09:22:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spQuestion_Update]
	@ExamName nvarchar(100),
	@Question nvarchar(1000),
	@Number int,
	@AnswerA nvarchar(100),
	@AnswerB nvarchar(100),
	@AnswerC nvarchar(100),
	@AnswerD nvarchar(100),
	@CorrectAnswer char(10),
	@OldName nvarchar(100)
AS
BEGIN
	
	SET NOCOUNT ON;

	UPDATE dbo.Question
	SET
	ExamName = @ExamName,
	Question = @Question,
	Number = @Number,
	AnswerA = @AnswerA,
	AnswerB = @AnswerB,
	AnswerC = @AnswerC,
	AnswerD = @AnswerD,
	CorrectAnswer = @CorrectAnswer
	WHERE ExamName = @OldName AND Number = @Number
  
END
