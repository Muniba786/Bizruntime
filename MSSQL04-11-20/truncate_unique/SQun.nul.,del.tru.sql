use mysqlserver;
 
 create table Employee(empid int unique not null,empName varchar(50) not null,empDpt varchar(50) not null,Salary varchar(50) not null)

 select * from Employee;

 insert into Employee values(8,'Sonal','Manager','12000'); 
 insert into Employee values(4,'Noha','Ast Manager','30010'); 
 insert into Employee values(5,'Priya','Finance','40000'); 
 insert into Employee values(6,'Ritambhra','HR','70000'); 

 delete from Employee where EmpName = 'Noha';

 truncate table employee;

 update Employee set Salary = 60000 where empid = 8;
 update Employee set empName = 'Nuha' where empid = 4;
 update Employee set empName = 'Mona' where empid = 8;

