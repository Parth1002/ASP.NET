Create database Products

Use Products

Create table Products
(
Productid int identity(1,1) not null,
Name varchar(50) null,
[Description] varchar(500) null
)

Create table ProductsType
(
Productid int not null,
Producttype varchar(250) null,
)