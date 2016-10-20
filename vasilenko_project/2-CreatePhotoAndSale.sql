USE ShopAdo;

IF OBJECT_ID('Photo', 'U') IS NOT NULL
   DROP TABLE Photo;


CREATE TABLE Photo
(
   PhotoId int identity PRIMARY KEY,
   GoodId int foreign key REFERENCES dbo.Good(GoodId), 
   PhotoPath NVARCHAR(200)  NOT NULL
)

IF OBJECT_ID('Sale', 'U') IS NOT NULL
   DROP TABLE Sale;

CREATE TABLE Sale
(
   SaleId int identity PRIMARY KEY,
   SaleDate DateTime not null DEFAULT(GetDate()),
   SaleNumber NVARCHAR(24)  NOT NULL,
   SaleSumma money not null DEFAULT(0)
)

IF OBJECT_ID('SalePos', 'U') IS NOT NULL
   DROP TABLE SalePos;


CREATE TABLE SalePos
(
   SalePosId int identity PRIMARY KEY,
   SaleId int foreign key REFERENCES dbo.Sale(SaleId), 
   GoodId int foreign key REFERENCES dbo.Good(GoodId), 
   GoodCount Numeric(18,3) not null,
   Summa money not null DEFAULT(0)
)