create database SQLHandsOn
create table salesman
(
  salesman_id numeric(5) primary key,
  name varchar(30),
  city varchar(15),
  commission decimal(5,2)
  )

  insert into salesman values(5001,'james hoog','new york',0.15)
  insert into salesman values(5002,'nail knite','paris',0.13)
  insert into salesman values(5005,'pit alex','london',0.11)
  insert into salesman values(5006,'mc lyon','paris',0.14)
  insert into salesman values(5007,'paul adam','rome',0.13)
  insert into salesman values(5003,'lauson hen','san jose',0.12)

  create table customer
  (
    customer_id numeric(5) primary key,
	cust_name varchar(30),
	city varchar(15),
	grade numeric(3),
	salesman_id numeric(5) references salesman(salesman_id)
	)

	insert into customer values(3002,'nick raimando','new york',100,5001)
	insert into customer values(3007,'brad davis','new york',200,5001)
	insert into customer values(3005,'graham zusi','california',200,5002)
	insert into customer values(3008,'julian green','london',300,5002)
	insert into customer values(3004,'fabian johnson','paris',300,5006)
	insert into customer values(3009,'geoff cameron','berlin',100,5003)
	insert into customer values(3003,'jozy altidor','moscow',200,5007)
	insert into customer(customer_id,cust_name,city,salesman_id) values(3001,'brad guzan','london',5005)

	create table orders
	(
	  ord_no numeric(5) primary key,
	  purch_amt decimal(8,2),
	  ord_date date,
	  customer_id numeric(5) references customer(customer_id),
	  salesman_id numeric(5) references salesman(salesman_id)
	  )

	  insert into orders values(70001,150.5,'2012-10-05',3005,5002)
	  insert into orders values(70009,270.65,'2012-09-10',3001,5005)
	  insert into orders values(70002,65.26,'2012-10-05',3002,5001)
	  insert into orders values(70004,110.5,'2012-08-17',3009,5003)
	  insert into orders values(70007,948.5,'2012-09-10',3005,5002)
	  insert into orders values(70005,2400.6,'2012-07-27',3007,5001)
	  insert into orders values(70008,5760,'2012-09-10',3002,5001)
	  insert into orders values(70010,1983.43,'2012-10-10',3004,5006)
	  insert into orders values(70003,2480.4,'2012-10-10',3009,5003)
	  insert into orders values(70012,250.45,'2012-06-27',3008,5002)
	  insert into orders values(70011,75.29,'2012-08-17',3003,5007)

--1)
   select * from salesman

--2)
   select name,commission
   from salesman

--3)
   select ord_date,salesman_id,ord_no,purch_amt
   from orders

--4)
   select name,city
   from salesman
   where city = 'paris'

--5)
    select customer_id,cust_name,city,grade,salesman_id
	from customer
	where grade = 200

--6)
   select ord_no,ord_date,purch_amt,salesman_id
   from orders
   where salesman_id = 5001

--7)
   select avg(purch_amt) as 'AveragePurchaseAmount'
   from orders

--8)
   select count(*) as 'Number of Salesman'
   from salesman

--9)
   select count(*) as 'Number of Customers'
   from customer

--10)
    select max(purch_amt) as 'Maximum Purchase Amount'
	from orders

--11)
    select city, max(grade) as 'Maximum Grade of the City'
	from customer
	group by city

--12)
     select customer_id, max(purch_amt) as 'Maximum Purchase Amount'
	 from orders
	 group by customer_id

















