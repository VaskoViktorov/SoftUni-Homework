CREATE TABLE Directors 
(
Id int NOT NULL PRIMARY KEY,
DirectorName varchar(100) NOT NULL,
Notes varchar(255) 
)

CREATE TABLE Genres
(
Id int NOT NULL PRIMARY KEY,
GenreName varchar(100) NOT NULL,
Notes varchar(255) 
)

CREATE TABLE Categories
(
Id int NOT NULL PRIMARY KEY,
CategoryName varchar(100) NOT NULL,
Notes varchar(255) 
)

CREATE TABLE Movies
(
Id int NOT NULL PRIMARY KEY,
Title nvarchar(255) UNIQUE NOT NULL,
DirectorId int NOT NULL,
CopyrightYear int,
Length time,
GenreId int,
CategoryId int,
Rating int,
Notes varchar(255)
)

ALTER TABLE Movies
ADD CONSTRAINT FK_DirectorId FOREIGN KEY(DirectorId) REFERENCES Directors(Id)

ALTER TABLE Movies
ADD CONSTRAINT FK_GenreId FOREIGN KEY(GenreId) REFERENCES Genres(Id)

ALTER TABLE Movies
ADD CONSTRAINT FK_CategoryId FOREIGN KEY(CategoryId) REFERENCES Categories(Id)

INSERT INTO Directors(Id,DirectorName,Notes)
VALUES
	(1,'Joe','None'),
	(2,'Zoe','None'),
	(3,'Goe','Some notes'),
	(4,'Hoe','None'),
	(5,'Doe','Some more notes')

INSERT INTO Genres(Id,GenreName,Notes)
VALUES
	(1,'Comedy','None'),
	(2,'Horror','None'),
	(3,'Thriller','Some notes'),
	(4,'Drama','None'),
	(5,'Animated','Some more notes')

INSERT INTO Categories(Id,CategoryName,Notes)
VALUES
	(1,'5+','None'),
	(2,'12+','None'),
	(3,'16+','Some notes'),
	(4,'18+','None'),
	(5,'No restrictions','Some more notes')

INSERT INTO Movies(Id,Title,DirectorId,CopyrightYear,Length,GenreId,CategoryId,Rating,Notes)
VALUES
	(1,'Fun Title',2,'1995','02:00:05',3,1,8,'None'),
	(2,'Something',2,'2005','02:50:05',1,2,3,'None'),
	(3,'Cool',2,'2017','01:30:05',4,3,6,'None'),
	(4,'Some new title',2,'2001','02:50:05',5,4,7,'None'),
	(5,'Happy',2,'2000','01:00:05',2,5,10,'Some text')