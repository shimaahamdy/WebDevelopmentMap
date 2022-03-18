create table Department (
DeptNo int primary key,
DeptName varchar(50),
Locat varchar(40)
);

sp_addtype loc,'nchar(2)','NOT NULL','NY'

create rule locrule as @x in ('NY','DS','KW')

sp_bindrule locrule,'loc'

alter table Department
alter column Locat loc

create table Employee(
EmpNo int,
Fname	varchar(20) NOT NULL,
Lname   varchar(20) NOT NULL,
DeptNo  int,
Salary  int,
constraint c1 primary key (EmpNo),
constraint c2 foreign key(DeptNo) references Department(DeptNo),
constraint c3 unique (Salary),
)

create rule salaryrule as @salary<6000

sp_bindrule salaryrule,'Employee.Salary'

/* rule captial */
insert into Department 
values (6,'PD','be');

select *from Department;
select *from Employee;

insert into Employee values (1, 'ahmed' , 'mohamed' , 2, 5000);
insert into Employee values (10102, 'mansour' , 'mohamed' , 2, 2000);


insert into Project values (2,'mohamed',8000);
select * from Project;

insert into Works_on (ProjectNo,EmpNo,Job)values (1,1,'it')
insert into Works_on (ProjectNo,EmpNo,Job)values (2,2,'it')
insert into Works_on (ProjectNo,EmpNo,Job)values (2,10102,'ds')
select *from Works_on;

----------------------------------------------------

insert into Employee(EmpNo) values (11111);
update Works_on set EmpNo = 11111 where EmpNo=10102;
update Employee set EmpNo = 22222 where EmpNo=10102;
delete Employee where EmpNo=10102;

--------------------------------------------------------
alter table Employee add  TelephoneNumber int;

select *from Employee;
alter table Employee drop column TelephoneNumber;
-----------------------------------------------------------

create schema Company;

alter schema Company transfer Department 

create schema HR;
alter schema HR transfer Employee;
-------------------------------------------------------
SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
WHERE TABLE_NAME='Emp'

sp_helpconstraint employee;
---------------------------------------------------------

create synonym Emp 
for HR.Employee

Select * from Employee
Select * from [HR].Employee  /* work */
Select * from Emp
Select * from [HR].Emp   /* HR.HR.EMP --> not vaild*/

update Company.Project set Budget = Budget+0.1*Budget 
from Company.Project,Works_on,Emp
where Emp.EmpNo=Works_on.EmpNo 
and Company.Project.ProjectNo=Works_on.ProjectNo and Emp.EmpNo=10102

select *from Company.Project
select*from  Company.Department
select *from Works_on
select *from Emp

insert into Emp values (5,'james','alferdo',1,5500);

update Company.Department set DeptName = 'Sales' 
from  Company.Department,HR.Employee 
where HR.Employee.DeptNo = Company.Department.DeptNo and 
HR.Employee.Fname = 'james';

update Works_on set Enter_Date = '12.12.2007'
from Works_on,Emp,Company.Department
where Emp.EmpNo=Works_on.EmpNo and Department.DeptNo=Emp.DeptNo
and Department.DeptName='Sales'

delete Works_on 
from Works_on,Emp,Company.Department
where Emp.EmpNo=Works_on.EmpNo and Department.DeptNo=Emp.DeptNo 
and Department.Locat = 'KW'



create table Student (
id int primary key,
name varchar(20),
num int ,
constraint v1 foreign key(num) references Course(num)
)

create table Course(
num int primary key,
descr varchar(20))

create schema learn;
alter schema learn transfer Student;
alter schema learn transfer Course;




