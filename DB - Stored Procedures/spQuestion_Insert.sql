USE [Examination System]
GO
/****** Object:  StoredProcedure [dbo].[spQuestion_Insert]    Script Date: 15.01.2020 09:21:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[spQuestion_Insert]
	@ExamName nvarchar(100),
	@Question nvarchar(1000),
	@Number int,
	@AnswerA nvarchar(1000),
	@AnswerB nvarchar(1000),
	@AnswerC nvarchar(1000),
	@AnswerD nvarchar(1000),
	@CorrectAnswer char(10)


	
AS
BEGIN
	
	SET NOCOUNT ON;

	insert into dbo.Question(ExamName, Question, Number, AnswerA, AnswerB, AnswerC, AnswerD, CorrectAnswer)
	values (@ExamName, @Question, @Number, @AnswerA, @AnswerB, @AnswerC, @AnswerD, @CorrectAnswer);

   
END
