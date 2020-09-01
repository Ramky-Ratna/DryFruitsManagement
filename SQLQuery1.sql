create table TblProducts(
	ProductId int identity(1,1) primary key,
	ProductName varchar(100),
	Price decimal,
	Quantity int,
	AddedDate datetime,
	Modified datetime
)