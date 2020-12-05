create table customer_tb1
(
c_id int primary key,
c_name varchar(50),
c_address varchar(max),
city varchar(50)
);



insert into customer_tb1 values(1,'Mona','anisabad no:2','hyderabad');
insert into customer_tb1 values(2,'sonu','anisabad no:3','jehanabad');
insert into customer_tb1 values(3,'sood','anisabad no:5','bangaluru');
insert into customer_tb1 values(4,'ponam','anisabad no:7','mangalore');

create table [order]/*if we want to write any name with keyword then then we use[]  */
(
order_id int primary key,
item varchar(50),
quantity int,
price_of_1 int,
c_id int foreign key references customer_tb1(c_id)/*creating fk while creating table(syntax)*/
);

insert into [order] values(111,'harddisk',2,500,1);
insert into [order] values(123,'disk',1,500,2);
insert into [order] values(113,'mouse',4,500,3);
insert into [order] values(114,'pc',3,500,4);

select * from customer_tb1;
select * from [order];

alter table [order] drop constraint FK__order__c_id__31EC6D26;/*deleteing fk constraint and relation b/w fk & pk now we can insert in order table with id that is not present in cstmr table */

alter table [order] add foreign key (c_id) references customer_tb1(c_id);/*add fk again after deleting*/

