--DROP DATABASE [School]
--CREATE DATABASE [School]

USE [School]
GO

CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Username] [nvarchar](100) NOT NULL,
	[PasswordHash] [nvarchar](4000),
	[PasswordSalt] [nvarchar](4000),
)
GO

CREATE TABLE [dbo].[Teachers](
	[TeacherId] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Name] [nvarchar](1000) NOT NULL,
	[UserId] [int]  NOT NULL
	FOREIGN KEY (UserId) REFERENCES Users(UserId)
)
GO

CREATE TABLE [dbo].[Subjects](
	[SubjectId] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Name] [nvarchar](1000) NOT NULL,
	TeacherId [int]  NOT NULL
	FOREIGN KEY (TeacherId) REFERENCES Teachers(TeacherId)
)
GO

CREATE TABLE [dbo].[Periods](
	[PeriodId] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[SubjectId] [int] NOT NULL,
	[Day] [int] NOT NULL,
	[PeriodNumber] [int]  NOT NULL
	FOREIGN KEY (SubjectId) REFERENCES Subjects(SubjectId)
)
GO

INSERT INTO Users(Username)
VALUES
('Adam'),
('Peter')

INSERT INTO Teachers (Name,UserId)
VALUES
('Adam', 1),
('Peter',2)

INSERT Subjects (Name, TeacherId)
VALUES
('Maths',1),
('English',2)

INSERT Periods (SubjectId,Day,PeriodNumber)
VALUES
(1,1,1),(1,1,2),(1,1,3),(1,1,4),(1,1,5),(1,1,6),(1,1,7),(1,1,8),
(1,2,1),(1,2,2),(1,2,3),(1,2,4),(1,2,5),(1,2,6),(1,2,7),(1,2,8),
(1,3,1),(1,3,2),(1,3,3),(1,3,4),(1,3,5),(1,3,6),(1,3,7),(1,3,8),
(2,4,1),(2,4,2),(2,4,3),(2,4,4),(2,4,5),(2,4,6),(2,4,7),(2,4,8),
(2,5,1),(2,5,2),(2,5,3),(2,5,4),(2,5,5),(2,5,6),(2,5,7),(2,5,8)