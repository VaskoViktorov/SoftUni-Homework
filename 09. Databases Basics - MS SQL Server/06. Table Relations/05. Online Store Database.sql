CREATE TABLE Cities
(
CityID int PRIMARY KEY,
Name varchar(50)
)

CREATE TABLE Customers
(
CustomerID int PRIMARY KEY,
Name varchar(50),
Birthday date,
CityID int FOREIGN KEY (CityID) REFERENCES Cities(CityID)
)

CREATE TABLE Orders
(
OrderID int PRIMARY KEY,
CustomerID int FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerID)
)

CREATE TABLE ItemTypes
(
ItemTypeID int PRIMARY KEY,
Name varchar(50)
)
CREATE TABLE Items
(
ItemID int PRIMARY KEY,
Name varchar(50),
ItemTypeID int FOREIGN KEY (ItemTypeID) REFERENCES ItemTypes(ItemTypeID)
)

CREATE TABLE OrderItems
(
OrderID int,
ItemID int ,
CONSTRAINT PK_OrderItems PRIMARY KEY(OrderID,ItemID),
CONSTRAINT FK_OrderItems_OrderID FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
CONSTRAINT FK_OrderItems_ItemID FOREIGN KEY (ItemID) REFERENCES Items(ItemID)
)


