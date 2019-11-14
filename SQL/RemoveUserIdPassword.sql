
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*
Pourpose: delete userid in employees table and remove values from users table for the user id
Created By: Nithin & Roneet
Date Created: 2019 - 11 - 09  
*/

ALTER PROCEDURE RemoveUserIDPassword
	@UserID nvarchar(9)
	
AS

DELETE FROM Users WHERE UserID = @UserID;
UPDATE Employees SET UserID = NEWID() WHERE UserID = @UserID;






