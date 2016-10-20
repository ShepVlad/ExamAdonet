--ALTER TABLE dbo.Good ADD CONSTRAINT GoodCount_Check CHECK (GoodCount>=0) 
IF OBJECT_ID('InsertSale', 'P') IS NOT NULL
   DROP PROCEDURE InsertSale;
GO   
CREATE PROCEDURE InsertSale
    @SaleNumber nvarchar(24),
    @SaleId int OUTPUT
AS
BEGIN
  INSERT INTO Sale(SaleNumber)
  VALUES (@SaleNumber);
  SET @SaleId = SCOPE_IDENTITY();

END
GO

IF OBJECT_ID('InsertSalePos', 'P') IS NOT NULL
   DROP PROCEDURE InsertSalePos;
   
GO   
CREATE PROCEDURE InsertSalePos
   @SaleId INT, 
   @GoodId INT, 
   @GoodCount NUMERIC(18,3)
AS
BEGIN
   DECLARE @Price money = (SELECT Price
                           FROM dbo.Good
                           WHERE GoodId = @GoodId);
   BEGIN TRAN
     BEGIN TRY
   
	   UPDATE dbo.Good
	   SET
	   GoodCount = GoodCount - @GoodCount
	   WHERE GoodId=@GoodId;
	   
	   INSERT INTO dbo.SalePos(SaleId, GoodId, GoodCount, Summa)
	   VALUES (@SaleId, @GoodId, @GoodCount, @GoodCount * @Price);
	   
	   UPDATE dbo.Sale
	   SET SaleSumma = SaleSumma + @GoodCount * @Price
	   WHERE SaleId = @SaleId;
	   COMMIT;
     END TRY
     BEGIN CATCH
       ROLLBACK;
     END CATCH
   
END
GO
   