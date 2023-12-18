CREATE TABLE [dbo].[StudentDetailTable]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [regNo] NVARCHAR(50) NULL, 
    [firstName] NVARCHAR(50) NULL, 
    [midName] NVARCHAR(50) NULL, 
    [lastName] NVARCHAR(50) NULL, 
    [gender] NVARCHAR(50) NULL, 
    [phone] NVARCHAR(50) NULL, 
    [email] NVARCHAR(50) NULL, 
    [password] NVARCHAR(50) NULL
)
