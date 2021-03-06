USE [Examination System]
GO
/****** Object:  StoredProcedure [dbo].[spStudent_Insert]    Script Date: 15.01.2020 09:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[spStudent_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@UserName nvarchar(50),
	@Password nvarchar(50),
	@Age int,
	@School nvarchar(50),
	@DegreeCourse nvarchar(50),
	@Role nvarchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;

	insert into dbo.Users (UserName, Role)
	values (@UserName, @Role);

	insert into dbo.Student (FirstName, LastName, UserName, Password, Age, School, DegreeCourse)
	values (@FirstName, @LastName, @UserName, @Password, @Age, @School, @DegreeCourse);

	
END
