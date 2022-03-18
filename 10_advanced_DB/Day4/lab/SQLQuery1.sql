/* 1.Create a stored procedure without parameters to show the number of students per
department name.[use ITI DB] */
create proc p1
as
select d.Dept_Name, count(s.St_Id)
from Department d, Student s
where d.Dept_Id = s.Dept_Id
group by d.Dept_Name
return 1

p1
------------------------------------------------------------------------------------
/* 2.	
Create a stored procedure that will check for the # of employees in the project p1
if they are more than 3 print message to the user 
“'The number of employees in the project p1 is 3 or more'” 
if they are less display a message to the user 
“'The following employees work for the project p1'” 
in addition to the first name and last name of each one. [Company DB] */
use Company_SD

create proc p2
as
	declare @empnum int, @message varchar(50)
	set @empnum = (select count(w.ESSn)
	from Works_for w
	where w.Pno=1)
	if(@empnum > 3)
		set @message= 'The number of employees in the project p1 is 3 or more'
	else 
		set @message = 'The following employees work for the project p1'
	select @message,e.Fname, e.Lname
	from Employee e, Works_for w
	where w.ESSn = e.SSN and w.Pno=1

p2
-------------------------------------------------------------------------------------
/*3
Create a stored procedure that will be used in case there is an old employee has
left the project and a new one become instead of him. The procedure should take 3
parameters (old Emp. number, new Emp. number and the project number) and it will be
used to update works_on table. [Company DB]*/

create proc p3(@old int , @new int, @p int)
as
	update Works_for set ESSn = @new , Pno = @p
	where Essn=@old

p3 112233,2,1
-------------------------------------------------------------------------------------
/* 4
add column budget in project table and insert any draft values in it
then Create an Audit table with the following structure :
ProjectNo 	UserName 	ModifiedDate 	Budget_Old 	Budget_New 
p2 	Dbo 	2008-01-31	95000 	200000 
This table will be used to audit the update trials on the Budget column 
Project table, Company DB)
*/
alter table Project add budget int;
insert into Project (Pnumber,budget) values (5,5000);
insert into Project (Pnumber,budget) values (6,8000);
insert into Project (Pnumber,budget) values (7,15000);
insert into Project (Pnumber,budget) values (8,5000);

create table Auditab
(
pno int primary key,
username varchar(50),
modifiedDate date,
Budget_Old int,
Budget_new int
)

create trigger t1
on Project
instead of update
as
	if update(budget)
	begin
	    declare @oldbudget int , @newbudget int, @pnum int
		set @oldbudget = (select d.budget from deleted d)
		set @newbudget = (select i.budget from inserted i)
		set @pnum = (select d.Pnumber from deleted d)

		insert into Auditab values(@pnum,suser_name(),getdate(),@oldbudget,@newbudget)
		update Project set budget = (select budget from inserted)
	end
	

update Project set budget = 8952 
where Pnumber = 5

update Project set City = '6 Octobr'
where Pnumber=5

select * from Project where Pnumber=5 -- no update

select * from Auditab;
---------------------------------------------------------------------------------------
/*5
Create a trigger to prevent anyone from inserting a new record in the Department
table [ITI DB]
“Print a message for user to tell him that he can’t insert a new record in that table”*/

use ITI

create trigger t2
on Department 
instead of insert
as
	print ('you can’t insert a new record in that table')

insert into Department values (20,'it','des20','loc20',null,null);

--------------------------------------------------------------------------------------
/*7	
Create a trigger on student table after insert to add Row in Student Audit table 
(Server User Name , Date, Note)
where note will be “[username] Insert New Row with
Key=[Key Value] in table [table name]”
ServerUser Name		Date   Note 

*/
create table StudentAudit 
(
suser varchar(50),
Datee date,
note varchar(150)
)

alter trigger t3
on Student
after insert
as
    declare @key int, @username varchar(50),@mess varchar(200)
	set @key = (select d.St_Id from inserted d)
	set @username = @@SERVERNAME
	set @mess = CONCAT(@username,' Insert New Row with Key=',@key,'in table student')
	insert into StudentAudit values (@username, getdate(),@mess)

insert into Student (St_Id) values (5863)
select * from StudentAudit
---------------------------------------------------------------------------------------
/*8
Create a trigger on student table instead of delete to add Row in Student
Audit table (Server User Name, Date, Note) where note will be
“ try to delete Row with Key=[Key Value]”
*/
create trigger t4
on Student
instead of delete
as
    declare @key int, @username varchar(50),@mess varchar(200)
	set @key = (select d.St_Id from deleted d)
	set @username = @@SERVERNAME
	set @mess = CONCAT(@username,' try to delete Row with Key= ',@key)
	insert into StudentAudit values (@username, getdate(),@mess)

delete from Student where St_Id=5
select * from StudentAudit
-----------------------------------------------------------------------------------
/* 9
Display all the data from the Employee table (HumanResources Schema) 
As an XML document “Use XML Raw”. “Use Adventure works DB” 
A)	Elements
B)	Attributes

*/
use AdventureWorks2012

select * from HumanResources.Employee emp
for xml raw('emp'),ELEMENTS xsinil,ROOT('Employees')

select * from HumanResources.Employee emp
for xml raw('emp'),ROOT('Employees')

----------------------------------------------------------------------------------
/*
10.	Display Each Department Name with its instructors. “Use ITI DB”
A)	Use XML Auto
B)	Use XML Path
*/
use ITI

select Dept_Name, Ins_Name
from Department , Instructor
where Department.Dept_Id=Instructor.Dept_Id
for xml auto,elements,root('instuctorcourses')

select Dept_Name, Ins_Name
from Department , Instructor 
for xml path
where Department.Dept_Id=Instructor.Dept_Id
for xml path,elements,root('instuctorcourses')

/* 11
Use the following variable to create a new table “customers” inside the company DB.
 Use OpenXML

*/
use Company_SD
--1)create table
CREATE TABLE customer
(FirstName varchar(20),
Zipcode int,
orderId int,
productname varchar(50),
)
--2)declare XML Container
declare @docs xml =
      '<customers>
              <customer FirstName="Bob" Zipcode="91126">
                     <order ID="12221">Laptop</order>
              </customer>
              <customer FirstName="Judy" Zipcode="23235">
                     <order ID="12221">Workstation</order>
              </customer>
              <customer FirstName="Howard" Zipcode="20009">
                     <order ID="3331122">Laptop</order>
              </customer>
              <customer FirstName="Mary" Zipcode="12345">
                     <order ID="555555">Server</order>
              </customer>
       </customers>'


--3)declare document handle
declare @hdocs int

--4)create memory tree
Exec sp_xml_preparedocument @hdocs output, @docs

--5)process document 'read tree from memory'
--OPENXML Creates Result set from XML Document
INSERT INTO customer
SELECT * FROM OPENXML (@hdocs, '/customers/customer') 
WITH (FirstName varchar(20) './@FirstName', Zipcode int './@Zipcode', orderId int './order/@ID',ordername  varchar (50)'./order')


--5)remove memory tree
Exec sp_xml_removedocument @hdocs

Select * from customer







