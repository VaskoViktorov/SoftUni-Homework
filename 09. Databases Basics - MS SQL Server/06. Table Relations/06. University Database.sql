CREATE TABLE Majors
(
MajorID int PRIMARY KEY,
Name varchar(50)
)

CREATE TABLE Students
(
StudentID int PRIMARY KEY,
StudentNumber int,
StudentName varchar(50),
MajorID int FOREIGN KEY (MajorID) REFERENCES Majors(MajorID)
)

CREATE TABLE Payments
(
PaymentID int PRIMARY KEY,
PaymentDate date,
PaymentAmount decimal,
StudentID int FOREIGN KEY (StudentID) REFERENCES Students(StudentID)
)

CREATE TABLE Subjects
(
SubjectID int PRIMARY KEY,
SubjectName varchar(50)
)

CREATE TABLE Agenda
(
StudentID int,
SubjectID int,
CONSTRAINT PK_Agenda PRIMARY KEY(StudentID, SubjectID),
CONSTRAINT FK_Agenda_StudentID FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
CONSTRAINT FK_Agenda_SubjectID FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
)