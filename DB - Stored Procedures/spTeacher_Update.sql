USE [Examination System]
GO
/****** Object:  StoredProcedure [dbo].[spTeacher_Update]    Script Date: 15.01.2020 09:27:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spTeacher_Update]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@UserName nvarchar(50),
	@Password nvarchar(50),
	@AcademicTitle nvarchar(50),
	@School nvarchar(50),
	@OldUserName nvarchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;

    Update dbo.Teacher
	SET
	FirstName = @FirstName,
	LastName = @LastName,
	UserName = @UserName,
	Password = @Password,
	AcademicTitle = @AcademicTitle,
	School = @School
	WHERE UserName = @OldUserName

	

END
