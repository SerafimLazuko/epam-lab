SELECT c.ContactName, o.OrderDate
FROM dbo.Customers c
INNER JOIN Orders o on c.CustomerID = o.CustomerID
ORDER BY o.OrderDate asc;