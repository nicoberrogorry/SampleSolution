﻿-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE dbo.CreateProfession
	 @description  NVARCHAR(512)
AS
BEGIN
	INSERT dbo.Professions ([Description]) VALUES(@description)
	return 1
END