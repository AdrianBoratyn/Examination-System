USE [Examination System]
GO
/****** Object:  StoredProcedure [dbo].[spTeacher_Insert]    Script Date: 15.01.2020 09:27:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



ALTER PROCEDURE [dbo].[spTeacher_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@UserName nvarchar(50),
	@Password nvarchar(50),
	@AcademicTitle nvarchar(50),
	@School nvarchar(50),
	@Role nvarchar(50)

	
AS
BEGIN
	
	SET NOCOUNT ON;

	insert into dbo.Users (UserName, Role)
	values (@UserName, @Role);

	insert into dbo.Teacher(FirstName, LastName, UserName, Password, AcademicTitle, School)
	values (@FirstName, @LastName, @UserName, @Password, @AcademicTitle, @School);

   
END
