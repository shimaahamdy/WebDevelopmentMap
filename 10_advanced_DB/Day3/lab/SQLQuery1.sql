/* 
1.Create a view that displays student full name, course name if the student has
a grade more than 50. */
create view studentcourse(fullname,coursename)
as 
	select s.St_Fname+' '+s.St_Lname,c.Crs_Name
	from Student s,Course c,Stud_Course sc
	where s.St_Id=sc.St_Id and c.Crs_Id=sc.Crs_Id and sc.Grade>50


select * from studentcourse;
------------------------------------------------------------------------
/* -- 2.Create an Encrypted view that displays manager names and the topics they teach.*/
use ITI
alter view instructorcourse(instructorname, topicname)
with encryption
as
	select Ins_Name, Top_Name
	from Instructor i, Department d, Ins_Course ic, Course c, Topic t
	where i.Ins_Id = d.Dept_Manager
	and ic.Ins_Id = i.Ins_Id 
	and c.Crs_Id = ic.Crs_Id 
	and t.Top_Id = c.Top_Id

select * from instructorcourse;
SP_HELPTEXT instructorcourse
----------------------------------------------------------------------------
/* 3.Create a view that will display Instructor Name, 
Department Name for the ‘SD’ or ‘Java’ Department  */
alter view insdep(instructorname, depname)
as
	select i.Ins_Name,d.Dept_Name
	from Instructor i,Department d
	where d.Dept_Id = i.Dept_Id and d.Dept_Name in ('SD','Java')

select * from insdep;
-----------------------------------------------------------------------------
/*4 Create a view “V1” that displays student data for student who lives in Alex or Cairo. 
Note: Prevent the users to run the following query 
Update V1 set st_address=’tanta’
Where st_address=’alex’;
*/
create view v1
as
	select *
	from student s
	where s.St_Address in ('Alex','Cairo')
	with check option


select * from v1
Update v1 set st_address='tanta'
Where st_address='alex';
---------------------------------------------------------------------
/*5.Create a view that will display the project name and the number of employees work
on it. “Use Company DB”*/
alter view projemployee
as
	select p.Pname, count(e.SSN) as numemp
	from Company_SD.dbo.Employee e , Company_SD.dbo.Project p, Company_SD.dbo.Works_for w
	where e.SSN=w.ESSn and p.Pnumber=w.Pno
	group by p.Pname

select * from projemployee
---------------------------------------------------------------------------
/*6.Create index on column (Hiredate) that allow u to cluster the data in table
Department. What will happen?*/
create nonclustered index hiretime
	on Department (Manager_hiredate)

select * from Department
---------------------------------------------------------------------------
/*7.Create index that allow u to enter unique ages in student table.
What will happen? */
create unique index  agein
on Student(St_Age)
---------------------------------------------------------------------------
/*8.Using Merge statement between the following two tables [User ID, Transaction Amount]*/
create table targettable
(
userid int primary key,
transamout int
)

create table sourcetable
(
userid int primary key,
transamout int
)

insert into targettable values (1,1000),(2,2000),(3,1000)
insert into sourcetable values (1,4000),(4,2000),(2,10000)

Merge into [dbo].[targettable] as T 
using [dbo].[sourcetable] as S
On T.[userid]=S.[userid]

When matched then
update set T.transamout =S.transamout

When not matched by target Then 
insert
values(S.userid,S.transamout)

When not matched by Source
Then delete;

select * from targettable;
--------------------------------------------------------------------------------------
use SD
-- part 2 
/* 1 Create view named   “v_clerk” that will display employee#,project#, 
the date of hiring of all the jobs of the type 'Clerk'.*/
create view v_clerk
as 
	select w.EmpNo, w.ProjectNo, w.Enter_Date
	from Works_on w
	where w.Job='clerk'

select * from v_clerk
--------------------------------------------------------------------------------------
/*2 Create view named  “v_without_budget” that will display all the projects data 
without budget
*/
alter view v_without_budget
as 
	select * 
	from Company.Project p
	where p.Budget = NULL

select * from v_without_budget
---------------------------------------------------------------------------------------
/*3 Create view named  “v_count “ that will display the project name and the # 
of jobs in it*/
create view v_count 
as
	select p.ProjectName, count(w.Job) as jobs
	from Company.Project p, Works_on w
	where p.ProjectNo = w.ProjectNo
	group by p.ProjectName

----------------------------------------------------------------------------------------
/*4  Create view named ” v_project_p2” that will display the emp# s for the project# ‘p2’
use the previously created view  “v_clerk”
*/
create view v_project_p2
as
	select count(e.EmpNo)
	from v_clerk e
	where e.ProjectNo='2';

----------------------------------------------------------------------------------------
/* 5 modifey the view named  “v_without_budget”  
to display all DATA in project p1 and p2 */
alter view v_without_budget
as 
	select * 
	from Company.Project p
	where p.ProjectNo = 1 or p.ProjectNo=2


select * from v_without_budget;
------------------------------------------------------------------------------------------
/* 6 Delete the views  “v_ clerk” and “v_count”*/
drop view v_clerk;
drop view v_count;
-------------------------------------------------------------------------------------------
/* 7 Create view that will display the emp# and emp lastname who works on dept# is ‘d2’*/
alter view empdep
as 
	select e.EmpNo,e.Lname, e.DeptNo
	from HR.Employee e
	where e.DeptNo='2'


select * from empdep;
------------------------------------------------------------------------------------------
/*8 Display the employee  lastname that contains letter “J”
Use the previous view created in Q#7
*/
select e.Lname
from empdep e
where e.Lname like '%J%';
------------------------------------------------------------------------------------------
/* 9 Create view named “v_dept” that will display the department# and department name*/
create view v_dept
as
	select d.DeptNo,d.DeptName
	from Company.Department d

select * from v_dept
------------------------------------------------------------------------------------------
/* 10 using the previous view try enter new department data where dept# is ’d4’ 
and dept name is ‘Development’*/
insert into v_dept values (4,'Development')
------------------------------------------------------------------------------------------
/*
11)	Create view name “v_2006_check” that will display employee#,the project #where
he works and the date of joining the project which must be from the 
first of January and the last of December 2006
this view will be used to insert data so make sure that the coming new
data must match the condition
*/
create view v_2006_check
as
	select e.EmpNo,p.ProjectNo
	from HR.Employee e, Company.Project p,Works_on w
	where e.EmpNo=w.EmpNo and p.ProjectNo=w.ProjectNo and
	w.Enter_Date between '2006-1-1' and '2006-12-31'
	with check option

select * from v_2006_check 
