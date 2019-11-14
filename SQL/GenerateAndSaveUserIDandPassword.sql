
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*
Pourpose: Update userid in employees table and insert values into users table and returns the details
Created By: Nithin & Roneet
Date Created: 2019 - 11 - 09  
*/

ALTER PROCEDURE GenerateAndSaveUserIDandPassword
	@UserType numeric(4),
	@UserID nvarchar(9),
	@EmployeeID nvarchar(5),
	@Password nvarchar(20)
AS

IF @UserType != 0 
BEGIN
	BEGIN TRAN
		UPDATE Employees SET UserID = @UserID WHERE EmployeeID = @EmployeeID;
		INSERT INTO Users VALUES (@UserID, @Password, @UserType);
	COMMIT
END
SELECT u.UserID AS UserID,u.Password AS Password,u.UserTypeID AS UserTypeID,ut.UserTypeName AS UserTypeName from Users u
inner join userTypes ut on 
				u.UserTypeID = ut.UserTypeID
where u.UserID = @UserID and
		u.Password = @Password

;




