use ABC_Company
select * from Employee

select * from Salary
INSERT INTO Salary (EID, Month, BasicAmount, DAAmount, HRAAmount, PFAmount,		ECSDect,        Bonus)
VALUES (			  4,   3,    40000,      6000,    35000 ,    15000,  next value for seq_esc , 67000)

INSERT INTO Salary (EID, Month, BasicAmount, DAAmount, HRAAmount, PFAmount,		ECSDect,        Bonus)
VALUES (			  5,   3,    50000,      4000,    35000 ,    15000,  next value for seq_esc , 68000)

INSERT INTO Salary (EID, Month, BasicAmount, DAAmount, HRAAmount, PFAmount,		ECSDect,        Bonus)
VALUES (			  6,   3,    40000,      5000,    25000 ,    15000,  next value for seq_esc , 63000)

INSERT INTO Salary (EID, Month, BasicAmount, DAAmount, HRAAmount, PFAmount,		ECSDect,        Bonus)
VALUES (			  7,   3,    60000,      4000,    35000 ,    15000,  next value for seq_esc , 62000)

INSERT INTO Salary (EID, Month, BasicAmount, DAAmount, HRAAmount, PFAmount,		ECSDect,        Bonus)
VALUES (			  8,   3,    80000,      3000,    35000 ,    15000,  next value for seq_esc , 43000)

INSERT INTO Salary (EID, Month, BasicAmount, DAAmount, HRAAmount, PFAmount,		ECSDect,        Bonus)
VALUES (			  9,   3,    60000,      10000,    35000 ,    15000,  next value for seq_esc , 61000)
INSERT INTO Salary (EID, Month, BasicAmount, DAAmount, HRAAmount, PFAmount,		ECSDect,        Bonus)
VALUES (			  10,   3,    40000,      10000,    35000 ,    15000,  next value for seq_esc , 60000)

INSERT INTO Salary (EID, Month, BasicAmount, DAAmount, HRAAmount, PFAmount,		ECSDect,        Bonus)
VALUES (			  11,   3,    90000,      1000,    35000 ,    15000,  next value for seq_esc , 50000)

INSERT INTO Salary (EID, Month, BasicAmount, DAAmount, HRAAmount, PFAmount,		ECSDect,        Bonus)
VALUES (			  12,   3,    50000,      6000,    35000 ,    15000,  next value for seq_esc , 54000)

INSERT INTO Salary (EID, Month, BasicAmount, DAAmount, HRAAmount, PFAmount,		ECSDect,        Bonus)
VALUES (			  13,   3,    120000,      6000,    35000 ,    15000,  next value for seq_esc , 72000)

select convert(date,getdate())


select * from Employee_attendance
insert into Employee_attendance(Emp_id,p_date,Login_time,Logout_time) values (1,'2021-03-19','6:38:36.3530319','15:38:36.3530319')


declare @start_date date
declare @end_dtae date
declare @empid int


create proc GetAttendance
(@empid int, @start_date date,@end_dtae date )
as
begin
	if((@start_date is NULL) or(@end_dtae is NULL) or (@empid <0))
		begin
			select -1
		end
	else
		begin
			declare @count int
			Set @count = 0
			while(DATEDIFF(DAY,@start_date,@end_dtae)>= 0)
				begin   --p_date between @start_date and @end_dtae
					if((Select totalWorkingHours from Employee_attendance where p_date = @start_date and Emp_id = @empid)>=8)
						begin
							SET	@count = @count+1
						end
					set @start_date = FORMAT(dateadd(DAY,1 , @start_date),'yyyy-MM-dd')
				end
			select @count
		end
end

drop proc GetAttendance

select DATEDIFF(DAY,'2021-03-18', '2021-03-20')
select day('2021-03-18')+1
select FORMAT(dateadd(DAY,1 , '2021-03-20'),'yyyy-MM-dd')
select dateadd(DAY,1 , '2021-03-19')

declare @start date
declare @end date
declare @id int
declare @res int
set @start = '2021-03-17'
set @end = '2021-03-19'
set @id = 1
exec GetAttendance 1,'2021-03-17','2021-03-19'
select res
