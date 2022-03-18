/*
all aggragiate function not take null in caluation 
*/

/* avg:
if have null values --> will not consider
200
300
null

avg() = (200+300)/2
*/



select sum(salary) as [total salary]
from Instructor


select max(salary),min(salary)
from Instructor

isnull(column,0); --remove each null and replace with 0


/* count number of rows or id*/
select count(*) from Student; --number of rows or id
select count(st_id) from Student; --number of rows or id

/*
if you use aggregate in select you can not call a nother column without
using groub by

// that query is wrong 
select min(), column
from employee;
*/

select dept_id,sum(salary)
from instructor
group by dept_id

/* select minimum salry from each department*/
select dep_id, min(saraly)
from employee
groub by dep_id;


/* using where with groub */

/* filter rows before groubing */

/* where not used with aggregatie function */
/* having use it with aggrgiate an groub */


-- groub by 2 columns to appear in select
select d.dept_id,dept_name,sum(salary)
from instructor i ,Department d
where d.Dept_Id=i.Dept_Id
group by d.dept_id,dept_name

/* groub by more than one coulmn */
group by address , id  --> alex 10 groub 1
                           alex 20 groub 2
groub by both ot 2
	
/* delete whole groub --> having */
groub by dep
having sum()>100


select d.dept_id,dept_name,sum(salary)
from instructor i ,Department d
where d.Dept_Id=i.Dept_Id
group by d.dept_id,dept_name
having count(ins_id)>2


select st_age
from student
order by st_fname

/*               subquery               */
--subquery
/* select students who their age < average ages */

--using where will get error as can not use where and aggrgate function 
select *
from student
where st_age>(avg(st_age))  --error using where with aggregate function

--also can not use having
select *
from student
having st_age>(avg(st_age))  --error having without group by

--using group wil not return all row data
--use subquery
select *
from student
where st_age>(select avg(st_age)
			  from student)

			  		  
select *
from student
where st_age>23

/* select the departments that have students in */
select *
from department
where dept_id  in (select distinct(dept_id)
					 from student
					 where dept_id is not null)


/* the departments that have students in */
/* with join */
select distinct dept_name
from Department d,Student s
where d.Dept_Id = s.Dept_Id;


select *
from department
where dept_id  in (10,20,30,40)



-- departments who not have students
select dept_name
from Department
where dept_id not in(select distinct(dept_id)
					 from student
					 where dept_id is not null)


/*               subquery with DML        */
--DML "joins-subquery"

update Stud_Course
	set grade=grade+10
from Stud_Course sc,student s
where s.St_Id=sc.St_Id
	  and st_fname='ahmed' and St_Address='cairo'

/* delete courses of students who in departemnt number 10*/
delete from Stud_Course
where st_id in (select st_id from student
				where dept_id=10) 


--Agg Fun
--Group by
--Having
--Subquery
--joins --subqueries --DML


/* union family */
/* one sheet have students names and instructors */
/* can be in different groubs */
/* have to select same numbers of columns and same datatype */
select st_id,st_fname
from student
union all
select ins_id,ins_name
from Instructor

/*same as union all but with distinct output */
/* delte names that reapeated */
select st_fname
from student
union 
select ins_name
from Instructor

/* intersect: the coulmns with same values in both tables */
/* names of students similr to to instructors */
select st_fname
from student
intersect 
select ins_name
from Instructor

/* 
union   inatersect   except(innerly):
-sort
-distinct 
*/



/* order */

/* selct data form table order by column in another table */
select st_fname,st_age,st.dept_id
from Student st, instructor s
order by  Salary;

/* 1: first column in select fname
   2: second column in select age
*/
select st_fname,st_age,dept_id
from Student
order by 2;

/* order first in column and if it is equal order with table clumn2*/ 
select st_fname,st_age,dept_id
from Student
order by dept_id,st_age;

/* select values in resultset 1 not exsist in resultset2 */
--names of students not the same like instructors */
select st_fname
from student
except 
select ins_name
from Instructor

--create table
create table emp
(
id int primary key identity,
name varchar(50) not null,
addres varchar(50) default 'cairo'
)

drop table emp


insert into emp
values('ali','alex')


insert into emp(id,name)
values(100,'ali')


update emp
set addres=default where id=1

--Data Types
--Exact Numeric
bigint 8byte
int    4byte
smallint 2byte  -23000 : +32000
tinyint 1 byte  0:255
bit 0:1
--Float Values
real  4 byte
float 8 byte
decimal(10,3) 1234567.899	--12.2
--Date and time
date month/day/year
time 00:00:00.999
datetime  1753:9999
smalldatetime 1900:2079
datetime(7) 1/1/2000 00:00:00.9999999
datetimeoffset 1/1/2000 00:00:00.999cairo
--Char and string
char(20)  max 8000 char
varchar(10) max 8000 char variable
varchar(max) up to 2GB
text 
--unicode char
nchar
nvarchar

--binary
binary 8kB
varbinary
--others
xml
sql_variant

--can not deal eith alis in where as it is not appear yet
select st_id,st_fname+' '+st_lname as fullname
from student 
where fullname='ahmed Hassan'

--Solution
--1
select *
from (
      select st_id,st_fname+' '+st_lname as fullname
      from student 
	  ) as tb1
where fullname='ahmed Hassan'


--2
select st_id,st_fname+' '+st_lname as fullname
from student 
where st_fname+' '+st_lname='ahmed Hassan'


/* in order we can use alis as order excuter after select */
select st_id,st_fname+' '+st_lname as fullname
from student 
order by fullname


/* excution steps */
--from
--joins
--where
--group by
--having
--select
--order by
--top

/* EERD : enhanced ERD ( ERD + inhirtance )*/

/* if you want to update or delete parent (pk)
you can not unless you change it in the child (fk)
*/
--built in fuctions 
--agg functions 
getdate();
isnull();
coalesce();
concat();
Convert();
year();
month();

select year(getdate());
select substring(st_fname,1,3) --1 2 3
from Student;

substring(name,3,3) -- 3 4 5
select db_name() --database name

select suser_name(); --server user



 /*for help , click on view -> templateexplorer 













