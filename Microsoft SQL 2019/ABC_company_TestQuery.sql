--Employee Table 
--    "EmployeeId": PrimaryKey constratins
--    "EmployeeName": 
--    "LastName": 
--    "Phone": DEFAULT constratins
--    "MailId": null,
--    "Address1": null,
--    "Address2": null,
--    "Town": null,
--    "District": null,
--    "DepartmentId": CHECK constratins 'IT1234'
--    "JoiningDate": CHECK constratins greater than 2010
--    "LeavingDate": CHECK constratins Less than today 
--    "DesignationId": "DE002",
--    "IsActive": null,
--    "RoleId": null,
--    "AadharNumber": null,
--    "DrivingLicense": null,
--    "SalaryId": "S003      ",
--    "AddedBy": null,
--    "AddedOn": null,
--    "LastUpdated": null


CREATE TYPE District_Type from varchar(50)
CREATE TYPE RoleId_Type from varchar(20) 


Create TABLE Employee
(
	EmployeeId int CONSTRAINT PK_EMP_ID Primary Key,
	FirstName varchar(50),
	LastName varchar(50),
	Phone int CONSTRAINT DF_PHN default 1111111111,
	MailId varchar(30),
	Address1 varchar(100),
	Address2 varchar(100),
	Town varchar (30),
	District District_Type,
	DepartmentId varchar(6) CONSTRAINT CHK_DPT_ID check(DepartmentId LIKE '[A-Z][A-Z][0-9][0-9][0-9][0-9]'), 
	JoiningDate datetime CONSTRAINT CHK_JD check(YEAR(JoiningDate) > '2010'),
	LeavingDate datetime CONSTRAINT CHK_LD check(YEAR(LeavingDate) < YEAR(GETDATE())),
	DesignationId varchar(5) CONSTRAINT CHK_DGN_ID check(DesignationId LIKE '[A-Z][A-Z][0-9][0-9][0-9]'),
	IsActive bit,
	RoleId RoleId_Type,
	AadharNumber int,
	DrivingLicense varchar(16),
	SalaryId varchar(4) CONSTRAINT CHK_SAL_ID check(SalaryId LIKE '[A-Z][0-9][0-9][0-9]'),
	AddedBy int,
	AddedOn int,
	LastUpdated datetime
)

ALTER TABLE Employee
ALTER Column Phone varchar(10); 

--    Table Salary:
--        SalID - Itendity column
--        EID  = EmployeeId    Forgine key constratins
--        EmployeeName - 
--        Month
--        BasicAmout
--        DAAmount    
--        HRAAmount
--        PFAmout    
--        ECSDect - Create a Sequance (500 ,5)    
--        TotalSalary    
--        Dedection1
--        Dedection2
--        Bonus1 - Unique Const
--        Bonus1
--        Gross - Computable column (Basic + DA + HRA + Bonus - PF + ECS)
 
 CREATE SEQUENCE seq_esc
 START WITH 500
 INCREMENT BY 5

 Create TABLE Salary
(
	SalID int identity(1,1),
	EID int CONSTRAINT FK_EMP_ID FOREIGN KEY 
	REFERENCES Employee(EmployeeId) 
	ON DELETE CASCADE,
	--EmployeeName
	Month int CONSTRAINT CHK_MNT check(Month>0 AND Month<13),
	BasicAmount int default 0,
	DAAmount int default 0,
	HRAAmount int default 0,
	PFAmount int default 0,
	ECSDect int ,
	TotalSalary AS(BasicAmount + DAAmount + HRAAmount - PFAmount + ECSDect) ,
	Dedection1 int,
	Dedection2 int,
	Bonus int CONSTRAINT UK_BN UNIQUE ,
	Gross AS(BasicAmount + DAAmount + HRAAmount - PFAmount + ECSDect + Bonus)
) 
--1. Create tables with Constraints
--2. Create user defeind datatype for District,RollId columns
--3. Merge the table and update the employee salary who is getting less than 50000
--4. Display the Employee based on highest salary

sp_help Employee 

INSERT INTO Employee (EmployeeId, FirstName,  LastName,    Phone,       MailId,         District, DepartmentId,   JoiningDate,              LeavingDate,         DesignationId, IsActive,    RoleId, SalaryId)
VALUES (                0001,    'Poojan',    'Soni',    8888,'poojan@gmail.com',		'NAAAAA',	'IT0324', '2012-03-11 15:10:43.593', '2020-03-11 15:10:43.593', 'OO893',         1,      'ABCD',   'A678')

INSERT INTO Employee (EmployeeId, FirstName,  LastName,          MailId,         District, DepartmentId,   JoiningDate,              LeavingDate,         DesignationId, IsActive,    RoleId, SalaryId)
VALUES (                0002,    'Sonal',    'gg',			'sonal@gmail.com',	'NAAAAA',	'IT0224', '2013-03-11 15:10:43.593', '2019-03-11 15:10:43.593',		'OO993',         0,    'CDEF',  'B678')

INSERT INTO Employee (EmployeeId, FirstName,  LastName,           MailId,         District, DepartmentId,   JoiningDate,              LeavingDate,         DesignationId, IsActive,    RoleId, SalaryId)
VALUES (                0003,    'Sakshi',    'gg',			'sakshi@gmail.com',		'NAAAAA', 'IT0324', '2011-03-11 15:10:43.593', '2020-12-11 15:10:43.593',	'PO093',         1,     'IJKL',  'C678')

select * from Employee



sp_help Salary

INSERT INTO Salary (EID, Month, BasicAmount, DAAmount, HRAAmount, PFAmount,		ECSDect,        Bonus)
VALUES (            0001, 10,    500000,      30000,    20000 ,    35000,  next value for seq_esc , 45000)

INSERT INTO Salary (EID, Month, BasicAmount, DAAmount, HRAAmount, PFAmount,		ECSDect,        Bonus)
VALUES (            0002, 11,    20000,      1000,    20000 ,    5000,  next value for seq_esc , 70000)

INSERT INTO Salary (EID, Month, BasicAmount, DAAmount, HRAAmount, PFAmount,		ECSDect,        Bonus)
VALUES (            0003, 3,    10000,      3000,    35000 ,    15000,  next value for seq_esc , 65000)

select * from Salary


MERGE Salary as sal
using Employee as emp
on sal.EID = emp.EmployeeId
when MATCHED AND sal.TotalSalary < 50000
	THEN UPDATE SET sal.BasicAmount = sal.BasicAmount + 30000;

select Employee.FirstName, Employee.LastName, Salary.Gross
from Employee
Join Salary on Employee.EmployeeId = Salary.EID
Order by Salary.Gross DESC
