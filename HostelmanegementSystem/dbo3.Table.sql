CREATE TABLE [dbo].[Contact]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [name] NVARCHAR(50) NULL, 
    [regNo] NVARCHAR(50) NULL, 
    [roomNo] NVARCHAR(50) NULL, 
    [message] NVARCHAR(MAX) NULL
)
