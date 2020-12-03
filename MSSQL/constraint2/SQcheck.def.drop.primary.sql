 create table voter_list(voter_id int primary key,voter_Name varchar(50) not null,voter_age int not null check(voter_age>=18)/*default(18) --if there is not any age is provide then by default it is 18*/);

 select * from voter_list;
 insert into voter_list values(4,'Mona',21);
 /*if we try to execute it twice it will show error or if we try to execute 2 out of 3 details then agin it will show error of null as it works both not null and unique*/
insert into voter_list values(2,'sona',20);
insert into voter_list values(3,'Monu',12);


 drop table voter_list;
 /*so basiclly we use truncate to delete all details except its heading or columnn name and drop is used to delete the whole table*/

