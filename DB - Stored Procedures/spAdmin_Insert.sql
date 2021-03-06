USE [Examination System]
GO
/****** Object:  StoredProcedure [dbo].[spAdmin_Insert]    Script Date: 15.01.2020 09:19:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



ALTER PROCEDURE [dbo].[spAdmin_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@UserName nvarchar(50),
	@Password nvarchar(50),
	@Role nvarchar(50)

	
AS
BEGIN
	
	SET NOCOUNT ON;

	insert into dbo.Users (UserName, Role)
	values (@UserName, @Role);

	insert into dbo.Admin(FirstName, LastName, UserName, Password)
	values (@FirstName, @LastName, @UserName, @Password);

   
END
