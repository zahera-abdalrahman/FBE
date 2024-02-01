CREATE DATABASE TASK_ONE;

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    FirstName VARCHAR(255) NOT NULL,
    LastName VARCHAR(255) NOT NULL,
    Email VARCHAR(255) UNIQUE,
    PhoneNumber VARCHAR(255),
);


GO
INSERT INTO Customers
VALUES
(1,'zainab','Fadi','zainab@gmail.com','12345'),
(2,'sara','abdalrahman','sara@gmail.com','12345');

GO



CREATE TABLE Orders (
    OrdersID INT PRIMARY KEY,
    OrderTotal Decimal,
	OrderDate Datetime
);


GO

INSERT INTO Orders
VALUES
(1,100.50,'2023-12-13 15:30:00'),
(2,200.50,'2023-12-14 15:30:00');



GO

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(255) NOT NULL,
	ProductImageUrl VARCHAR(255) NOT NULL,
	ProductPrice Decimal NOT NULL
);


GO

INSERT INTO Products
VALUES
(1,'Laptop','https://example.com/laptop.jpg',999.99),
(2,'Mobile','https://example.com/laptop.jpg',800.99);

GO


CREATE TABLE Employees(
	EmployeeID INT PRIMARY KEY,
	EmployeeFirstName VARCHAR(255) NOT NULL,
    EmployeeLastName VARCHAR(255) NOT NULL,
	EmployeeJobTitle VARCHAR(255) 
);

GO
INSERT INTO Employees
VALUES
(1,'Zahera','Alakash','Software Engineer');


