SELECT c.ContactName
FROM dbo.Customers c 
INNER JOIN Orders o on c.CustomerID = o.CustomerID
INNER JOIN [Order Details] od on o.OrderID = od.OrderID

group by c.ContactName 
Having sum(od.Quantity * od.UnitPrice) > 1000