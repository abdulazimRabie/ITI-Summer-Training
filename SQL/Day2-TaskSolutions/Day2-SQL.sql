-- 1. creating database 
create database [SD37-Company]
on primary (
	name = 'SD37-Company-Data',
	filename = 'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SD37-Company-Data.mdf',
	size = 10MB,
	maxsize = 50MB,
	filegrowth = 10%
)
log on (
	name = 'SD37-Company-Log',
	filename = 'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SD37-Company-Log.ldf',
	size = 5MB,
	maxsize = 40MB,
	filegrowth = 10%
)

use [SD37-Company]
go

-- 2. creating Department table
create table Department (
	DeptNo int primary key,
	DeptName nvarchar(20) not null,
	-- a. we choosed nvarchar to ensure that different language inputs will appear as intended and to use memory in efficient way
	[Location] nchar(2) default 'NY' constraint location_check check (Location in ('NY', 'DS', 'KW'))
	-- b. nchar is used to allow multilanguages and fixed length at the same time
)

-- 2.b creating Employee table
create table Employee (
	EmpNo int identity(1, 1) primary key,
	EmpFname varchar(30) not null,
	EmpLname varchar(30) not null,
	DeptNo int,
	Salary float(7)

	constraint Emp_Dept_FK 
	foreign key (DeptNo) 
	references Department(DeptNo),

	constraint check_salary
	check (Salary > 7000)
)

-- create Project table
create table Project (
	ProjectNo int primary key,
	ProjectName varchar(20) not null,
	Budget float(7),
)

-- create Works_on table
create table Works_on (
	EmpNO int not null,
	ProjectNo int not null,
	Job varchar(50),
	Enter_Date date default getdate(),


	constraint composite_Works_on_PK
	primary key (EmpNO, ProjectNo),
	
	constraint emp_FK
	foreign key (EmpNo)
	references Employee(EmpNo),

	constraint project_FK
	foreign key (ProjectNo)
	references Project(ProjectNo)
)

---------------------------
---------------------------

-- 3. Modify tables
-- a. adding telephone number to table
alter table Employee
add TelephonNo int

-- b. dropping this column
alter table Employee
drop column TelephonNo


----------------------------
----------------------------
-- 4. Creating Company schema

create schema Company;
alter schema Company transfer dbo.Employee
alter schema Company transfer dbo.Department


----------------------------
----------------------------
-- 5. 
-- We can't drop primary key from table because there are other tables depend on this primary key
-- so, it will corrupt all database
-- 5.a No primary key can't refer to unique key instead of foreign key


----------------------------
----------------------------
-- 6. inserting

-- insert into Department table
insert into Company.Department (DeptNo, DeptName, [Location])
values 
(1, 'Software', 'NY'), 
(2, 'Hardware', 'KW'), 
(3, 'Cloud', 'DS')

-- insert into Employee table
insert into Company.Employee (EmpFname, EmpLname, DeptNo, Salary)
values ('Abdulazim', 'Rabie', 1, 7500)

insert into Company.Employee (EmpFname, EmpLname, DeptNo, Salary)
values ('Ali', 'Hassan', 2, 7001)

insert into Company.Employee (EmpFname, EmpLname, DeptNo, Salary)
values ('Noh', 'Qudus', 2, 9001)

-- insert into Project table
insert into Project (ProjectNo, ProjectName, Budget)
values 
(1, 'Apollo', 120000),
(2, 'Geminin', 9032), 
(3, 'Mercury', 43982)

-- insert into Works_on table
insert into Works_on (EmpNO, ProjectNo, Job, Enter_Date)
values (1, 1, 'Data Engineer', '2006/2/1')

insert into Works_on (EmpNO, ProjectNo, Job, Enter_Date)
values 
(4, 2, 'Embedded Systems', '2006/4/1'),
(5, 3, 'Devops', '2006/4/1')

------------------------------
------------------------------
-- 7. Updating
-- a.i => error will occur because the EmpNo is identity that means you cannot set it by your self
-- a.ii => you cann't change primary keys after ceration
-- a.iii => can't modify primary keys after creation
-- a.iv
 -- delete from Company.Employee where empNo = 1
 -- this will cause some errors, because SQL Server will prevent you from deleting record contains data use in other tables

