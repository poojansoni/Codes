use ABC_Company
select * from Employee
EmpId - FK Reference Employee Table, Date , Logintime , LogoutTime, totalWorkingHour, Leave, Holiday
create table Employee_attendance(
	Emp_id int constraint FK_empid Foreign Key References Employee(EmployeeId),
	p_date date not null,
	Login_time time,
	Logout_time time,
	totalWorkingHours as (DATEDIFF(hour,Login_time,Logout_time)),
	Leave int default 0,
	Holiday int default 20
)
select GETDATE()
select DATEDIFF(hour,'15:38:36.3530319','6:38:36.3530319')

insert into Employee_attendance(Emp_id,p_date,Login_time,Logout_time) values (1,'2021-03-18','6:38:36.3530319','15:38:36.3530319')

insert into Employee_attendance(Emp_id,p_date,Login_time,Logout_time) values (2,'2021-03-18','7:38:36.3530319','16:38:36.3530319')

insert into Employee_attendance(Emp_id,p_date,Login_time,Logout_time) values (3,'2021-03-18','6:50:36.3530319','15:50:36.3530319')
select * from Employee_attendance

Select count(*) from Employee_attendance where p_date = convert(date,getdate()) 