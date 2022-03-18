/*
types: of joins:
-cross join:
     -Cartesian Product

-inner join
     -equi join

-outer join
      -Left join
	  -Right join
	  -full join

-self join
      -unary join
*/

/*to see primary key and foreign key */
-- if it is your database -> 
                             --database digaram
							 --choose digram dbo.database
							 --click on realtionship
							 --probertis

-- if it is not your database ->
							 --database
							 --proberties
							 --change owner -->se (sql admin)
 


--joins
--cross join
/* cartisan prduct like 2 for loop inside mutiple each row in column 1
in every row in column 2
ex:
        name          dname

	    ahmed           sd 
		nour            os
		mostafa         

cartisan product:
       6 rows
	   ahmed      sd
	   nour       sd
	   mostafa    sd
	   ahmed      os
	   nour       os
	   mostafa    os
*/
select st_fname,dept_name
from student s,department d

select st_fname,dept_name
from student s cross join department d



--inner join -equi join
--bring the matches between 2 tables according to PK , FK
--pk = fk
--equi join (because we use where and = operator)
select st_fname,dept_name
from student s,department d
where d.dept_id=s.dept_id

select st_fname,dept_name
from student ,department 
where department.dept_id=student.dept_id

--inner join
select st_fname,dept_name
from student s inner join department d
	on d.dept_id=s.dept_id

--outer join
--print all rows in table if it is not match with table 2
-- that means a normal inner join+extra data
--from left_table, right_table
--if you want all rows in left_table -->left outer join
--if you want all rows in right_table -->right outer join
--if you want all rows in both tables -->full outer join
--left outer join
select st_fname,dept_name
from student s left outer join department d
	on d.dept_id=s.dept_id

--right outer join
select st_fname,dept_name
from student s right outer join department d
	on d.dept_id=s.dept_id

--full outer join
select st_fname,dept_name
from student s full outer join department d
	on d.dept_id=s.dept_id

--self join
/* in self realtion ship ex -->emp,manger
id name manger_id
1   a       null
2   b        1
3   c        1
4   d        2

bring the table twice to be called twice in memory
according to your suppose who is parent , child
the real table in database -->child
the table that copied      -->parent
parent.id = child.id
*/

select stud.st_fname,super.*
from student stud,student super
where super.st_id=stud.st_super

select s.st_fname,s1.*
from student s inner join student s1
on s1.st_id=s.st_super

/* seld join could be inner, outer 

-------------------
--agg functions
--min,max,sum,avg,count
select *
from student

select count(*)
from student

select count(st_age)
from student


select sum(salary)
from instructor


select avg(salary)
from instructor


select dept_id,count(st_id)
from student
group by dept_id


select d.dept_id,dept_name,count(st_id)
from student s,department d
where d.dept_id=s.dept_id
group by d.dept_id,dept_name


select dept_id,count(st_id)
from student
group by dept_id
having count(st_id)>5


select dept_id,sum(salary)
from instructor
group by dept_id
having count(ins_id)=7


--sub query
select *
from student
where st_age>(select avg(st_age) from student)


select *,(select count(st_id) from student)
from student


--exists



--union [all]
select st_id,st_fname from student
union all
select ins_id,ins_name from instructor
