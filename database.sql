-- 1. Drop Database if it exists (Start fresh)
USE master;
GO
IF EXISTS (SELECT name FROM sys.databases WHERE name = N'StudentOrganizerDB')
    DROP DATABASE StudentOrganizerDB;
GO

-- 2. Create Database
CREATE DATABASE StudentOrganizerDB;
GO

USE StudentOrganizerDB;
GO

-- 3. Create Users Table (For Login & Register)
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    Email NVARCHAR(100)UNIQUE,
    CreatedAt DATETIME DEFAULT GETDATE()
);
GO

-- 4. Create Courses Table
CREATE TABLE Courses (
    CourseID INT PRIMARY KEY IDENTITY(1,1),
    CourseName NVARCHAR(100) NOT NULL,
    CourseCode NVARCHAR(20),
    CreditHours INT,
    UserID INT NOT NULL, -- Foreign Key to link with User
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);
GO

-- 5. Create Tasks Table
CREATE TABLE Tasks (
    TaskID INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(100) NOT NULL,
    Description NVARCHAR(MAX),
    Deadline DATETIME,
    IsCompleted BIT DEFAULT 0, -- 0 = Pending, 1 = Completed
    CourseID INT NOT NULL, -- Foreign Key to link with Course
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID) ON DELETE CASCADE
);
GO

-- 6. Create Notes Table
CREATE TABLE Notes (
    NoteID INT PRIMARY KEY IDENTITY(1,1),
    Content NVARCHAR(MAX) NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE(),
    CourseID INT NOT NULL, -- Foreign Key to link with Course
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID) ON DELETE CASCADE
);
GO

-- 7. Create Grades Table
CREATE TABLE Grades (
    GradeID INT PRIMARY KEY IDENTITY(1,1),
    ExamName NVARCHAR(50), -- e.g., Midterm, Final
    Score FLOAT NOT NULL,
    MaxScore FLOAT NOT NULL,
    CourseID INT NOT NULL, -- Foreign Key to link with Course
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID) ON DELETE CASCADE
);
GO