create table ProductType(
	TypeId int identity(1,1) primary key,
	ProductType varchar(100),
	AddedDate datetime,
	Modified datetime
)

create table TblProducts(
	ProductId int identity(1,1) primary key,
	ProductType int,
	ProductName varchar(100),
	Description varchar(max),
	Price decimal,
	Quntity int,
	AddedDate datetime,
	Modified datetime,
	FOREIGN KEY (ProductType) references ProductType(TypeId)
)

select * from ProductType

insert into ProductType(ProductType,AddedDate) values('Anjeer',getdate())
insert into ProductType(ProductType,AddedDate) values('Almond',getdate())
insert into ProductType(ProductType,AddedDate) values('Apricot',getdate())
insert into ProductType(ProductType,AddedDate) values('Cashew',getdate())
insert into ProductType(ProductType,AddedDate) values('Dates',getdate())
insert into ProductType(ProductType,AddedDate) values('Kismis',getdate())
insert into ProductType(ProductType,AddedDate) values('Kiwi',getdate())
insert into ProductType(ProductType,AddedDate) values('Pista',getdate())
insert into ProductType(ProductType,AddedDate) values('Walnuts',getdate())