

1.	What is SQL? What is DML? What is DDL? Recite the most important SQL commands.
2.	What is Transact-SQL (T-SQL)?
3.	Start SQL Management Studio and connect to the database TelerikAcademy. Examine the major tables in the "TelerikAcademy" database.
4.	Write a SQL query to find all information about all departments (use "TelerikAcademy" database).

SELECT * FROM Departments

5.	Write a SQL query to find all department names.

SELECT Name FROM Departments

6.	Write a SQL query to find the salary of each employee.

SELECT Salary FROM Employees

7.	Write a SQL to find the full name of each employee.

SELECT FirstName , MiddleName, LastName FROM Employees

8.	Write a SQL query to find the email addresses of each employee (by his first and last name). Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com". The produced column should be named "Full Email Addresses".

SELECT FirstName + '.' + LastName + '@telerik.com' AS "Full Email Addresses"   FROM Employees

9.	Write a SQL query to find all different employee salaries.

SELECT DISTINCT Salary FROM Employees

10.	Write a SQL query to find all information about the employees whose job title is “Sales Representative“.

SELECT * FROM Employees WHERE JobTitle = 'Sales Representative'

11.	Write a SQL query to find the names of all employees whose first name starts with "SA".

SELECT FirstName, MiddleName, LastName FROM Employees WHERE FirstName LIKE 'Sa%'

12.	Write a SQL query to find the names of all employees whose last name contains "ei".

SELECT FirstName, MiddleName, LastName FROM Employees WHERE LastName LIKE '%ei%'

13.	Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].

SELECT Salary FROM Employees WHERE Salary Between 20000 AND 30000

14.	Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.

SELECT Salary FROM Employees WHERE Salary IN (25000, 14000, 12500, 23600)

15.	Write a SQL query to find all employees that do not have manager.

SELECT * FROM Employees WHERE ManagerID IS NULL

16.	Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.

SELECT * FROM Employees WHERE Salary>=50000 ORDER BY Salary DESC

17.	Write a SQL query to find the top 5 best paid employees.

SELECT TOP (5) EmployeeID, FirstName, MiddleName, LastName, Salary  FROM Employees ORDER BY Salary DESC

18.	Write a SQL query to find all employees along with their address. Use inner join with `ON` clause.

SELECT * FROM Employees INNER JOIN Addresses ON Employees.AddressID = Addresses.AddressID

19.	Write a SQL query to find all employees and their address. Use equijoins (conditions in the `WHERE` clause).

SELECT e.FirstName, e.MiddleName, e.LastName, a.AddressText FROM Employees e, Addresses a WHERE e.AddressID = a.AddressID

20.	Write a SQL query to find all employees along with their manager.

SELECT * FROM Employees e, Employees e1 WHERE (e.ManagerID=e1.EmployeeID)

ili

SELECT e.FirstName + ' ' + e.LastName AS "Employee Full Name",
e1.FirstName + ' ' + e1.LastName AS "Manager Full Name" FROM Employees e, Employees e1 WHERE (e.ManagerID=e1.EmployeeID)

21.	Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: `Employees e`, `Employees m` and `Addresses a`.

SELECT * FROM Employees e, Employees m, Addresses a WHERE (e.ManagerID=m.EmployeeID AND e.AddressID=a. AddressID)

22.	Write a SQL query to find all departments and all town names as a single list. Use `UNION`.

SELECT a.Name FROM Departments a UNION SELECT t.Name FROM Towns t

23.	Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager. Use right outer join. Rewrite the query to use left outer join.
24.	Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.

SELECT e.FirstName, e.MiddleName, e.LastName 
	FROM Employees e 
	WHERE e.HireDate BETWEEN SMALLDATETIMEFROMPARTS(1995,1,1,12,00) AND SMALLDATETIMEFROMPARTS(2005,1,1,12,00)
	AND e.DepartmentID IN ( SELECT d.DepartmentID FROM Departments d WHERE Name='Sales' OR Name='Finance')
