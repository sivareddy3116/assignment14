
create database InstituteDb
use InstituteDb


CREATE TABLE Category (
    Id INT PRIMARY KEY,
    Name NVARCHAR(50)
);

CREATE TABLE Course (
    Id INT PRIMARY KEY,
    Name NVARCHAR(50),
    Fee FLOAT,
    CourseCategory NVARCHAR(50) NOT NULL UNIQUE,
    StartDate DATETIME,
    CategoryId INT,
    FOREIGN KEY (CategoryId) REFERENCES Category(Id)
);
-- Sample data for Category table
INSERT INTO Category (Id, Name) VALUES
(1, 'Tech'),
(2, 'MBA'),
(3, 'English');

-- Sample data for Course table
INSERT INTO Course (Id, Name, Fee, CourseCategory, StartDate, CategoryId) VALUES
(1, 'Introduction to Programming', 100.0, 'Tech', '2023-12-28', 1),
(2, 'Business Strategy', 150.0, 'MBA', '2023-12-29', 2),
(3, 'English Literature', 80.0, 'English', '2023-12-30', 3);
