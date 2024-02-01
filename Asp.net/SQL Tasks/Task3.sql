CREATE DATABASE TASK_THREE;

-- Users table
CREATE TABLE Users (
    UserID INT PRIMARY KEY,
    UserName VARCHAR(50) NOT NULL,
    UserProfile VARCHAR(255),
);

-- Messages table
CREATE TABLE Messages (
    MessageID INT PRIMARY KEY,
    UserID INT,
    MessageText VARCHAR(1000) NOT NULL,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
);

-- Services table
CREATE TABLE Services (
    ServiceID INT PRIMARY KEY,
    ServiceName VARCHAR(50) NOT NULL,
    ServiceDescription VARCHAR(255),
    ServicePrice DECIMAL(10, 2) NOT NULL
);

CREATE TABLE User_Services (
	User_Services INT PRIMARY KEY,
    UserID INT,
    ServiceID INT,
    PaymentAmount DECIMAL(10, 2) NOT NULL,
    PaymentDate DATE,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (ServiceID) REFERENCES Services(ServiceID)
);

-- Payments table
CREATE TABLE Payments (
    PaymentID INT PRIMARY KEY,
    UserID INT,
    ServiceID INT,
    Amount DECIMAL(10, 2) NOT NULL,
    PaymentDate DATE,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (ServiceID) REFERENCES Services(ServiceID)
);


INSERT INTO Users (UserID, UserName, UserProfile) VALUES
(1, 'JohnDoe', 'Software Engineer'),
(2, 'JaneSmith', 'Marketing Specialist'),
(3, 'BobJohnson', 'Teacher');

INSERT INTO Messages (MessageID, UserID, MessageText) VALUES
(1, 1, 2, 'Hello Jane, how are you?'),
(2, 2, 1, 'Hi John, Im good. How about you?'),
(3, 1, 3, 'Hey Bob, do you have time for a chat?');

INSERT INTO Services (ServiceID, ServiceName, ServiceDescription, ServicePrice) VALUES
(1, 'Premium Messaging', 'Unlimited messaging with additional features', 9.99),
(2, 'Custom Emojis', 'Access to a variety of custom emojis', 2.99),
(3, 'Message Encryption', 'Secure your messages with end-to-end encryption', 4.99);

INSERT INTO User_Services (UserID, ServiceID, PaymentAmount, PaymentDate) VALUES
(1, 1, 9.99, '2023-01-01'),
(2, 1, 9.99, '2023-02-05'),
(3, 2, 2.99, '2023-03-10');

INSERT INTO Payments (PaymentID, UserID, ServiceID, Amount, PaymentDate) VALUES
(1, 1, 1, 9.99, '2023-01-01'),
(2, 2, 1, 9.99, '2023-02-05'),
(3, 3, 2, 2.99, '2023-03-10');


UPDATE Users SET UserProfile = 'Senior Software Engineer' WHERE UserID = 1;
UPDATE Messages SET MessageText = 'Hi John Im doing well. How about you?' WHERE MessageID = 2;
UPDATE Services SET ServicePrice = 14.99 WHERE ServiceID = 3;
UPDATE Payments SET Amount = 14.99 WHERE PaymentID = 3;


DELETE FROM Users WHERE UserID = 3;
DELETE FROM Messages WHERE MessageID = 3;
DELETE FROM Services WHERE ServiceID = 2;
DELETE FROM User_Services WHERE UserID = 2 AND ServiceID = 1;
DELETE FROM Payments WHERE PaymentID = 1;


EXEC sp_rename 'Users', 'ChatUsers';


ALTER TABLE Services
ALTER COLUMN ServiceName VARCHAR(100);

ALTER TABLE Payments
ALTER COLUMN PaymentAmount DECIMAL(10, 2);