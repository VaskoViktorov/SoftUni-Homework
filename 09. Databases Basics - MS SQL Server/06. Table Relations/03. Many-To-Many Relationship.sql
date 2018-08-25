CREATE TABLE Students
(
StudentID int PRIMARY KEY,
Name varchar(20) NOT NULL
)

CREATE TABLE Exams
(
ExamID int PRIMARY KEY,
Name varchar(20),
)

INSERT INTO Students(StudentID,Name)
VALUES
	(1,'Mila'),
	(2,'Toni'),
	(3,'Ron')

INSERT INTO Exams (ExamID,Name)
VALUES
	(101,'SpringMVC'),
	(102,'Neo4j'),
	(103,'Oracle 11g')

CREATE TABLE StudentsExams
(
StudentID int,
ExamID int,
CONSTRAINT PK_StudentsExams PRIMARY KEY(StudentID,ExamID),
CONSTRAINT FK_StudentsExams_StudentID FOREIGN KEY(StudentID) 
REFERENCES Students(StudentID),
CONSTRAINT FK_StudentsExams_ExamID FOREIGN KEY(ExamID) 
REFERENCES Exams(ExamID)
)

INSERT INTO StudentsExams VALUES
  (1, 101), 
  (1, 102), 
  (2, 101), 
  (3, 103), 
  (2, 102), 
  (2, 103)