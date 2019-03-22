CREATE PROCEDURE CategorizedProduct_Insert
@ProductName nvarchar(50) NOT NULL,
@CategoryName nvarchar(50) NOT NULL
as
BEGIN
	DECLARE @ProductId int
	DECLARE @CategoryId int

	SELECT @ProductId = ProductId FROM Products WHERE ProductName = @ProductName
	SELECT @CategoryId = CategoryId FROM Categories WHERE CategoryName = @CategoryName

	IF (@ProductId IS NULL)
	BEGIN
		INSERT INTO Products VALUES(@ProductName)
		SELECT @ProductId = SCOPE_IDENTITY()
	END

	IF (@CategoryId IS NULL)
	BEGIN
		INSERT INTO Categories VALUES(@CategoryName)
		SELECT @CategoryId = SCOPE_IDENTITY()
	END

	INSERT INTO CategorizedProducts VALUES(@ProductId, @CategoryId)
END