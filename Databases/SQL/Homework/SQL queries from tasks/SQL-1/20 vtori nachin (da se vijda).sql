SELECT e.FirstName + ' ' + e.LastName AS "Employee Full Name",
e1.FirstName + ' ' + e1.LastName AS "Manager Full Name" FROM Employees e, Employees e1 WHERE (e.ManagerID=e1.EmployeeID)