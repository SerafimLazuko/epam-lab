SELECT Suppliers.CompanyName Supplier, Customers.CompanyName Company, Customers.City City FROM Customers
inner join Suppliers on Suppliers.City = Customers.City
AND Suppliers.Country = Customers.Country
Order By Suppliers.CompanyName