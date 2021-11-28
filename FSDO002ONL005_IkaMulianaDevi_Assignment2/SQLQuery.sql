create table customers (
	customerNumber int identity (1,1) primary key,
	customerName varchar(50),
	contactLastName varchar (15),
	contactFirstName varchar (15),
	phone int,
	addressLine1 varchar (50),
	addressLine2 varchar (50),
	city varchar (20),
	state varchar (15),
	postalCode int,
	country varchar (20),
	salesRepEmployeeNumber varchar (10),
	creditLimit varchar (10),
	);

/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [customerNumber]
      ,[customerName]
      ,[contactLastName]
      ,[contactFirstName]
      ,[phone]
      ,[addressLine1]
      ,[addressLine2]
      ,[city]
      ,[state]
      ,[postalCode]
      ,[country]
      ,[salesRepEmployeeNumber]
      ,[creditLimit]
  FROM [bank].[dbo].[customers]


create table products (
	productCode int identity (1,1) primary key,
	productName varchar (20) null,
	productLine varchar (20) null,
	productScale varchar (15) null,
	productVendor varchar (20) null,
	productDescription varchar (30) null,
	quantityInStock int null,
	buyPrice int null,
	MSRP varchar(15) null,
	foreign key (productLine) references productlines(productLine)
	);

/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [productCode]
      ,[productName]
      ,[productLine]
      ,[productScale]
      ,[productVendor]
      ,[productDescription]
      ,[quantityInStock]
      ,[buyPrice]
      ,[MSRP]
  FROM [bank].[dbo].[products]


create table productlines(
    productLine varchar(20) primary key,
    textDescription varchar(50) null, 
    htmlDescription varchar(50) null,
    images varbinary(max) null,
);

/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [productLine]
      ,[textDescription]
      ,[htmlDescription]
      ,[images]
  FROM [bank].[dbo].[productlines]


create table orders (
	orderNumber int identity (1,1) primary key,
	orderDate date null,
	requiredDate date,
	shippedDate date,
	status varchar (20),
	comments varchar (30),
	customerNumber int,
	foreign key (customerNumber) references customers(customerNumber)
);

/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [orderNumber]
      ,[orderDate]
      ,[requiredDate]
      ,[shippedDate]
      ,[status]
      ,[comments]
      ,[customerNumber]
  FROM [bank].[dbo].[orders]


create table orderdetail (
	orderNumber int ,
	productCode int,
	quantityOrdered int null,
	priceEach int null,
	orderLineNumber varchar (10) null,
	foreign key (orderNumber) references orders(orderNumber),
	foreign key (productCode) references products(productCode)
);	 

/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [orderNumber]
      ,[productCode]
      ,[quantityOrdered]
      ,[priceEach]
      ,[orderLineNumber]
  FROM [bank].[dbo].[orderdetail]


create table payments (
	customerNumber int,
	checkNumber int primary key,
	paymentDate date,
	amount int null,
	foreign key (customerNumber) references customers(customerNumber)
);

/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [customerNumber]
      ,[checkNumber]
      ,[paymentDate]
      ,[amount]
  FROM [bank].[dbo].[payments]


create table employee (
	employeeNumber int identity (1,1) primary key,
	lastName varchar (20) null,
	firstName varchar (20) null,
	extension varchar (20) null,
	email varchar (20) null,
	officeCode int,
	reportsTo int null,
	jobTitle varchar (25) null,
	foreign key (officeCode) references offices(officeCode),
	foreign key (reportsTo) references employee(employeeNumber),
);

/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [employeeNumber]
      ,[lastName]
      ,[firstName]
      ,[extension]
      ,[email]
      ,[officeCode]
      ,[reportsTo]
      ,[jobTitle]
  FROM [bank].[dbo].[employee]


create table offices (
	officeCode int identity (1,1) primary key,
	city varchar (20)null,
	phone int null,
	addressline1 varchar (20) null,
	addressline2 varchar (20) null,
	country varchar (20) null,
	postalCode int null,
	teritory varchar (20) null,
)

/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [officeCode]
      ,[city]
      ,[phone]
      ,[addressline1]
      ,[addressline2]
      ,[country]
      ,[postalCode]
      ,[teritory]
  FROM [bank].[dbo].[offices]