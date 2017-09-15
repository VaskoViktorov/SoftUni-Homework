--8.
CREATE TABLE Users
(
Id int UNIQUE IDENTITY,
Username varchar(30) UNIQUE NOT NULL,
Password varchar(26) NOT NULL,
ProfilePicture varbinary(900),
LastLoginTIme datetime,
isDeleted bit DEFAULT 0,
CONSTRAINT PK_Users PRIMARY KEY(Id),
CONSTRAINT CK_Users_isDeleted CHECK (isDeleted='0' OR isDeleted='1')
)

INSERT  INTO Users(Username,Password,ProfilePicture,LastLoginTime,isDeleted)
VALUES
	('Gosho','123',01010, '2016/01/18 00:10:50',0),
	('Ivan','1243',01010, '2016/01/18 00:10:50',0),
	('Pesho','12423',01010, '2016/01/18 00:10:50',0),
	('Tisho','1323',01010, '2016/01/18 00:10:50',0),
	('Gero','11123',01010, '2016/01/18 00:10:50',0)

--9.
ALTER TABLE Users
DROP CONSTRAINT PK_Users

ALTER TABLE Users
ADD CONSTRAINT PK_Users PRIMARY KEY (Id, Username)

--10.
ALTER TABLE Users
ADD CONSTRAINT CK_Users_Password CHECK (len(Password) >= 5)

--11.
ALTER TABLE Users
ADD CONSTRAINT DF_Users_LastLogin DEFAULT getdate() FOR LastLoginTime

--12.
ALTER TABLE Users
DROP CONSTRAINT PK_Users

ALTER TABLE Users
ADD CONSTRAINT PK_Users PRIMARY KEY (Id)

ALTER TABLE Users
ADD CONSTRAINT CK_Users_Username CHECK (len(Username) >= 3)