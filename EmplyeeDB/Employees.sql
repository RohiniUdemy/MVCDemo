CREATE TABLE [dbo].[Employees]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EmployeeId] INT NOT NULL, 
    [EmployeeName] NCHAR(50) NOT NULL, 
    [Age] INT NOT NULL, 
    [Email] NCHAR(100) NOT NULL
)
