CREATE TABLE Passports
(
PassportId int PRIMARY KEY,
PassportNumber varchar(8)
)

CREATE TABLE Persons
(
PersonID int PRIMARY KEY,
FirstName varchar(50) NOT NULL,
Salary decimal NOT NULL,
PassportId int UNIQUE
CONSTRAINT FK_Persons_PassportId FOREIGN KEY (PassportId)
REFERENCES Passports(PassportId)
)

INSERT INTO Passports (PassportId,PassportNumber)
VALUES
	(101,'N34FG21B'),
	(102,'K65LO4R7'),
	(103,'ZE657QP2')

INSERT INTO Persons (PersonID,FirstName,Salary,PassportId)
VALUES
	(1,'Roberto',43300.00,102),
	(2,'Tom',56100.00,103),
	(3,'Yana',60200.00,101)