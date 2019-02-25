SELECT ContactName, City, Region, PostalCode, Phone
FROM Customers 
WHERE Phone NOT LIKE '(%' OR Region IS NULL OR PostalCode LIKE '%[a-z]%'
ORDER BY ContactName;