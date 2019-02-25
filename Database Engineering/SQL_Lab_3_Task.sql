SELECT c.ContactName
FROM dbo.Customers c
INNER JOIN Orders o on c.CustomerID = o.CustomerID
INNER JOIN [Order Details] od on od.OrderID = o.OrderID
GROUP BY c.ContactName
HAVING sum(od.UnitPrice) > 1000;