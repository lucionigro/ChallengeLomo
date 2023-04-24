CREATE PROCEDURE GetAdress
AS BEGIN
	SELECT * FROM Addresses
END


CREATE PROCEDURE [dbo].[GetPeople]
AS BEGIN
	SELECT * FROM People
END

CREATE PROCEDURE CreatePerson
(	
	
	@Name NVARCHAR(50)
	,@LastName NVARCHAR (50)
	,@Phone NVARCHAR (50)
)
AS
BEGIN
	INSERT INTO [dbo].[People]
			(
			[Name]
			,[Lastname]
			,[Phone])
		VALUES
			( 
			@Name 
			,@LastName  
			,@Phone 
			)
END

CREATE PROCEDURE CreateAdress
(	
	
	@PersonId INT
	,@Adress NVARCHAR (50)

)
AS
BEGIN
	INSERT INTO [dbo].[Addresses]
			(
			[PersonId]
			,[Address]
			)
		VALUES
			( 
			@PersonId
			,@Adress  
			)
END

CREATE PROCEDURE GetOnlyAdress
AS BEGIN
	SELECT [Address] FROM Addresses
END

CREATE PROCEDURE GetAdressPeople
AS BEGIN
	SELECT [Address],[Name],[Lastname] FROM Addresses, People
	WHERE PersonId = PeopleId; 
END

CREATE PROCEDURE GetPeopleAdress
AS BEGIN
	SELECT [PeopleId],[Name],[Lastname],[Phone],[Address] FROM People, Addresses
	Where PeopleId = PersonId;
END



