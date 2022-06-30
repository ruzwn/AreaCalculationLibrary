CREATE TABLE Products (
    Id INT PRIMARY KEY,
    Name VARCHAR(100)
);

CREATE TABLE Categories (
    Id INT PRIMARY KEY,
    Name VARCHAR(100)
);

CREATE TABLE ProductsCategories (
    ProductId INT REFERENCES Products(Id),
    CategoryId INT REFERENCES Categories(Id),
    PRIMARY KEY (ProductId, CategoryId)
);

SELECT P.Name, C.Name
FROM Products P
LEFT JOIN ProductsCategories PC
    on P.Id = PC.ProductId
LEFT JOIN Categories C
    on PC.CategoryId = C.Id;