create table Employee(empid int unique not null,empName varchar(50) not null,empDpt varchar(50) not null,Salary int not null)

 select * from Employee;

 insert into Employee values(8,'Sonal','Manager','12000'); 
 insert into Employee values(4,'Noha','Ast Manager','30010'); 
 insert into Employee values(5,'Priya','Finance','40000'); 
 insert into Employee values(6,'Ritambhra','HR','70000');

 select sum(salary) as Total_salary from Employee;
 select max(salary) as max_salary from Employee;
 select min(salary) as min_salary from Employee;
 select avg(salary) as avg_salary from Employee;
 select count(salary) as count_salary from Employee;

 drop table Employee;
