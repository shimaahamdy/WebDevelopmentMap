use iti
select * from Student

--fullpath
--servername.dbname.schemaname.object

select *
from [DESKTOP-VF50P25].iti.dbo.student

select * from Student

select * from Company_SD.dbo.project

select dept_name
from Department
union all
select dname
from Company_SD.dbo.Departments

select *
from Student
where

select top(2)*
from Student

select top(2)*
from Student
where St_Address='alex'

select top(3) st_fname
from Student

select max(salary)
from Instructor

select top(2)salary
from Instructor
order by salary desc

select newid()  --guid

select top(3)*,newid() as myid
from Student
order by myid 

select st_fname+' '+st_lname as fullname
from Student
order by fullname

select st_fname+' '+st_lname as fullname
from Student
where fullname ='ahmed ali'

select *
from (select st_fname+' '+st_lname as fullname 
     from Student) as newtable
where fullname ='ahmed ali'

select st_fname+' '+st_lname as fullname
from Student
where st_fname+' '+st_lname ='ahmed ali'
--from
--join
--on
--where
--group by
--having
--select
--order by
--top

select *
from (Select *,row_number() over(order by st_age desc) as rn
      from Student) as newtable
where rn=1

select * 
from (Select *,dense_rank() over(order by st_age desc) as dr
      from Student) as newtable
where dr=1


select *
from (Select *,row_number() over(partition by dept_id order by st_age desc) as rn
      from Student) as newtable
where rn=1

select * 
from (Select *,dense_rank() over(partition by dept_id order by st_age desc) as dr
      from Student) as newtable
where dr=1
-------------------------------------
--insert based on select
insert into mytest
values(100,'ali')

insert into mytest
values(101,'ali'),(77,'eman'),(99,'omar')

insert into mytest
select st_id,st_fname from Student where St_Address='alex'


--Select into
--ddl
select * into tab2
from Student

select * into tab3
from Student

select * into [servername].myfaculty.dbo.student
from Student

select st_id,st_fname into tab4
from Student
where st_address='mansoura'

select * into tab5
from Student
where 1=2

--Datatypes
------------------Numeric DT
bit  --boolean   false:true  0:1
tinyint --1 byte   -128:127  unsigned  0:255
smallint  --2 bytes  -32768 :+32767  unsigned 0:65555
int    --4 B
bigint  --8 B
------------------Decimal DT
smallmoney   --4b   .0000
money        --8b   .0000
real                .0000000
float               .0000000000000000000000
dec  decimal    dec(5,2)  123.88   1.4   12.333 XXXXX
------------------string & charcters DT
char(10)  --fixed length character   ahmed 10    ali  10  على ???
varchar(10) --variable length characters   ahmed 5   ali  3
nchar(10)  unicode DT  language   على   على
nvarchar(10)
nvarchar(max)   up to 2GB
------------------Date & time
Date  MM/dd/yyyy
time  hh:mm:12.987
time(7) hh:mm:12.987654
smalldatetime  MM/ss/yyyy  hh:mm:00
datetime     MM/ss/yyyy  hh:mm:ss.877
datetime2(7) MM/ss/yyyy  hh:mm:ss.9876543
datetimeoffset  11/11/2021 10:30 +2:00
------------------binary DT
binary   010110  11110   11011111
image
------------------others dT
xml
sql_variant
uniqueidentifier




































