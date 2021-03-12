--Float to varchar

use testing

 

select STR(56444.456,5,2)

 

SELECT REPLACE('karthikeyan Subba','Subba','S');

 

select * from [dbo].[PRODUCTS]

 

select REPLACE(productname,'DVD2','Mobile')  from [dbo].[PRODUCTS] 
where PRODUCTID='P100'

 

select * from [dbo].[PRODUCTS] where PRODUCTID='p100'

 

select LEFT('Thisis justa testing',10)

 

select RIGHT('Thisis justa testing',8)

 

select LEFT(productname,3), * from [PRODUCTS]

 

select SUBSTRING('I am just testing substrin',6,4)

 

Select LEN('length check testing length check testing length check testing')

 

select REVERSE('test')

 

Select LOWER('PASSWOrd')

 

Select Upper('password')

 

select TRIM('  testing   ')

 

select LTRIM('  testing   ')
select RTRIM('  testing   ')
 
select NCHAR(65)

 

select NCHAR(97)

select StudentMarks from StudentTotalMarks
order by StudentMarks
--group by StudentMarks
 
select count(*) as cnt,StudentMarks,StudentID from StudentTotalMarks
group by StudentMarks,StudentID
order by StudentMarks

select count(*), StudentMarks from StudentTotalMarks
group by StudentMarks

select * from [dbo].[StudentDetails]





create table Subject(
	sub_id int Primary key,
	sub_name varchar(50) not null,
)

create table Student(
	student_id int Primary key,
	student_name varchar(50) not null,
	s_id1 int foreign key references Subject(sub_id) ,
	s_id2 int foreign key references Subject(sub_id) ,
	s_id3 int foreign key references Subject(sub_id) ,
	s_id4 int foreign key references Subject(sub_id) ,
	s_id5 int foreign key references Subject(sub_id) ,
)

create table marks
(
	stud_id int foreign key references Student(student_id) on delete cascade,
	sb_id int foreign key references Subject(sub_id) on delete cascade,
	marks int,
	primary key(stud_id,sb_id)
)


insert into Subject values(1,'Engineering Mathematics')
insert into Subject values(2,'Engineering Physics')
insert into Subject values(3,'Software Testing')
insert into Subject values(4,'Engineering Economics')
insert into Subject values(5,'Data Structure and Algorithms')
insert into Subject values(6,'Advance Data Structures')
insert into Subject values(7,'Renewable Energy Resources')
insert into Subject values(8,'Computer Graphics')

select * from Subject

insert into Student values(1,'Alex',1,2,3,4,5)
insert into Student values(2,'Cherry',2,3,8,5,6)
insert into Student values(3,'Alice',3,7,5,6,4)
insert into Student values(4,'Samantha',3,5,7,8,1)
insert into Student values(5,'Zack',4,1,7,2,6)

select * from Student

insert into marks values(1,1,70)
insert into marks values(1,2,67)
insert into marks values(1,3,92)
insert into marks values(1,4,56)
insert into marks values(1,5,89)

insert into marks values(2,2,58)
insert into marks values(2,3,49)
insert into marks values(2,8,80)
insert into marks values(2,5,79)
insert into marks values(2,6,88)

insert into marks values(3,3,77)
insert into marks values(3,7,90)
insert into marks values(3,5,80)
insert into marks values(3,6,82)
insert into marks values(3,4,92)

insert into marks values(4,3,66)
insert into marks values(4,5,77)
insert into marks values(4,7,56)
insert into marks values(4,8,78)
insert into marks values(4,1,80)

insert into marks values(5,4,78)
insert into marks values(5,1,80)
insert into marks values(5,7,90)
insert into marks values(5,2,87)
insert into marks values(5,6,93)

select * from marks

--marks 
select sum(m.marks)as Total_marks, avg(m.marks)as Avg_marks from marks as m
group by stud_id

--student and subject match
select student_id, student_name, sub_id, sub_name from Student
join Subject on sub_id = s_id1 or sub_id = s_id2 or sub_id = s_id3 or sub_id = s_id4 or sub_id = s_id5


--student with sunject and each marks
select student_id, student_name, sub_id, sub_name, m.marks from Student
join Subject on sub_id = s_id1 or sub_id = s_id2 or sub_id = s_id3 or sub_id = s_id4 or sub_id = s_id5
join marks as m on m.sb_id= sub_id and m.stud_id = student_id


--student with total marks no order
select student_name, sum(m.marks)as Total_marks, avg(m.marks)as Avg_marks from Student
join Subject on sub_id = s_id1 or sub_id = s_id2 or sub_id = s_id3 or sub_id = s_id4 or sub_id = s_id5
join marks as m on m.sb_id= sub_id and m.stud_id = student_id
group by student_name


--student with total marks/avg with ordered name and score
select student_name, sum(m.marks)as Total_marks, avg(m.marks)as Avg_marks from Student
join Subject on sub_id = s_id1 or sub_id = s_id2 or sub_id = s_id3 or sub_id = s_id4 or sub_id = s_id5
join marks as m on m.sb_id= sub_id and m.stud_id = student_id
group by student_name
order by Total_marks desc,student_name 


--same as above with more groups
select student_name,sub_name, sum(m.marks)as Total_marks, avg(m.marks)as Avg_marks from Student
join Subject on sub_id = s_id1 or sub_id = s_id2 or sub_id = s_id3 or sub_id = s_id4 or sub_id = s_id5
join marks as m on m.sb_id= sub_id and m.stud_id = student_id
group by 
	Grouping sets(
		student_name,
		sub_name
	)
order by Total_marks desc,sub_name,student_name 