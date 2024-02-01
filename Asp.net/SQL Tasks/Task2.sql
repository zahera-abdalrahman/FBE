CREATE DATABASE TASK_TWO;

GO

--Departments Table
CREATE TABLE Departments (
    DepartmentID INT,
    DepartmentName VARCHAR(255) NOT NULL,
	PRIMARY KEY (DepartmentID)
);

GO

--Employees Table
CREATE TABLE Employees (
    EmployeeID INT ,
    FirstName VARCHAR(255) NOT NULL,
    LastName VARCHAR(255) NOT NULL,
    Birthdate DATE,
    PhoneNumber VARCHAR(20),
    NationalID VARCHAR(20),
    Nationality VARCHAR(50),
    MaritalStatus VARCHAR(20),
    PersonalPhoto VARCHAR(MAX), 
    EntryDate DATE,
    Password VARCHAR(255),
    DepartmentID INT,
	PRIMARY KEY (EmployeeID),
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);

GO

--Manager Table
CREATE TABLE Manager (
    ManagerID INT,
	ManagerName VARCHAR(255),
    EmployeeID INT,
	PRIMARY KEY (ManagerID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);


GO
--Tasks Table
CREATE TABLE Tasks (
    TaskID INT ,
    TaskTitle VARCHAR(255) NOT NULL,
    StartDate DATE,
    DueDate DATE,
    TaskDescription VARCHAR(MAX),
    ImportanceLevel INT,
    EmployeeID INT,
	PRIMARY KEY(TaskID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

GO

--Feedback Table
CREATE TABLE Feedback (
    FeedbackID INT,
    SenderName VARCHAR(255) NOT NULL,
    SenderEmail VARCHAR(255) NOT NULL,
    FeedbackContent VARCHAR(MAX),
	EmployeeID INT,
	PRIMARY KEY (FeedbackID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);
