CREATE TABLE Categories
(
Id int PRIMARY KEY NOT NULL,
CategoryName varchar(30) NOT NULL,
DailyRate numeric(3,2) NOT NULL,
WeeklyRate numeric(3,2) NOT NULL,
MonthlyRate numeric(3,2) NOT NULL,
WeekendRate numeric(3,2) NOT NULL,
)

CREATE TABLE Cars
(
Id int PRIMARY KEY NOT NULL,
PlateNumber int UNIQUE NOT NULL,
Manufacturer varchar(50) NOT NULL,
Model varchar(50) NOT NULL,
CarYear int,
CategoryId int,
Doors int,
Picture varbinary,
Condition varchar(100),
Available bit,
CONSTRAINT FK_CategoryId FOREIGN KEY(CategoryId) REFERENCES Categories(id)
)


CREATE TABLE Employees
(
Id int PRIMARY KEY NOT NULL,
FirstName varchar(50) NOT NULL,
LastName varchar(50) NOT NULL,
Title varchar(50),
Notes varchar(50)
)

CREATE TABLE Customers
(
Id int PRIMARY KEY NOT NULL,
DriverLicenceNumber int UNIQUE NOT NULL,
FullName nvarchar(200) NOT NULL,
Address varchar(255),
City nvarchar(255),
ZIPCode int,
Notes nvarchar(255)
)

CREATE TABLE RentalOrders
(
Id int PRIMARY KEY NOT NULL,
EmployeeId int NOT NULL,
CustomerId int NOT NULL,
CarId int NOT NULL,
TankLevel numeric(4,2) NOT NULL,
KilometrageStart numeric(10,2) NOT NULL,
KilometrageEnd numeric (10,2) NOT NULL,
TotalKilometrage numeric (10,2) NOT NULL,
StartDate date NOT NULL,
EndDate date NOT NULL,
TotalDays int NOT NULL,
RateApplied money NOT NULL,
TaxRate numeric(4,2) NOT NULL,
OrderStatus bit NOT NULL,
Notes nvarchar(255),
CONSTRAINT FK_EmployeeId FOREIGN KEY (EmployeeId) REFERENCES Employees(id), 
CONSTRAINT FK_CustomerId FOREIGN KEY (CustomerId) REFERENCES Customers(id), 
CONSTRAINT FK_CarId FOREIGN KEY (CarId) REFERENCES Cars(id) 
)


INSERT INTO Categories(Id,CategoryName,DailyRate,WeeklyRate,MonthlyRate,WeekendRate)
VALUES
	(1,'Cars',8,8.7,8.5,9),
	(2,'Trucks',5,5.7,5.5,5.5),
	(3,'Vans',4,4.7,4.5,5)

INSERT INTO Cars(id,PlateNumber,Manufacturer,Model,CarYear,CategoryId,Doors,Picture,Condition,Available)
VALUES
	(1,1045,'Toyota','XS5',2005,1,4,10101,'New',0),
	(2,2145,'BMW','XS3',2006,1,3,10001,'Used',0),
	(3,4045,'Toyota','XS1',2015,1,2,00101,'New',1)

INSERT INTO Employees(Id,FirstName,LastName,Title,Notes)
VALUES
	(1,'Joe','Jonson','Boss',NULL),
	(2,'Bill','Jonson','Marketing',NULL),
	(3,'Hugo','Jonson','Cleaner',NULL)

INSERT INTO Customers(id,DriverLicenceNumber,FullName,Address,City,ZIPCode,Notes)
VALUES
	(1,1040,'Bill Bilson',NULL,'Vancuver',2003,NULL),
	(2,5540,'Jill Bilson',NULL,'Vancuver',2053,NULL),
	(3,2040,'Hill Bilson',NULL,'Vancuver',6003,NULL)

INSERT INTO RentalOrders(id,EmployeeId,CustomerId,CarId,TankLevel,KilometrageStart,
KilometrageEnd,TotalKilometrage,StartDate,EndDate,TotalDays,RateApplied,TaxRate,OrderStatus,Notes)
VALUES
	(1,1,3,1,20,10056,10080,24,'2016/01/05','2016/02/05',1,20.55,10.00,1,NULL),
	(2,2,2,2,20,10066,10180,24,'2016/01/05','2016/02/05',1,50.55,10.00,1,NULL),
	(3,3,1,3,20,10056,10380,24,'2016/01/05','2016/02/05',1,620.55,10.00,1,NULL)