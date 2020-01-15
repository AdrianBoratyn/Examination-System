USE [Examination System]
GO
/****** Object:  StoredProcedure [dbo].[spUser_Update]    Script Date: 15.01.2020 09:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spUser_Update]
	@UserName nvarchar(50),
	@OldUserName nvarchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;

	Update dbo.Users
	SET
	UserName = @UserName
	WHERE UserName = @OldUserName
    
END
