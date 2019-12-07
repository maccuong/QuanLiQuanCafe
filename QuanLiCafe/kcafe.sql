Create database QuanLiQuanCafe
go
use QuanLiQuanCafe
go
----food
----table
----category
----account
----bill
----billinfo
create table tablefood
(
	id int identity primary key,
	nametable nvarchar(100),
	tatus nvarchar(50),
)
create table account
(
	username nvarchar(100) not null primary key,
	displayname nvarchar(100) not null default N'staff',
	
	passwordac nvarchar(200) not null default 123456,
	loaiacount int not null default 0,
)

create table foodcategrory
(
	id int identity primary key,
	nametable nvarchar(100),
)

create table food
(
	id int identity primary key not null,
	namefoood nvarchar(100) not null,
	idcategrory int not null,
	gia float ,
	constraint fk_food_categrory foreign key(idcategrory) references foodcategrory(id),
)

create table Bill
(
	id int identity primary key not null,
	datecheckIn date not null,
	datecheckout date,
	idtable int not null,
	tatus int not null default 0,----------1 la thanh toan r, 0 la chưa
	constraint fk_bill_talbe foreign key(idtable) references tablefood(id),
)


--------------------------
create table billInfo
(
	id int identity primary key not null,
	idbill int not null,
	idfood int not null,
	soluongfood int not null default 0,
	constraint fk_billinfo_bill foreign key(idbill) references Bill(id),
	constraint fk_billinfo_food foreign key(idfood) references food(id),

)

----------------------
insert into account
values ('chicuong',N'Chí Cường','123456',1)
INSERT INTO dbo.account
        ( username ,
          displayname ,
          passwordac ,
          loaiacount
        )
VALUES  ( N'kimthoa' , -- username - nvarchar(100)
          N'Kim Thoa' , -- displayname - nvarchar(100)
          N'123456' , -- passwordac - nvarchar(200)
          0  -- loaiacount - int
        )

SELECT * FROM dbo.account
go
-------------------------------------------

CREATE PROCEDURE GetAccountByUsername
@username nvarchar(100)
as
BEGIN
	SELECT * FROM dbo.account WHERE username=@username
END
GO
EXEC dbo.GetAccountByUsername @username = N'chicuong' -- nvarchar(100)
--------------------------insert table food
INSERT INTO dbo.food
        (  namefoood, idcategrory, gia )
VALUES  ( -- id - int
          N'Cá hồi vây xanh', -- namefoood - nvarchar(100)
          1, -- idcategrory - int
          750000  -- gia - float
          )
INSERT INTO dbo.food
        (  namefoood, idcategrory, gia )
VALUES  ( 
          N'Bò né', -- namefoood - nvarchar(100)
          1, -- idcategrory - int
          150000  -- gia - float
          )
INSERT INTO dbo.food
        ( namefoood, idcategrory, gia )
VALUES  ( 
          N'Tôm hùm đại dương', -- namefoood - nvarchar(100)
          1, -- idcategrory - int
          550000  -- gia - float
          )
INSERT INTO dbo.food
        ( namefoood, idcategrory, gia )
VALUES  (
          N'Cua hoàng đế', -- namefoood - nvarchar(100)
          1, -- idcategrory - int
          650000  -- gia - float
          )
------------------------------------------
INSERT INTO dbo.foodcategrory
        ( nametable )
VALUES  ( N'Món biển'  -- nametable - nvarchar(100)
          )

INSERT INTO dbo.foodcategrory
        ( nametable )
VALUES  ( N'Món Rừng'  -- nametable - nvarchar(100)
          )

INSERT INTO dbo.foodcategrory
        ( nametable )
VALUES  ( N'Nước uống'  -- nametable - nvarchar(100)
          )
------------------------------
SELECT * FROM dbo.account WHERE username=N'chicuong ' AND passwordac = '' OR 1=1--
go
-------------------------
CREATE PROCEDURE USP_Login
@username nvarchar(100), @password nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.account WHERE username=@username AND passwordac=@password
END
GO
-------------------thêm bàn--------------
DECLARE @i INT=1
WHILE @i<=10
BEGIN
	INSERT INTO dbo.tablefood	
	        ( nametable,tatus)VALUES  (  N'Bàn' + CAST(@i AS NVARCHAR(100)), N'Trống')
			SET @i= @i+1
END
GO
-----------
DECLARE @i INT=11
WHILE @i<=12
BEGIN
	INSERT INTO dbo.tablefood	
	        ( nametable,tatus)VALUES  (  N'Bàn' + CAST(@i AS NVARCHAR(100)), N'Trống')
			SET @i= @i+1
END
GO
--------------
SELECT * FROM dbo.tablefood
GO
---------------------
CREATE PROCEDURE USP_Tablefood
AS SELECT * FROM dbo.tablefood
GO
----------
EXEC dbo.USP_Tablefood

-----------
UPDATE dbo.tablefood SET tatus=N'Có người' WHERE id=13
------------------------------------------------------
SELECT * FROM dbo.Bill
GO
SELECT * FROM dbo.billInfo
GO
SELECT * FROM dbo.food
GO
SELECT * FROM dbo.foodcategrory
GO
--------------------------------
INSERT INTO dbo.foodcategrory
        ( nametable )
VALUES  ( N'Nông sản')
-------thêm món ăn menu id=1
INSERT INTO dbo.food
        ( namefoood, idcategrory, gia )
VALUES  ( N'Bắp cải xào', -- namefoood - nvarchar(100)
          4, -- idcategrory - int
          50000  -- gia - float
          )
GO
INSERT INTO dbo.food
        ( namefoood, idcategrory, gia )
VALUES  ( N'Mực một nắng', -- namefoood - nvarchar(100)
          1, -- idcategrory - int
          250000  -- gia - float
          )   
GO
----------------menu id=2------------------
INSERT INTO dbo.food
        ( namefoood, idcategrory, gia )
VALUES  ( N'Heo rừng nướng', -- namefoood - nvarchar(100)
          2, -- idcategrory - int
          500000  -- gia - float
          )
GO
INSERT INTO dbo.food
        ( namefoood, idcategrory, gia )
VALUES  ( N'Thịt nai gu ti', -- namefoood - nvarchar(100)
          2, -- idcategrory - int
          40000  -- gia - float
          )
GO
INSERT INTO dbo.food
        ( namefoood, idcategrory, gia )
VALUES  ( N'Nhím ca ry', -- namefoood - nvarchar(100)
          2, -- idcategrory - int
          200000  -- gia - float
          )
GO
INSERT INTO dbo.food
        ( namefoood, idcategrory, gia )
VALUES  ( N'Bò kho', -- namefoood - nvarchar(100)
          2, -- idcategrory - int
          100000  -- gia - float
          )
GO
INSERT INTO dbo.food
        ( namefoood, idcategrory, gia )
VALUES  ( N'Trâu gác bếp', -- namefoood - nvarchar(100)
          2, -- idcategrory - int
          150000  -- gia - float
          )
GO
-----------menu id=3
INSERT INTO dbo.food
        ( namefoood, idcategrory, gia )
VALUES  ( N'Bia 333', -- namefoood - nvarchar(100)
          3, -- idcategrory - int
          15000  -- gia - float
          )
GO
INSERT INTO dbo.food
        ( namefoood, idcategrory, gia )
VALUES  ( N'Bia Tiger', -- namefoood - nvarchar(100)
          3, -- idcategrory - int
          15000  -- gia - float
          )
GO
INSERT INTO dbo.food
        ( namefoood, idcategrory, gia )
VALUES  ( N'CoCa Cola', -- namefoood - nvarchar(100)
          3, -- idcategrory - int
          10000  -- gia - float
          )
GO
INSERT INTO dbo.food
        ( namefoood, idcategrory, gia )
VALUES  ( N'Nước suối', -- namefoood - nvarchar(100)
          3, -- idcategrory - int
          5000  -- gia - float
          )
INSERT INTO dbo.food
        ( namefoood, idcategrory, gia )
VALUES  ( N'Dừa tươi', -- namefoood - nvarchar(100)
          3, -- idcategrory - int
          20000  -- gia - float
          )
GO
----------menu id-4
INSERT INTO dbo.food
        ( namefoood, idcategrory, gia )
VALUES  ( N'Mì Xào rau muốn', -- namefoood - nvarchar(100)
          4, -- idcategrory - int
          50000  -- gia - float
          )
GO
INSERT INTO dbo.food
        ( namefoood, idcategrory, gia )
VALUES  ( N'Rau củ xào thập cẩm', -- namefoood - nvarchar(100)
          4, -- idcategrory - int
          50000  -- gia - float
          )
GO
-----------------thêm bill
INSERT INTO dbo.Bill
        ( datecheckIn ,
          datecheckout ,
          idtable ,
          tatus
        )
VALUES  ( GETDATE() , -- datecheckIn - date
          NULL , -- datecheckout - date
          13 , -- idtable - int
          1  -- tatus - int
        )
go
INSERT INTO dbo.Bill
        ( datecheckIn ,
          datecheckout ,
          idtable ,
          tatus
        )
VALUES  ( GETDATE() , -- datecheckIn - date
          null , -- datecheckout - date
          16 , -- idtable - int
          0  -- tatus - int
        )
GO
		INSERT INTO dbo.Bill
        ( datecheckIn ,
          datecheckout ,
          idtable ,
          tatus
        )
VALUES  ( GETDATE() , -- datecheckIn - date
          GETDATE() , -- datecheckout - date
          19 , -- idtable - int
          1  -- tatus - int
        )
GO 
----------inser billinfo
INSERT dbo.billInfo
        ( idbill, idfood, soluongfood )
VALUES  ( 1, -- idbill - int
          3, -- idfood - int
          2  -- soluongfood - int
          )
GO 
INSERT dbo.billInfo
        ( idbill, idfood, soluongfood )
VALUES  ( 1, -- idbill - int
          7, -- idfood - int
          1  -- soluongfood - int
          )
GO 
INSERT dbo.billInfo
        ( idbill, idfood, soluongfood )
VALUES  ( 1, -- idbill - int
         15, -- idfood - int
          1  -- soluongfood - int
          )
GO 
--------insert bill 2
INSERT dbo.billInfo
        ( idbill, idfood, soluongfood )
VALUES  ( 2, -- idbill - int
         15, -- idfood - int
          1  -- soluongfood - int
          )
GO 
INSERT dbo.billInfo
        ( idbill, idfood, soluongfood )
VALUES  ( 2, -- idbill - int
         3, -- idfood - int
          1  -- soluongfood - int
          )
GO 
INSERT dbo.billInfo
        ( idbill, idfood, soluongfood )
VALUES  ( 1, -- idbill - int
         15, -- idfood - int
          3  -- soluongfood - int
          )
GO 

----------insert billinfo 3
INSERT dbo.billInfo
        ( idbill, idfood, soluongfood )
VALUES  ( 3, -- idbill - int
         9, -- idfood - int
          1  -- soluongfood - int
          )
GO 

INSERT dbo.billInfo
        ( idbill, idfood, soluongfood )
VALUES  ( 3, -- idbill - int
         14, -- idfood - int
          3  -- soluongfood - int
          )
GO 