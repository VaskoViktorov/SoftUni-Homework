SELECT EmployeeID, FirstName, LastName, MiddleName, JobTitle, DepartmentID, ManagerID, HireDate, Salary, AddressID
FROM [dbo].[Employees]
WHERE JobTitle = 'Sales Representative'