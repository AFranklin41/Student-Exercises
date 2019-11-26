-- INSERT INTO Student (FirstName, LastName, SlackHandle, Cohort_Id) VALUES ('Steve', 'Evets', 'Stevers', 1);
-- INSERT INTO Student (FirstName, LastName, SlackHandle, Cohort_Id) VALUES ('Frank', 'Knarf', 'Frankers', 1);
-- INSERT INTO Student (FirstName, LastName, SlackHandle, Cohort_Id) VALUES ('Jim', 'Mij', 'Jimmers', 1);
-- INSERT INTO Student (FirstName, LastName, SlackHandle, Cohort_Id) VALUES ('Casey', 'Yesac', 'Casers', 2);
-- INSERT INTO Student (FirstName, LastName, SlackHandle, Cohort_Id) VALUES ('Beth', 'Hteb', 'Bethers', 2);
-- INSERT INTO Student (FirstName, LastName, SlackHandle, Cohort_Id) VALUES ('Riley', 'Yelir', 'Rilers', 3);
-- INSERT INTO Student (FirstName, LastName, SlackHandle, Cohort_Id) VALUES ('John', 'Nhoj', 'Johners', 3);
-- INSERT INTO Student (FirstName, LastName, SlackHandle, Cohort_Id) VALUES ('Samantha', 'Ahtnamas', 'Samanthers', 3);

-- SELECT * FROM Student

-- INSERT INTO Cohort (Cohort_Name) VALUES ('Cohort One');
-- INSERT INTO Cohort (Cohort_Name) VALUES ('Cohort Two');
-- INSERT INTO Cohort (Cohort_Name) VALUES ('Cohort Three');

-- SELECT * FROM Cohort

--  INSERT INTO Instructor (FirstName, LastName, SlackHandle, Cohort_Id) VALUES ('Garth', 'Brooks', 'Garthington', 1);
--  INSERT INTO Instructor (FirstName, LastName, SlackHandle, Cohort_Id) VALUES ('Steve', 'Casebolt', 'Racecarguy31', 1);
--  INSERT INTO Instructor (FirstName, LastName, SlackHandle, Cohort_Id) VALUES ('Lady', 'Gaga', 'Crazy', 2);
--  INSERT INTO Instructor (FirstName, LastName, SlackHandle, Cohort_Id) VALUES ('Anthony', 'Bourdain', 'Toosoon', 2);
--  INSERT INTO Instructor (FirstName, LastName, SlackHandle, Cohort_Id) VALUES ('Gordon', 'Ramsay', 'Thelambisfuckinraw', 1);
--  INSERT INTO Instructor (FirstName, LastName, SlackHandle, Cohort_Id) VALUES ('Alexa', 'Amazon', 'Alexaplaydespacito', 3);
--  INSERT INTO Instructor (FirstName, LastName, SlackHandle, Cohort_Id) VALUES ('Ok', 'Google', 'okgoogle', 2);
--  INSERT INTO Instructor (FirstName, LastName, SlackHandle, Cohort_Id) VALUES ('George', 'Bush', 'foolmetwicewontfoolmeagain', 3);

-- SELECT * FROM Instructor

-- INSERT INTO Exercise (Exercise_Name, Programming_Language) VALUES ('Watched', 'React');
-- INSERT INTO Exercise (Exercise_Name, Programming_Language) VALUES ('FitPup', 'React');
-- INSERT INTO Exercise (Exercise_Name, Programming_Language) VALUES ('Fair Weather Friend', 'C#');
-- INSERT INTO Exercise (Exercise_Name, Programming_Language) VALUES ('Nutshell', 'JavaScript');
-- INSERT INTO Exercise (Exercise_Name, Programming_Language) VALUES ('Daily Journal', 'JavaScript');
-- INSERT INTO Exercise (Exercise_Name, Programming_Language) VALUES ('Bangazon', 'C#');


-- SELECT * FROM Student
-- SELECT * FROM Exercise

-- INSERT INTO Student_Exercise (StudentId, ExerciseId) VALUES (15, 1);
-- INSERT INTO Student_Exercise (StudentId, ExerciseId) VALUES (16, 1);
-- INSERT INTO Student_Exercise (StudentId, ExerciseId) VALUES (17, 2);
-- INSERT INTO Student_Exercise (StudentId, ExerciseId) VALUES (18, 2);
-- INSERT INTO Student_Exercise (StudentId, ExerciseId) VALUES (19, 3);
-- INSERT INTO Student_Exercise (StudentId, ExerciseId) VALUES (20, 3);
-- INSERT INTO Student_Exercise (StudentId, ExerciseId) VALUES (19, 4);
-- INSERT INTO Student_Exercise (StudentId, ExerciseId) VALUES (20, 4);
-- INSERT INTO Student_Exercise (StudentId, ExerciseId) VALUES (21, 5);
-- INSERT INTO Student_Exercise (StudentId, ExerciseId) VALUES (22, 6);

-- INSERT INTO Student_Exercise (StudentId, ExerciseId) VALUES (16, 2);
-- INSERT INTO Student_Exercise (StudentId, ExerciseId) VALUES (16, 3);

-- SELECT * FROM Student_Exercise

-- SELECT * FROM Student WHERE Cohort_Id = 2;

-- SELECT LastName FROM Student WHERE LastName LIKE 'A%' OR LastName LIKE 'Y%' ORDER BY LastName;

-- Select Exercise_Name, Student.FirstName FROM Exercise LEFT JOIN Student_Exercise ON Student_Exercise.ExerciseId = Exercise.Id LEFT JOIN Student ON Student.Id = Student_Exercise.StudentId;

-- SELECT StudentId FROM Student_Exercise JOIN Student ON Student.Id = Student_Exercise.StudentId GROUP BY StudentId ORDER BY COUNT(*) DESC LIMIT 3;

-- SELECT Exercise_Name, Student.FirstName, Cohort_Name 
-- FROM Exercise 
-- LEFT JOIN Student_Exercise 
-- ON Student_Exercise.ExerciseId = Exercise.Id 
-- LEFT JOIN Student 
-- ON Student.Id = Student_Exercise.StudentId
-- LEFT JOIN Cohort
-- ON Cohort.Id = Student.Cohort_Id
-- WHERE Student.Cohort_Id = 2