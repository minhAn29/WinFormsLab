USE [master]
DROP DATABASE IF EXISTS SalesManagement
GO
CREATE DATABASE SalesManagement
GO 

USE SalesManagement
Go

CREATE TABLE Member(
	MemberId int primary key not null,
	Email varchar(100) not null,
	CompanyName varchar(40) not null,
	City varchar(15) not null,
	Country varchar (15) not null,
	Password varchar(30) not null
)
GO
INSERT INTO Member VALUES(1,N'minhan@gmail.com',N'Intel',N'NEWYORK',N'USA',N'minhan123');
INSERT INTO Member VALUES(2,N'trithinh@gmail.com',N'AMD',N'BEJING',N'CHINA',N'trithinh123');
INSERT INTO Member VALUES(3,N'thuytan@gmail.com',N'NVIDIA',N'TORONTO',N'CANADA',N'thuytan123');
INSERT INTO Member VALUES(4,N'giavinh@gmail.com',N'ASUS',N'SEOUL',N'KOREA',N'giavinh123');
GO

CREATE TABLE Product(
	ProductId int primary key not null,
	CategoryId int not null,
	ProductName varchar(40) not null,
	Weight varchar(20) not null,
	UnitPrice money not null,
	UnitslnStock int not null,
)
GO
INSERT INTO Product VALUES(1,1,N'Cereal',N'35',50,50);
INSERT INTO Product VALUES(2,1,N'Rasin',N'30',80,50);
INSERT INTO Product VALUES(3,2,N'Pork',N'50',70,50);
INSERT INTO Product VALUES(4,2,N'Tuna',N'45',60,50);
INSERT INTO Product VALUES(5,2,N'Beef',N'50',100,50);
INSERT INTO Product VALUES(6,1,N'Peach',N'40',80,50);
GO

CREATE TABLE "Order"( 
	OrderId int primary key not null,
	MemberId int not null,
	OrderDate datetime not null,
	RequiredDate datetime,
	ShippedDate datetime,
	Freight money,
	FOREIGN KEY (MemberId) REFERENCES Member(MemberId),
)
GO

CREATE TABLE OrderDetail(
	OrderId int not null,
	ProductId int not null,
	UnitPrice money not null,
	Quantity int not null,
	Discount float not null,
	FOREIGN KEY (ProductId) REFERENCES Product(ProductId),
	FOREIGN KEY (OrderId) REFERENCES "Order"(OrderId),
)
GO