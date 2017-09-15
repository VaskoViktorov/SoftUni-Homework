--1. Create Database, 2. Create Tables
CREATE TABLE Minions
(
Id int NOT NULL PRIMARY KEY,
Name nvarchar(50) NOT NULL,
Age int
)

CREATE TABLE Towns
(
Id int NOT NULL PRIMARY KEY,
Name nvarchar(50) NOT NULL,
)

--3. Alter Minions Table
ALTER TABLE Minions
ADD	CONSTRAINT FK_TownId FOREIGN KEY (TownId) REFERENCES Towns(Id)

--4. Insert Records in Both Tables
INSERT INTO Towns (Id, Name)
VALUES
	(1, 'Sofia'),
	(2, 'Plovdiv'),
	(3, 'Varna')

INSERT INTO Minions (Id, Name, Age, TownId)
VALUES 
	(1, 'Kevin', 22, 1),
	(2, 'Bob', 15, 3),
	(3, 'Steward', NULL, 2)

--5. Truncate Table Minions
TRUNCATE TABLE Minions

--6. Drop All Tables
DROP TABLE Minions