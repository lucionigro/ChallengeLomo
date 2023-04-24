CREATE TABLE [dbo].[People]
(
	[PeopleId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Name] NVARCHAR(50) NOT NULL, 
    [Lastname] NVARCHAR(50) NOT NULL, 
    [Phone] NVARCHAR(50) NOT NULL
)

CREATE TABLE [dbo].[Addresses]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [PersonId] INT NOT NULL, 
    [Address] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_Addresses_ToPeople] FOREIGN KEY ([PersonId]) REFERENCES [People]([PeopleId])
)
