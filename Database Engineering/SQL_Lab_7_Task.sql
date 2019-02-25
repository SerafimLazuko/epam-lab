SELECT CategoryName, COUNT(UnitsInStock) as [In Stock], SUM(p.UnitPrice) as Price
FROM Products p
INNER JOIN Categories c ON p.CategoryID = c.CategoryID
GROUP BY c.CategoryName
ORDER BY SUM(p.UnitPrice) asc;