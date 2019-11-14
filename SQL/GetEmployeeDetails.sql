/*
Pourpose: delete userid in employees table and remove values from users table for the user id
Created By: Nithin & Roneet
Date Created: 2019 - 11 - 09  
*/

ALTER PROCEDURE GetEmployeeDetails
	
AS

SELECT	e.EmployeeID, 
		e.FirstName,
		e.LastName, 
		e.Email, 
		e.Phone, 
		CASE WHEN len(e.UserID) > 5 THEN 'Not Applicable'
		ELSE ut.UserTypeName
		END AS Role, 
		CASE WHEN len(e.UserID) > 5 THEN 'Not Available'
		     ELSE e.UserID
		END
			 AS UserID
FROM Employees e
LEFT OUTER JOIN Users u ON e.UserID = u.UserID
LEFT OUTER JOIN userTypes ut  ON ut.UserTypeID = u.UserTypeID
ORDER BY
FirstName,
LastName,
EmployeeID



