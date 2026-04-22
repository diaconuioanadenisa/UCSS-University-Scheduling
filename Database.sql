-- Crearea tabelelor
CREATE TABLE Teachers (
    TeacherID INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100),
    Department NVARCHAR(50)
);

CREATE TABLE Rooms (
    RoomID INT PRIMARY KEY IDENTITY(1,1),
    RoomNumber NVARCHAR(10),
    Capacity INT
);

CREATE TABLE Courses (
    CourseID INT PRIMARY KEY IDENTITY(1,1),
    CourseTitle NVARCHAR(100),
    Credits INT
);

CREATE TABLE Timetable (
    ID INT PRIMARY KEY IDENTITY(1,1),
    TeacherID INT FOREIGN KEY REFERENCES Teachers(TeacherID),
    RoomID INT FOREIGN KEY REFERENCES Rooms(RoomID),
    CourseID INT FOREIGN KEY REFERENCES Courses(CourseID),
    TimeSlot NVARCHAR(50) -- ex: 'Monday 08:00-10:00'
);
