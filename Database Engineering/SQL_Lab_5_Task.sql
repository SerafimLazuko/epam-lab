SELECT c.ContactName, o.OrderDate, od.Quantity
FROM dbo.Customers c
INNER JOIN Orders o on c.CustomerID = o.CustomerID
INNER JOIN [Order Details] od on o.OrderID = od.OrderID
ORDER BY o.OrderDate asc,od.Quantity asc,  c.ContactName;