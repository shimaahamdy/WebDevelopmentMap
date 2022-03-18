--1
Select count(St_Age) from Student;

--2
select distinct Ins_Name from Instructor;

--3
select s.St_Id as [Student ID],
ISNULL(s.St_Fname,'empty f1')+' '+ISNULL(s.St_Lname,'empty f2') as [Student Full Name],
ISNULL(d.Dept_Name,'no dep') as [Department name]
from Student s, Department d
where d.Dept_Id=s.Dept_Id;

--4
select ins.Ins_Name, dep.Dept_Name
from Instructor ins left join Department dep
on dep.Dept_Id=ins.Dept_Id;

--5
select s.St_Fname+' '+s.St_Lname as fullname,c.Crs_Name
from Student s,Stud_Course sc ,Course c
where s.St_Id=sc.St_Id and c.Crs_Id=sc.Crs_Id and sc.Grade is not NULL;

--6
select count(c.Crs_Id),t.Top_Name
from Course c,Topic t
where t.Top_Id=c.Top_Id
group by t.Top_Name;

--7
-- add salries
update Instructor
set Salary=3000;
update Instructor
set Salary=8000
where Ins_Id=3;
update Instructor
set Salary=1000
where Ins_Id=5;

select max(ins.Salary),min(ins.Salary)
from Instructor ins;

--8
select * from Instructor
where Salary < (select avg(ins.Salary) from Instructor ins);

--9
select dep.Dept_Name from Department dep
where dep.Dept_Id= (select top(1) ins.Dept_Id from Instructor ins order by ins.Salary);


--10
select distinct  top(2) Salary from Instructor
order by Salary desc;

--11
select ins.Ins_Name, coalesce(ins.Salary,'bonus')
from Instructor ins;

--12
select avg(ins.Salary) from Instructor ins;

--13
select s.St_Fname, super.*
from Student s inner join Instructor super
on super.Ins_Id=s.St_super;

--14
select  Salary
from (Select *,row_number() over( partition by dept_id order by Salary desc) as rn
      from Instructor) as ntable
where rn=1 or rn=2;

--15
select *
from (Select *,row_number() over(partition by dept_id order by newid()) as rn
      from Student) as ntable
where rn=1;

-------------------------------------------------
use AdventureWorks2012;

--1
select s.SalesOrderID, s.ShipDate
from AdventureWorks2012.Sales.SalesOrderHeader s
where s.OrderDate between '7/28/2002' and '7/29/2017' ;

--2
select p.ProductID, p.Name
from AdventureWorks2012.Production.Product p
where p.StandardCost<110;

--3
select p.ProductID, p.Name
from AdventureWorks2012.Production.Product p
where p.Weight is Null;

--4
select *
from AdventureWorks2012.Production.Product p
where p.Color in ('Silver','Black','Red');

--5
select *
from AdventureWorks2012.Production.Product p
where p.Name like 'B%';

--6
UPDATE Production.ProductDescription
SET Description = 'Chromoly steel_High of defects'
WHERE ProductDescriptionID = 3;

select pdesc.Description
from AdventureWorks2012.Production.ProductDescription pdesc
where pdesc.Description like ('%_%');

--7
select sum(s.TotalDue)
from Sales.SalesOrderHeader s
where s.OrderDate >= '7/1/2001' and s.OrderDate <'7/31/2014'
group by s.OrderDate;


--8
select distinct e.HireDate
from AdventureWorks2012.HumanResources.Employee e;

--9
select distinct avg(distinct(p.ListPrice))
from AdventureWorks2012.Production.Product p;

--10
select concat('the',p.Name ,'is only' ,p.ListPrice)
from AdventureWorks2012.Production.Product p
where p.ListPrice>=100 and p.ListPrice<=120;



--11

select s.rowguid, s.Name, s.SalesPersonID,s.Demographics
into store_Archive
from Sales.Store s;

select s.rowguid, s.Name, s.SalesPersonID,s.Demographics
into store_Archiv

select convert(varchar, getdate(), 1)
union 
select convert(varchar, getdate(), 3)
union
select convert(varchar, getdate(), 5)
union
select convert(varchar, getdate(), 6)
union
select convert(varchar, getdate(), 101)
union
select convert(varchar, getdate(), 23);