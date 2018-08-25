CREATE TABLE Manufacturers
(
ManufacturerID int PRIMARY KEY,
Name varchar(20) NOT NULL,
EstablishedOn date NOT NULL,
)

CREATE TABLE Models
(
ModelID int PRIMARY KEY,
Name varchar(20),
ManufacturerID int FOREIGN KEY (ManufacturerID) REFERENCES Manufacturers(ManufacturerID)
)

INSERT INTO Manufacturers(ManufacturerID,Name,EstablishedOn)
VALUES
	(1,'BMW','07/03/1916'),
	(2,'Tesla','01/01/2013'),
	(3,'Lada','01/05/1966')

INSERT INTO Models (ModelID,Name,ManufacturerID)
VALUES
	(101,'X1',1),
	(102,'i6',1),
	(103,'Model S',2),
	(104,'Model X',2),
	(105,'Model 3',2),
	(106,'Nova',3)

