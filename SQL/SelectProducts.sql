SELECT ProductName, CategoryName
FROM Products
LEFT JOIN CategorizedProducts 
ON Products.ProductId = CategorizedProducts.ProductId
LEFT JOIN Categories 
ON Categories.CategoryId = CategorizedProducts.CategoryId

