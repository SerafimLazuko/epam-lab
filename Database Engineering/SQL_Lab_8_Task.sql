ALTER Table Products
Add PriceCategory varchar(20);

UPDATE Products
SET PriceCategory = 'Cheap' 
WHERE CAST(UnitPrice AS decimal) BETWEEN 0 AND 20;

UPDATE Products
SET PriceCategory = 'Average'
WHERE CAST(UnitPrice AS decimal) BETWEEN 21 AND 40;

UPDATE Products
SET PriceCategory = 'Expensive'
WHERE CAST(UnitPrice AS decimal) > 40;

Select ProductName, UnitPrice, PriceCategory
FROM Products
Where PriceCategory = 'Cheap'
Order by UnitPrice;

Select ProductName, UnitPrice, PriceCategory
FROM Products
Where PriceCategory = 'Average'
Order by UnitPrice;

Select ProductName, UnitPrice, PriceCategory
FROM Products
Where PriceCategory = 'Expensive'
Order by UnitPrice;