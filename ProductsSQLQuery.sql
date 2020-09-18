create table ProductType(
	TypeId int identity(1,1) primary key,
	ProductTypeText varchar(100),
	AddedDate datetime,
	Modified datetime
)

create table TblProducts(
	ProductId int identity(1,1) primary key,
	ProductType int,
	ProductName varchar(100),
	Description varchar(max),
	Price decimal,
	Quantity int,
	AddedDate datetime,
	Modified datetime,
	FOREIGN KEY (ProductType) references ProductType(TypeId)
)

alter table TblProducts
drop constraint FK__TblProduc__Produ__36B12243 

alter table ProductType
add ProductTypeText varchar(100)
--drop column ProductType
--add ProductTypeText varchar(100)

select * from ProductType
select * from TblProducts
insert into ProductType(ProductTypeText,AddedDate) values('Anjeer',getdate())
insert into ProductType(ProductTypeText,AddedDate) values('Almond',getdate())
insert into ProductType(ProductTypeText,AddedDate) values('Apricot',getdate())
insert into ProductType(ProductTypeText,AddedDate) values('Cashew',getdate())
insert into ProductType(ProductTypeText,AddedDate) values('Dates',getdate())
insert into ProductType(ProductTypeText,AddedDate) values('Kismis',getdate())
insert into ProductType(ProductTypeText,AddedDate) values('Kiwi',getdate())
insert into ProductType(ProductTypeText,AddedDate) values('Pista',getdate())
insert into ProductType(ProductTypeText,AddedDate) values('Walnuts',getdate())