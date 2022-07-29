CREATE TABLE Customers (
  id int NOT NULL PRIMARY KEY,
  CustomerName nvarchar(20),
)
CREATE TABLE Orders (
  id int NOT NULL PRIMARY KEY,
  CustomerId int NOT NULL,
  FOREIGN KEY (CustomerID) REFERENCES Customers (id),
)

INSERT INTO Customers (Id, Name) VALUES 
(1, 'Max'),
(2, 'Pavel'),
(3, 'Ivan'),
(4, 'Leonid');

INSERT INTO Orders (Id, CustomerId) VALUES
(1, 2),
(2, 4);

SELECT
  c.CustomerName
FROM Customers c
LEFT JOIN Orders o ON c.id = o.CustomerId
WHERE o.CustomerId IS NULL
ORDER BY CustomerName
