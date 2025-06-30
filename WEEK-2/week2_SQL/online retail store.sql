CREATE TABLE Products1 (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10, 2)
);

INSERT INTO Products1 (ProductID, ProductName, Category, Price) VALUES
(1, 'Laptop', 'Electronics', 1200.00),
(2, 'Smartphone', 'Electronics', 800.00),
(3, 'Tablet', 'Electronics', 800.00),
(4, 'Headphones', 'Accessories', 150.00),
(5, 'Charger', 'Accessories', 150.00),
(6, 'USB Cable', 'Accessories', 50.00),
(7, 'Monitor', 'Electronics', 300.00),
(8, 'Mouse', 'Accessories', 100.00),
(9, 'Keyboard', 'Accessories', 100.00),
(10, 'Smartwatch', 'Electronics', 600.00);


-- ROW_NUMBER()
SELECT *
FROM (
    SELECT *,
           ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum
    FROM Products1
) AS Ranked
WHERE RowNum <= 3;



-- RANK()
SELECT *
FROM (
    SELECT *,
           RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS RankNum
    FROM Products1
) AS Ranked
WHERE RankNum <= 3;


-- DENSE_RANK()
SELECT *
FROM (
    SELECT *,
           DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRankNum
    FROM Products1
) AS Ranked
WHERE DenseRankNum <= 3;
