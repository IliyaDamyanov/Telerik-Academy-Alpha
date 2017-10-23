SELECT m.FirstName, m.LastName FROM
Employees m WHERE (SELECT COUNT(*) 
                    FROM Employees e 
                    WHERE m.EmployeeID = e.ReportsTo) > 2