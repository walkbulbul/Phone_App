CREATE TABLE [dbo].[Table]
(
	[First Name] VARCHAR(50) NOT NULL , 
    [Surname] NCHAR(50) NULL, 
    [Mobile] NCHAR(50) NOT NULL, 
    [Email] NCHAR(100) NULL, 
    [Catagory] NCHAR(50) NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([Mobile]) 
)
