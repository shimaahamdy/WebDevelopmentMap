select dep.Dependent_name, dep.Sex
from Dependent dep inner join Employee emp
on emp.SSN = dep.ESSN and emp.Sex='F' and dep.Sex='F'
union 
select dep.Dependent_name, dep.Sex
from Dependent dep inner join Employee emp
on emp.SSN = dep.ESSN and emp.Sex='M' and dep.Sex='M';


select proj.Pname, sum(work.Hours)*7
from Project proj, Works_for work
where proj.Pnumber=work.Pno
group by proj.Pname

/* 3 */
select dep.* from Departments dep, Employee e
where dep.Dnum = e.Dno and e.SSN=(select min(SSN) from Employee);




select dep.Dname, max(emp.Salary), min(emp.Salary) , avg(emp.Salary)
from Departments dep inner join Employee emp
on dep.Dnum=emp.Dno
group by dep.Dname;

/*  5   */
select e.Lname 
from Employee e inner join Departments d
on e.SSN=d.MGRSSN and d.MGRSSN not in 
(select Essn from Dependent );


select d.Dname, d.Dnum, count(e.SSN)
from Departments d, Employee e
where d.Dnum=e.Dno
group by d.Dnum, d.Dname
having avg(e.Salary)<
(select avg(Salary) from Employee);


select e.Fname,e.Lname ,p.Pname
from Employee e, Project p, Works_for w
where e.SSN=w.ESSn and p.Pnumber=w.Pno
order by e.Dno,e.Fname,e.Lname;


select salary from Employee
where salary <= (select max(e.Salary) from Employee e)
  and salary >=
  (select max(Salary) from Employee 
  where Salary not in (select max(e.Salary) from Employee e));


select e.Fname+''+e.Lname from Employee e
where e.Fname in 
(select d.Dependent_name from Dependent d);


update Employee
set Salary += Salary*0.30
where SSN in
(select SSN from Employee e, Works_for w , Project p
where e.SSN=w.ESSn and p.Pnumber=w.Pno and p.Pname='AL Rabwah');

select distinct e.SSN, e.Fname
from Employee e inner join Dependent d
on e.SSN=d.ESSN;

insert into Departments 
values('DEPT IT',100,112233,'1-11-2006');


update Departments
set MGRSSN=968574
where Dnum=100;

update Departments
set MGRSSN=102672
where Dnum=20;

update Employee
set Superssn=102672 , Dno=20
where SSN=102660;


update Departments
set MGRSSN=102672
where MGRSSN=223344;

delete Dependent
where ESSN=223344;

update Employee
set Superssn=102672
where Superssn=223344;

update Works_for
set ESSn=102672
where ESSn=223344;

delete Employee
where SSN=223344;

