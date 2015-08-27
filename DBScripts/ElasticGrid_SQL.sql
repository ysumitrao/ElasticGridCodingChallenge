--Return the names of all salespeople that have an order with George
SELECT DISTINCT sp.Name
FROM Salesperson sp
JOIN Orders o ON sp.SalespersonID = o.SalespersonID
JOIN Customer c ON o.CustomerID = c.CustomerID
WHERE c.Name='george'

--Return the names of all salespeople that do not have any order with George
SELECT DISTINCT sp.Name
FROM Orders o
JOIN Salesperson sp ON o.SalespersonID = sp.SalespersonID
WHERE o.SalespersonID NOT IN (SELECT DISTINCT oInner.SalespersonID FROM Orders oInner 
								JOIN Customer c ON oInner.CustomerID = c.CustomerID 
								WHERE c.Name = 'george')


--Return the names of salespeople that have 2 or more orders.
SELECT DISTINCT sp.Name
FROM Salesperson sp
JOIN Orders o ON sp.SalespersonID = o.SalespersonID
GROUP BY o.SalesPersonID,sp.Name
HAVING COUNT(1) > 1

--Return the name of the salesperson with the 3rd highest salary.
SELECT sp.Name, sp.Salary FROM Salesperson sp
WHERE 2 = (SELECT COUNT(1) FROM Salesperson spInner WHERE spInner.Salary > sp.Salary)

--Create a new roll­up table BigOrders(where columns are CustomerID,TotalOrderValue), and insert into that table customers whose total Amount across all orders is greater than 1000
IF OBJECT_ID('dbo.BigOrders', 'U') IS NOT NULL
  DROP TABLE dbo.BigOrders; 

CREATE TABLE BigOrders(
   CustomerID int,
   TotalOrderValue decimal(15,2)   
);

INSERT INTO BigOrders
SELECT CustomerOrders.CustomerID, CustomerOrders.TotalOrderValue FROM
(SELECT CustomerID, SUM(NumberOfUnits * CostOfUnit) AS TotalOrderValue FROM Orders o
GROUP BY CustomerID) AS CustomerOrders
WHERE CustomerOrders.TotalOrderValue > 1000

SELECT * FROM BigOrders


--Return the total Amount of orders for each month, ordered by year, then month (both in descending order)
SELECT YEAR(OrderDate) AS 'Year', MONTH(OrderDate) AS 'Month', SUM(NumberOfUnits) AS 'Number of Orders'
FROM Orders o
GROUP BY YEAR(OrderDate), MONTH(OrderDate)
ORDER BY YEAR(OrderDate) DESC, MONTH(OrderDate) DESC