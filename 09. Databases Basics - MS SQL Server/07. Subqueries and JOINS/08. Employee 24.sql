SELECT e.EmployeeID,e.FirstName,  
IIF(p.StartDate >= '2005/01/01', NULL, p.Name) AS ProjectName
FROM Employees AS e
JOIN EmployeesProjects AS ep ON 
e.EmployeeID = ep.EmployeeID
JOIN Projects AS p ON
p.ProjectID = ep.ProjectID
WHERE ep.EmployeeID = 24 
ORDER BY e.EmployeeID ASC