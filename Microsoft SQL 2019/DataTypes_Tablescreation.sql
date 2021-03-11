--use master
--go

--select DB_NAME()
--go

--sp_help
--go

--select @@LANGUAGE
--go

--select @@VERSION
--go

--select GETDATE()

--sp_help spt_values

--create database testing

--use testing
--create table MemberTable(s_id int, s_name varchar(50), attendance char )
--go

create table DataTypes(

--Integers
	Emp_No INT, 
	Emp_Age SMALLINT,
	Emp_Mob BIGINT,
	Emp_desk TINYINT,
    Is_Working BIT,

--Numeric
    Emp_Sal DECIMAL,
    No_WorkingDays FLOAT,
    Mnth_WorkingDays REAL,
 
--Money
    Emp_Bonus MONEY,
    Phone_Allowance SMALLMONEY,
 
--Character
    Initial char(2),
    E_FirstName VARCHAR(100),
    E_LastName NVARCHAR(100),
 
--Large Objects
    Photo image,
 
--Date and Time
    Attendace datetime
)


select GetDate()

select * from dbo.DataTypes

CREATE TYPE AadharNumber
FROM varchar(19) NOT NULL ;

CREATE TABLE CitizenOfIndia
(
 number AadharNumber,
 CName varchar(200)
)

DROP TABLE CitizenOfIndia
DROP TYPE AadharNumber

create table Employee(
	Employee_Code int not null,
	Employee_Name Varchar(40) not null,
	Employee_DOB Datetime not null,
	Employee_EmailID varchar(20) null
)

CREATE TABLE MARKSHEET
(
    SRollNo int,
    SName Varchar(200),
    Mark1 int,
    Mark2 int,
    Marck3 int,
    --Computable Column
    AvgMark AS ((Mark1+Mark2+Marck3 )/ 3)
)

--auto increment IDENTITY (start from, increament value)
create table sales(
InvoiceId int identity(99,2),
name varchar(20)
)

--unique identifier
--newid() is for creating guid which is always unique 32bit
CREATE TABLE Customer
(
    CustomerID uniqueidentifier NOT NULL,
     CustomerName varchar(100)    
)

INSERT INTO Customer Values (NewID(),'testCustomer1') 
INSERT INTO Customer Values (NewID(),'testCustomer2') 
INSERT INTO Customer Values (NewID(),'testCustomer3') 
INSERT INTO Customer Values (NewID(),'testCustomer4') 
INSERT INTO Customer Values (NewID(),'testCustomer5') 
 
select * from Customer

--sequence is better than indentity because even if you dlt the record and then insert it will not start afresh.
--seq can be used any where inside testing
CREATE SEQUENCE IncrementEmp
start with 100
INCREMENT by 3;
 
create table myTable
(sid int, Sname varchar(15))
insert into myTable values (next value for IncrementEmp,'Adwait')
insert into myTable values (next value for IncrementEmp,'Aniket')
insert into myTable values (next value for IncrementEmp,'Kushal')
insert into myTable values (next value for IncrementEmp,'Yash')
 

select * from myTable

--delete and truncate will remove the records but the
--only difference is dlt can be rolled back, not is trucate
--truncate table tavblename

--drop table table :will dlete the entire table itself

select * from Employee
 

insert into Employee (Employee_Code ,
	Employee_Name,
	Employee_DOB ,
	Employee_EmailID) 
values (102,'poojan','2021-03-10 17:25:28.057','poojan@gmail.com')

--Update Table
--Update - keyword tableName SET (keyword) Column_Name = (Value) where Col_name = (value)
UPDATE Employee
SET Employee_EmailID = 'poojann@gmail.com'
where employee_code=102