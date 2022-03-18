select Dnum, Dname, MGRSSN, Fname 
from Departments, Employee
where SSN = MGRSSN;


select Dname, Pname from Departments as dep
inner join Project as proj
on  proj.Dnum = dep.Dnum;

select dep.* , fname
from Dependent dep ,Employee emp 
where SSN=ESSN;

select Pnumber, Pname, Plocation from Project
where City in ('Cairo', 'Alex') ;

select * from Project
where Pname like 'a%';

select * from Employee
where Dno=30 and Salary>=1000 and Salary<=2000;

select Fname from Employee e,Project p,Works_for w
where e.SSN=w.ESSn and p.Pnumber=w.Pno and e.Dno=10 and p.Pname='Al Rabwah' and 
w.Hours>=10 ;

select e.Fname from Employee e
inner join Employee m
on m.SSN=e.Superssn and m.Fname='Kamel' and m.Lname='Mohamed';
 
select Fname, Pname from Employee e , Works_for w, Project p
where (e.SSN = w.ESSn and p.Pnumber = w.Pno)
order by Pname;

select p.Pnumber, d.Dname,e.Lname,e.Address,e.Bdate
from Project p, Departments d, Employee e
where p.City='Cairo' and d.Dnum=p.Dnum and e.SSN=d.MGRSSN;

select e.* from Employee e, Departments
where SSN=MGRSSN;

select *from Employee e left join Dependent d
on e.SSN=d.ESSN;

insert into Employee values ('shimaa','hamdy',102672,NULL,'20,city','female',3000,112233,30);

insert into Employee (Dno,SSN,Superssn,Salary)
values (30,102662,112233,3000);

update Employee
set Salary+=(0.20*Salary)
where SSN=102672;