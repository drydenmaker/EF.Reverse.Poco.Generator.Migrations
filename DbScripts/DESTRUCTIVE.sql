USE [Logging]
GO

IF EXISTS 
        (SELECT 
             TABLE_NAME 
         FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'logger_entries') 
DROP TABLE [dbo].[logger_entries];

IF EXISTS 
        (SELECT 
             TABLE_NAME 
         FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'logger_operations') 
DROP TABLE [dbo].[logger_operations];

IF EXISTS 
        (SELECT 
             TABLE_NAME 
         FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'logger_threads') 
DROP TABLE [dbo].[logger_threads];

IF EXISTS 
        (SELECT 
             TABLE_NAME 
         FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'logger_thread_statuses') 
DROP TABLE [dbo].[logger_thread_statuses];

IF EXISTS 
        (SELECT 
             TABLE_NAME 
         FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '__MigrationHistory') 
DROP TABLE [dbo].[__MigrationHistory];
