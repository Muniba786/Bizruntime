create table myEmployee(empid int not null,empName varchar(50) not null,empGender varchar(50) not null, empDpt varchar(50) not null,Salary int not null)

  insert into myEmployee values(1,'Sonal','female','Manager','12000'); 
 insert into myEmployee values(2,'Nohar','male','Ast Manager','30010'); 
 insert into myEmployee values(3,'Priyank','male','Finance','40000'); 
 insert into myEmployee values(4,'Ritambhra','female','HR','70000');

 create table myDptmnt(empid int not null,empName varchar(50) not null,empGender varchar(50) not null, empDpt varchar(50) not null,Salary int not null)

 insert into myDptmnt values(8,'Sonal','female','Manager','12000'); 
 insert into myDptmnt values(4,'Nohar','male','Ast Manager','30010'); 
 insert into myDptmnt values(5,'Priyank','male','Finance','40000'); 
 insert into myDptmnt values(6,'Ritambhra','female','HR','70000');

 select * from myDptmnt;
 select * from myEmployee;

 select * from myEmployee
 where empid in
 (select empid from myEmployee where Salary>30000 );

 select empName,empGender,Salary from myEmployee
 where empid in
 (select empid from myEmployee where empGender = 'male' );
