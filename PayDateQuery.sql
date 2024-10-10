USE Gym_management
ALTER TABLE Subscriptions
ADD PayDate DATE DEFAULT NULL
GO;
UPDATE Subscriptions
SET PayDate = EnrollmentStart
GO;
CREATE INDEX Name_Index
ON Trainers (Name);
GO;