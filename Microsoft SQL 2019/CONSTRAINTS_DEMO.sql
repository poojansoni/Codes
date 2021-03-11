use testing

select * from Customer
 
sp_help Customer
 
INSERT INTO Customer (CustomerID,CustomerName)
values ('67AC874D-8089-4451-BBCA-A7A4D11DF2DF','Sonal')
 
--DEFAULT CONSTRAINT
ALTER TABLE Customer
ADD CONSTRAINT DF_cust_name DEFAULT 'POOjan'
FOR CustomerName,
CONSTRAINT DF_cust_id DEFAULT 'NUll-id' 
FOR CustomerID

 
INSERT INTO Customer(CustomerID,CustomerName) values('67AC804D-8089-4451-BBCA-A7A4D11DF2DF','rish')
go

select * from Employee;



--Check Constraint
CREATE TABLE CUSTOMER2
(
CUSTOMERID VARCHAR(5)
 CONSTRAINT CK_CUST_CustId check (CUSTOMERID LIKE '[A-Z][0-9][0-9][0-9][0-9]'),
CUSTOMERNAME VARCHAR(50)
)
 
select * from CUSTOMER2
 
Insert into CUSTOMER2 (CUSTOMERID,CUSTOMERNAME) values ('C5645','Samsung')




--primarykey  Constraint
CREATE TABLE SUPPLIER
(
    SUPPLIERID VARCHAR(5)
    CONSTRAINT PK_SUPP_ID PRIMARY KEY,
    SUPPLIERNAME VARCHAR(50)
)

SELECT * FROM SUPPLIER
INSERT INTO SUPPLIER VALUES ('S102','GANGA ELECTRONIC2')



--UNIQUE KEY will accept 1 null
CREATE TABLE PRODUCTS
(
    PRODUCTID VARCHAR(5)
    CONSTRAINT UK_PROD_PRODID UNIQUE ,
    PRODUCTNAME VARCHAR(100),
    SUPPLIERID VARCHAR(5)
)
 
SELECT * FROM PRODUCTS
 
INSERT INTO PRODUCTS VALUES ('P100','DVD2','S103')



--Foreign Key reference 

CREATE TABLE Persons
(
    PId int PRIMARY KEY,
    LastName varchar(255) NOT NULL,
    FirstName varchar(255),
    PAddress     varchar(255),
     City     varchar(255)
)

CREATE TABLE Orders
(
    OId int NOT NULL     PRIMARY KEY,
     OrderNo int NOT NULL,
     P_Id     int         
    FOREIGN KEY REFERENCES Persons(PId)
 )

--or
 
ALTER TABLE Orders
ADD FOREIGN KEY (P_Id)
REFERENCES Persons(PId)
 

SELECT * FROM Persons
 
INSERT INTO Persons VALUES (103,'VASAN','KUMAR','CHROMPET','CHENNAI')
 
SELECT * FROM Orders
 
INSERT INTO Orders VALUES (200,1234,103)





--Foreign key with on delete cascade (better)
CREATE TABLE EmpMaster
(
    EmpId INT PRIMARY KEY,
    EmpName VARCHAR(25)
); 
 
CREATE TABLE EmpDetails
(
    EmpId INT FOREIGN KEY REFERENCES EmpMaster(EmpId) 
    ON DELETE CASCADE,
    DeptId INT  PRIMARY KEY,
    DeptName VARCHAR(20)
);
 
insert into EmpMaster(EmpId,EmpName) values(1,'Kim')
insert into EmpMaster(EmpId,EmpName) values(2,'Sam')
insert into  EmpMaster(EmpId,EmpName) values(3,'John')
 
insert into EmpDetails(EmpId ,DeptId ,DeptName ) values(1,101,'AAA')
insert into EmpDetails(EmpId ,DeptId ,DeptName ) values(2,102,'AAA')
insert into EmpDetails(EmpId ,DeptId ,DeptName ) values(3,103,'CCC')
 
delete from EmpMaster where EmpId=3
 
select * from EmpMaster
select * from EmpDetails
select * from EmpDetails where EmpId=3






--declaring default outside
CREATE TABLE test_defaults
(
    keycol    smallint,
       process_id smallint     DEFAULT @@SPID,   --Preferred default definition
       date_ins       datetime     DEFAULT getdate(),   --Preferred default definition
       mathcol      smallint     DEFAULT 10 * 2,   --Preferred default definition
       char1          char(3),
       char2          char(3)     DEFAULT 'xyz' --Preferred default definition
)
GO
 

/* Illustration only, use DEFAULT definitions instead.*/
CREATE DEFAULT abc_const AS 'abc'
GO
 
sp_bindefault abc_const, 'test_defaults.char1'
GO
 
INSERT INTO test_defaults(keycol) VALUES (1)
GO
 
SELECT * FROM test_defaults
GO


--Rule
--Rule
CREATE RULE id_chk AS @id BETWEEN 0 and 10000
GO
 

sp_bindrule id_chk ,'test_defaults.keycol'

--Geometry
CREATE TABLE SpatialTable 
( 
    id         int     IDENTITY (1,1),
        GeomCol1     geometry, 
        GeomCol2     AS     GeomCol1.STAsText() 
);
GO
 
INSERT INTO SpatialTable (GeomCol1)
VALUES (geometry::STGeomFromText('LINESTRING (100 100, 20 180, 180 180)', 0));
 
INSERT INTO SpatialTable (GeomCol1)
VALUES (geometry::STGeomFromText('POLYGON ((0 0, 150 0, 150 150, 0 150, 0 0))', 0));
GO
select * from SpatialTable





--Merge similar as join but with option of when match when not match
CREATE TABLE StudentDetails
(
     StudentID         INTEGER PRIMARY KEY,
     StudentName     VARCHAR(15)
 )
 GO

INSERT INTO StudentDetails
VALUES(1,'SMITH')
INSERT INTO StudentDetails
VALUES(2,'ALLEN')
INSERT INTO StudentDetails
VALUES(3,'JONES')
INSERT INTO StudentDetails
VALUES(4,'MARTIN')
INSERT INTO StudentDetails
VALUES(5,'JAMES')
GO 
 
--StudentTotalMarks:

CREATE TABLE StudentTotalMarks
 (
     StudentID         INTEGER     REFERENCES StudentDetails,
     StudentMarks     INTEGER
 )
 GO

INSERT INTO StudentTotalMarks
VALUES(1,230)
INSERT INTO StudentTotalMarks
VALUES(2,255)
INSERT INTO StudentTotalMarks
VALUES(3,200)
GO 
 
--In our example we will consider three main conditions while we merge this two tables.
-- 1.Delete the records whose marks are more than 250.
 --2.Update marks and add 25 to each as internals if records exist.
 --3.Insert the records if record does not exists.
 
MERGE StudentTotalMarks AS stm
USING (SELECT StudentID,StudentName FROM StudentDetails) AS sd
ON stm.StudentID = sd.StudentID
WHEN MATCHED AND stm.StudentMarks > 250 
    THEN DELETE
WHEN MATCHED 
    THEN UPDATE SET stm.StudentMarks = stm.StudentMarks + 25
WHEN NOT MATCHED 
    THEN INSERT(StudentID,StudentMarks) VALUES(sd.StudentID,25);
GO 

select * from StudentDetails

select * from StudentTotalMarks



--WHERE AND ORDER BY

select * from StudentTotalMarks 
where StudentMarks > 100
order by StudentMarks


--DISTINCT 
select distinct StudentTotalMarks.StudentMarks from StudentTotalMarks


 --AND
SELECT Distinct * FROM [dbo].[Employee]
WHERE [Employee_Name] = 'Adam' 
AND [Employee_Salaray] = 700000.00
 
--OR
SELECT Distinct * FROM [dbo].[Employee]
WHERE [Employee_Name] = 'Adam' 
OR [Employee_Salaray] = 700000.00
 
--Between
SELECT Distinct * FROM [dbo].[Employee]
where [Employee_Salaray] between 500000 AND 590000
 
--IN
SELECT Distinct * FROM [dbo].[Employee]
where [Employee_Name] IN ('Yash','Sonal')
 
--NOT IN
SELECT Distinct * FROM [dbo].[Employee]
where [Employee_Name] NOT IN ('Yash','Sonal')
 
--Like
SELECT Distinct * FROM [dbo].        [Employee]
where [Employee_Name] like '%as%'
 
--Like
SELECT Distinct * FROM [dbo].[Employee]
where [Employee_Name] like 'ch%'
 
--Not Like
SELECT Distinct * FROM [dbo].[Employee]
where [Employee_Name] not like 'ch%'
 
--Exists
select * from [dbo].[Employee]
where EXISTS (select NULL )
 
--NOT Exists
select * from [dbo].[Employee]
where EXISTS (select NULL )
 
--Null
select * from [dbo].[Employee]
where Employee_Salaray is null
 
--Not Null
select * from [dbo].[Employee]
where Employee_Salaray is Not null
use master

create database ABC_Company

use ABC_Company

