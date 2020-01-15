USE [Examination System]
GO
/****** Object:  StoredProcedure [dbo].[spQuestion_Get]    Script Date: 15.01.2020 09:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spQuestion_Get]

AS
BEGIN
	
	SET NOCOUNT ON;

    select ExamName, Question, Number, AnswerA, AnswerB, AnswerC, AnswerD, CorrectAnswer 
	from dbo.Question

END
