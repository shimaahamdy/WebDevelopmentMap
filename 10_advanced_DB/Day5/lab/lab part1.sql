/*1
Create a cursor for Employee table that increases Employee salary by 10% 
if Salary <3000 and increases it by 20% if Salary >=3000. Use company DB
*/
declare c1 cursor
for select Salary from Employee	
for update
declare @sal int
open c1
fetch c1 into @sal
while @@FETCH_STATUS=0
	begin
		if @sal<3000	
			update Employee	
				set salary=@sal*0.1+@sal
			where current of c1
		else 
			update Employee	
				set salary=@sal*0.2+@sal
			where current of c1

		fetch c1 into @sal
	end
close c1
deallocate c1
select Salary from Employee;
-------------------------------------------------------------------------------
/*2
Display Department name with its manager name using cursor. Use ITI DB
*/
use ITI
declare c1 cursor
for 
	select d.Dept_Name,i.Ins_Name
	from Department d, Instructor i
	where i.Ins_Id=d.Dept_Manager
for read only
declare @depname varchar(30), @instname varchar(30)
open c1
fetch c1 into @depname, @instname
while @@FETCH_STATUS=0
	begin
	    select @depname,@instname
		fetch c1 into @depname, @instname
	end
close c1
deallocate c1
-------------------------------------------------------------------------------
/*3
Try to display all students first name in one cell separated by comma.
Using Cursor 
*/
declare c1 Cursor
for 
	select st_fname
    from student
    where st_fname is not NULL
for read only
declare @name varchar(20),@allnames varchar(500)=''
open c1
fetch c1 into @name
while @@FETCH_STATUS=0
	begin
		Set  @allnames=Concat(@allnames,', ',@name)
		fetch c1 into @name
	end
Select @allnames
close c1
deallocate c1
------------------------------------------------------------------------------
/*4
Create full, differential Backup for SD DB.
*/
------------------------------------------------------------------------------
/*5	
Use import export wizard to display students data (ITI DB) in excel sheet

iti-->tasks-->importdata
*/

------------------------------------------------------------------------------
/*6
Try to generate script from DB ITI that describes all tables and views in this DB

iti-->tasks-->generatescripts
*/
------------------------------------------------------------------------------
/*7
Create a sequence object that allow values from 1 to 10 without cycling in a 
specific column and test it.

*/
create sequence seq
start with 1
increment by 1
MinValue 1
MAxValue 10



create TABLE person1
(ID int,
FullName nvarchar(100) NOT NULL);

create TABLE person2
(ID int,
FullName nvarchar(100) NOT NULL);

INSERT into person1
VALUES (NEXT VALUE FOR seq, 'ahmed')

INSERT into person2
VALUES (NEXT VALUE FOR seq, 'ahmed1')


select * from person1
select * from person2
----------------------------------------------------------------------------------------




