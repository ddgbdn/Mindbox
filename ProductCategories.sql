CREATE TABLE Categories (
	CategoryId int PRIMARY KEY IDENTITY,
	CategoryName nvarchar(50)
)

CREATE TABLE Products (
	ProductId int PRIMARY KEY IDENTITY,
	ProductName nvarchar(50),
)

CREATE TABLE ProductCategories (
	ProductId int FOREIGN KEY REFERENCES Products(ProductId),
	CategoryId int FOREIGN KEY REFERENCES Categories(CategoryId)
)

INSERT INTO Categories(CategoryName)
VALUES 
	('Dairy'),
	('Frozen'),
	('Meat')

INSERT INTO Products(ProductName)
VALUES
	('Ice Cream'),
	('Milk'),
	('Water'),
	('Chicken')

INSERT INTO ProductCategories
VALUES
	(1, 1),
	(1, 2),
	(2, 1),
	(4, 2),
	(4, 3)


SELECT 
	ProductName, 
	CategoryName
FROM 
	Products p
LEFT JOIN 
	ProductCategories pc
ON p.ProductId = pc.ProductId
LEFT JOIN 
	Categories c
ON pc.CategoryId = c.CategoryId
