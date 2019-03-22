CREATE TABLE Categories
(
	[CategoryId] INT NOT NULL PRIMARY KEY IDENTITY,
	[CategoryName] NVARCHAR(40) NOT NULL
)
GO

CREATE TABLE Products
(
	[ProductId] INT NOT NULL PRIMARY KEY IDENTITY,
	[ProductName] NVARCHAR(40) NOT NULL
)
GO

CREATE TABLE CategorizedProducts
(	 
    [ProductId] INT NOT NULL, 
    [CategoryId] INT NOT NULL,
	CONSTRAINT PK_Categorized_Product PRIMARY KEY (ProductId, CategoryId),
	CONSTRAINT FK_Product FOREIGN KEY(ProductId) REFERENCES  Products (ProductId),
	CONSTRAINT FK_Category FOREIGN KEY(CategoryId) REFERENCES Categories (CategoryId)
)
GO

