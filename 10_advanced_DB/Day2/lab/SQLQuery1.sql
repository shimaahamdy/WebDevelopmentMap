create function monthname(@DayDate date)
returns nvarchar(20)
begin
declare @monthname nvarchar(20)
	select @monthname = datename(mm,getdate())
return @monthname	
end 

select dbo.monthname(GETDATE())


-------------------------------------------------------
alter function nums(@x int, @y int) 
returns @numbers table
		(
		 num int
		)
as
begin
     set @y = @y-1
     while @x <@y
		begin
		 set @x=@x+1
		 insert @numbers select @x
		 
		end
    
return
end

select * from dbo.nums(5,10)
------------------------------------------------------------------
alter function depname(@student int)
returns table
as 
return
(
select st_fname + ''+ s.St_Lname as fullname, d.Dept_Name
from student s, Department d
where s.Dept_Id=d.Dept_Id
)

select * from dbo.depname(5)
--------------------------------------------------------------
create function messagename(@student int)
returns nvarchar(60)
begin
    declare @firstname nvarchar(50)
	declare @lastname nvarchar(50)
	declare @messagen nvarchar(60)
	select @firstname =s.St_Fname from Student s
	select @lastname =s.St_Lname from Student s
	if @firstname = NUll and @lastname = NULL
		select @messagen='First name & last name are null'
	else if @firstname = NULL
	    select @messagen='last name is null'
	else if @lastname = NULL
	    select @messagen='first name is null'
		
	else
		select @messagen='First name & last name are not '
return @messagen	
end 

select  dbo.messagename(5)
-------------------------------------------------------------
alter function mangerdate(@manger int)
returns table
as 
return
(
select d.Dept_Manager,d.Dept_Name,ins.Ins_Name,d.Manager_hiredate
from Instructor ins, Department d
where d.Dept_Manager = ins.Ins_Id and ins.Ins_Id=@manger
)

select * from dbo.mangerdate(1)
------------------------------------------------------------------
create function studname(@name varchar(50)) 
returns @names table
		(
		 student_id int primary key,
		 student_name nvarchar(50)
		)
as
begin
    if @name='fullname'
		insert @names
		select st_id,isnull(st_fname,'')+' '+isnull(st_lname ,'')
		from student
	
	else if @name='firstname'
		insert  into @names
		select st_id,isnull(st_fname,'')
		from student
   else if @name='lastname'
        insert  into @names
		select st_id,isnull(st_Lname,'')
		from student
	else 
	    insert into @names
		select st_id,NULL
		from Student
    
return
end

select * from dbo.studname('firstname')
------------------------------------------------------------------------------
select s.St_Id,substring(st_fname,1,len(st_fname)-1)
from Student s
--------------------------------------------------------------------------
delete from sc 
from Student s,Department d, Stud_course sc, Course c
where s.Dept_Id = sc.St_Id and c.Crs_Id = sc.Crs_Id and s.Dept_Id = 
(select Department.Dept_Id  from Department where Department.Dept_Location='SD')
--------------------------------------------------------------------------------
