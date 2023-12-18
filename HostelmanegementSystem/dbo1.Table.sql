CREATE TABLE [dbo].[Request]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [name] NVARCHAR(50) NULL, 
    [regNo] NVARCHAR(50) NULL, 
    [year] INT NULL, 
    [phone] NVARCHAR(50) NULL, 
    [address] NVARCHAR(50) NULL
)
