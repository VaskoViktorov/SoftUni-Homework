SELECT EmployeeID, FirstName, LastName, MiddleName, JobTitle, DepartmentID, ManagerID, HireDate, Salary, AddressID
FROM [dbo].[Employees]
ORDER BY Salary DESC, FirstName ASC, LastName DESC, MiddleName ASC