
Use Northwind

Go 
CREATE PROCEDURE dbo.GetEmployeeWithTerr

AS

BEGIN

    SELECT emp.EmployeeID,FirstName,LastName,ter.TerritoryDescription 

    FROM Employees emp

    INNER JOIN EmployeeTerritories Eter

    ON emp.EmployeeID = Eter.EmployeeID

    INNER JOIN Territories ter

    ON ter.TerritoryID = Eter.TerritoryID

END 

EXECUTE GetEmployeeWithTerr

drop proc dbo.usp_GetCitiwiseEmployee

CREATE PROCEDURE dbo.usp_GetCitiwiseEmployee

@city VARCHAR(20),

@Title VARCHAR(50)

AS

BEGIN

    SELECT FirstName,LastName,City,Title

    FROM Employees

    WHERE City = @city AND Title = @Title

END 

--DROP  PROC dbo.usp_GetCitiwiseEmployee if object_id('dbo.usp_GetCitiwiseEmployee') is not null 

     drop proc dbo.usp_GetCitiwiseEmployee

go EXECUTE dbo.usp_GetCitiwiseEmployee @city='London',@Title='Sales Representative' 
EXECUTE dbo.usp_GetCitiwiseEmployee 'London','Sales Representative'



CREATE PROCEDURE usp_ProductCountByCategory 
(

@i_catid INT ,

@o_Prodcount INT OUT

)

AS

BEGIN

    IF @i_catid is NULL OR @i_catid < 0 

        RETURN -1      

		SELECT @o_Prodcount=count(ProductID) from Products

        WHERE CategoryID=@i_catid

END  

drop proc usp_ProductCountByCategory

DECLARE @prodcount INT

EXEC usp_ProductCountByCategory 0, @prodcount OUT

Select @prodcount 

select * from Products where CategoryID=1

select * from Categories



CREATE PROCEDURE usp_GetErrorInfo

AS

    SELECT 

        ERROR_NUMBER() AS ErrorNumber,

        ERROR_SEVERITY() AS ErrorSeverity,

        ERROR_STATE() as ErrorState,

        ERROR_PROCEDURE() as ErrorProcedure,

        ERROR_LINE() as ErrorLine,

        ERROR_MESSAGE() as ErrorMessage;

GO 

CREATE PROCEDURE ERRORHANDLING

AS

BEGIN

    BEGIN TRY

         SELECT 1/0;

    END TRY

    BEGIN CATCH

        EXEC usp_GetErrorInfo

    END CATCH

END

exec ERRORHANDLING




--Procedure with RaiseError

--DROP PROCEDURE usp_updateprodprice

CREATE Procedure usp_updateprodprice

@i_vcategory int

As

BEGIN

if @i_vcategory is NULL or @i_vcategory <=0

begin

    raiserror (50001, 1,1)

    return -1

end

    UPDATE Products set UnitPrice = UnitPrice*1.1

    WHERE CategoryID= @i_vcategory

return 0

END 

Select * from Products where CategoryID =0 DECLARE @return_value int

Exec @return_value = usp_updateprodprice 0

select @return_value










CREATE TABLE dbo.EmpJobTitle

(

EmpId INT IDENTITY(1,1),

FirstName VARCHAR(150),

LastName VARCHAR(150),

JobTitle VARCHAR(50)

) INSERT INTO dbo.EmpJobTitle(FirstName, LastName, JobTitle)

VALUES

('Subham', 'Jindal', 'CEO'),

('Ramesh', 'Khatri', 'AVP'),

('Rohit', 'Kumar', 'HR Manager'), 

('Sujoy', 'Ghosh', 'Software Developer'), 

('Lokesh', 'Kumar', 'Team Lead') ,

('Mandeep', 'Kaur', 'Software Developer'), 

('Rajat', 'Prakash', 'Software Developer'),

('Manhor', 'Aggarwal', 'Program Manager') 

select * from EmpJobTitle


BEGIN TRAN TEmpJT

    SELECT * FROM dbo.EmpJobTitle 

    WHERE EmpId =3;

UPDATE dbo.EmpJobTitle SET JobTitle ='Sr. HR Manager'

    WHERE EmpId =3;

delete from EmpJobTitle where JobTitle='Software Developer'
SELECT * FROM dbo.EmpJobTitle 

    WHERE EmpId =3;     
select COUNT(*) from EmpJobTitle where JobTitle='Software Developer' 

ROLLBACK TRAN TEmpJT

SELECT * FROM dbo.EmpJobTitle 

WHERE EmpId =3;

select COUNT(*) from EmpJobTitle where JobTitle='Software Developer'










-------------------------------------------- BEGIN TRY

 BEGIN TRAN T
Begin try
   SELECT * FROM dbo.EmpJobTitle 

   WHERE EmpId =5     

UPDATE dbo.EmpJobTitle SET JobTitle ='Sr.Team Lead'

   WHERE EmpId =5  

select (1/0)    

COMMIT TRAN T
SELECT * FROM dbo.EmpJobTitle 

   WHERE EmpId=5 

END TRY 
BEGIN CATCH

     SELECT * FROM dbo.EmpJobTitle 

     WHERE EmpId =5     

	ROLLBACK TRAN T  
	
	SELECT * FROM dbo.EmpJobTitle 
     WHERE EmpId =5
END CATCH 

-----------Save Point------------------------------

BEGIN TRY

 BEGIN TRAN T

    SELECT * FROM dbo.EmpJobTitle 

    WHERE EmpId in (3,7)     
	UPDATE dbo.EmpJobTitle SET JobTitle ='Human Resource Manager'
	WHERE EmpId =3 

save TRANSACTION SaveUpdates

--- Define a save point     
DELETE FROM dbo.EmpJobTitle 
WHERE EmpId = 7     
SELECT 1/0 


----------- Error Divide by Zero  COMMIT TRAN T;     SELECT * FROM dbo.EmpJobTitle 

    

END TRY

BEGIN CATCH     

SELECT 'Inside the Catch Block'

    SELECT * FROM dbo.EmpJobTitle 

    WHERE EmpId in (3,7); 

ROLLBACK TRAN SaveUpdates 
----------Rollback to Save Point     

SELECT * FROM dbo.EmpJobTitle 

    WHERE EmpId in (3,7); END CATCH



CREATE TABLE Employee_Test  
(  
Emp_ID INT Identity,  
Emp_name Varchar(100),  
Emp_Sal Decimal (10,2)  
)  

INSERT INTO Employee_Test VALUES ('Anees',1000);  
INSERT INTO Employee_Test VALUES ('Rick',1200);  
INSERT INTO Employee_Test VALUES ('John',1100);  
INSERT INTO Employee_Test VALUES ('Stephen',1300);  
INSERT INTO Employee_Test VALUES ('Maria',1400);  

CREATE TABLE Employee_Test_Audit  
(  
Emp_ID int,  
Emp_name varchar(100),  
Emp_Sal decimal (10,2),  
Audit_Action varchar(100),  
Audit_Timestamp datetime  
) 

create trigger trgAfterInsert ON Employee_Test  
FOR INSERT  
AS 
Begin
	declare @empid int;  
	declare @empname varchar(100);  
	declare @empsal decimal(10,2);  
	declare @audit_action varchar(100);  
	select @empid=i.Emp_ID from inserted i;   
	select @empname=i.Emp_Name from inserted i;   
	select @empsal=i.Emp_Sal from inserted i;   
	set @audit_action='Inserted Record -- After Insert Trigger.';  
  
	insert into Employee_Test_Audit  
	(Emp_ID,Emp_Name,Emp_Sal,Audit_Action,Audit_Timestamp)   
	values(@empid,@empname,@empsal,@audit_action,getdate());  
  
	PRINT 'AFTER INSERT trigger fired.'  
end
GO  

select * from Employee_Test_Audit
select * from Employee_Test

INSERT INTO Employee_Test VALUES ('lokesh',1080);  
INSERT INTO Employee_Test VALUES ('Ritick',1700); 








CREATE TRIGGER trgInsteadOfDelete ON Employee_Test

INSTEAD OF DELETE

AS

    declare @emp_id int;

    declare @emp_name varchar(100);

    declare @emp_sal int;

    select @emp_id=d.Emp_ID from deleted d;

    select @emp_name=d.Emp_Name from deleted d;

    select @emp_sal=d.Emp_Sal from deleted d;     

BEGIN

        if(@emp_sal>1200)

        begin

            RAISERROR('Cannot delete where salary > 1200',16,1);

            ROLLBACK;

        end

        else

        begin

            delete from Employee_Test where Emp_ID=@emp_id;

            COMMIT;

            insert into Employee_Test_Audit(Emp_ID,Emp_Name,Emp_Sal,Audit_Action,

                                                        Audit_Timestamp)

            values(@emp_id,@emp_name,@emp_sal,

                               'Deleted -- Instead Of Delete Trigger.',getdate());

            PRINT 'Record Deleted -- Instead Of Delete Trigger.'

        end

END

GO 

Select * from Employee_Test where Emp_ID =6

DELETE FROM Employee_Test where Emp_ID =7

