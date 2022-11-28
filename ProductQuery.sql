CREATE TABLE Category
(
	Id INT PRIMARY KEY,
	"Name" nvarchar(100)
)

CREATE TABLE Product
(
	Id INT PRIMARY KEY,
	"Name" nvarchar(100)
)

CREATE TABLE Product_Categories
(
	Product_Id INT FOREIGN KEY REFERENCES Product(Id),
	Category_Id INT FOREIGN KEY REFERENCES Category(Id),
	PRIMARY KEY(Product_Id, Category_Id)
);

INSERT INTO Category VALUES
(1, 'Category1'),
(2, 'Category2'),
(3, 'Category3');

INSERT INTO Product VALUES
(1, 'Product1'),
(2, 'Product2'),
(3, 'Product3');

INSERT INTO Product_Categories VALUES
(1,1),
(1,2),
(1,3),
(2,2);

SELECT P.Name, C.Name FROM Product P
LEFT JOIN Product_Categories PC ON P.Id = PC.Product_Id
LEFT JOIN Category C ON C.Id = PC.Category_Id