EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'YourHelthContext'
GO
USE [master]
GO
ALTER DATABASE [YourHelthContext] SET  SINGLE_USER WITH ROLLBACK IMMEDIATE
GO
USE [master]
GO
/****** Object:  Database [YourHelthContext]    Script Date: 08.06.2019 20:52:08 ******/
DROP DATABASE [YourHelthContext]
GO
