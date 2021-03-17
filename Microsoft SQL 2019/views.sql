SELECT categoryname, description,
productname, productid
FROM CATEGORIES LEFT OUTER JOIN PRODUCTS
ON PRODUCTS.categoryid = CATEGORIES.categoryid
GO

SELECT categoryname, description,
productname, productid
FROM CATEGORIES LEFT OUTER JOIN PRODUCTS
ON PRODUCTS.categoryid = CATEGORIES.categoryid
GO
SELECT categoryname, description,
productname, productid
FROM PRODUCTS RIGHT OUTER JOIN  CATEGORIES
ON PRODUCTS.categoryid = CATEGORIES.categoryid
GO
SELECT categoryname, description,
productname, productid
FROM PRODUCTS full OUTER JOIN  CATEGORIES
ON PRODUCTS.categoryid = CATEGORIES.categoryid
GO

select * from Employees Emp JOIN Employees Mang on emp.EmployeeID = Mang.ReportsTo

--Sub Query 
SELECT EmployeeID, FirstName,LastName
FROM Employees where Region = (select Region from Employees where EmployeeID=4) 

--Sub Query Restrictions1 
SELECT EmployeeID, FirstName,LastName
FROM Employees where Region = (select Region,City from Employees where EmployeeID=4) 

--Sub Query Restrictions2 - need Having or Where 
SELECT EmployeeID, FirstName,LastName
FROM Employees group by Region Having Region = (select Region from Employees where EmployeeID=4) 

--Sub Query Restrictions3 - no group by 
SELECT EmployeeID, FirstName,LastName
FROM Employees group by Region Having EmployeeID = (select EmployeeID from Employees where city in ('','')) 

--Sub Query Restrictions4 - Go with In or Any 
SELECT EmployeeID, FirstName,LastName
FROM Employees group by Region Having EmployeeID IN (select EmployeeID from Employees where city in ('',''))

--Corrlated Sub Query 
select * from [Order Details] OD where od.ProductID IN (select ProductID from Products prod where prod.ProductID = ProductID ) 

--SELECT Clause 
SELECT
  ProductName,
  UnitPrice,
  UnitsInStock,
  (
    SELECT SUM(Quantity)
    FROM [Order Details]
    WHERE OrderID = 10248
  ) AS TotalQuantity
FROM
  [Products]
WHERE
  unitprice > 20;
 

--Join With SubQuery
SELECT productName,CategoryName,Description
FROM [dbo].[Products] prod
INNER JOIN 
(select CategoryID,CategoryName,Description from Categories) as  cat
ON prod.CategoryID = cat.CategoryID

CREATE TABLE ClustTableEmployee
(
  EmpId int,
  EmpName varchar(100)
)
 

insert into ClustTableEmployee values (4,'Test4')
Select * from ClustTableEmployee
 
CREATE CLUSTERED  INDEX NCI_EmpId
ON ClustTableEmployee(EmpID)
 
CREATE NONCLUSTERED  INDEX NCI_EmpName
ON ClustTableEmployee(EmpName)
 
CREATE NONCLUSTERED COLUMNSTORE INDEX NCCI_EmpName
ON ClustTableEmployee(EmpName)

use testing
    
CREATE VIEW VW_Employee
AS
SELECT top 10 Employee_Code,Employee_EmailID,Employee_DOB
FROM Employee


Drop view VW_Employee


select * from VW_Employee



CREATE VIEW VW_ProductSupplier

WITH ENCRYPTION

AS

select productName,CategoryName,

       Description,CompanyName,City,prod.QuantityPerUnit,prod.UnitPrice,prod.UnitsInStock

       ,Suppl.ContactName,Suppl.Phone,Suppl.Region

from [dbo].[Products] prod

INNER JOIN Categories cat

ON prod.CategoryID = cat.CategoryID

INNER JOIN Suppliers Suppl

ON prod.SupplierID = Suppl.SupplierID



