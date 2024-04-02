CREATE TABLE [dbo].[Users]
(
	[Id] INT IDENTITY(1, 1) NOT NULL PRIMARY KEY, 
    [Username] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL,
    [FirstName] NVARCHAR(200) NOT NULL,
    [LastName] NVARCHAR(200) NULL,
    [Address] NVARCHAR(200) NOT NULL, 
    [Role] NVARCHAR(100) NOT NULL, 
    [Telephone] NVARCHAR(50) NULL,
    [CreatedAt] DATETIME NOT NULL DEFAULT GETDATE(), 
    [UpdatedAt] DATETIME NULL, 
    CONSTRAINT UC_Users_Username UNIQUE (Username),
    CONSTRAINT UC_Users_Email UNIQUE (Email)
)
