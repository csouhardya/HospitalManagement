INSERT INTO Roles(Name) VALUES ('Admin'),('Doctor'),('Receptionist'),('Billing');

INSERT INTO Users(UserName, Password, RoleId, IsActive, CreatedOn)
VALUES
('admin','admin123',1,1,GETDATE()),
('doctor','doctor123',2,1,GETDATE()),
('disabled','disabled123',1,0,GETDATE());

INSERT INTO Doctors(Name, Specialization, IsActive, ConsultationDurationMinutes)
VALUES
('Dr Sharma','Cardiology',1,30),
('Dr Sen','Dental',1,15),
('Dr Inactive','Neurology',0,30);

INSERT INTO Patients(Name, DateOfBirth, Gender, Mobile, Email, InsuranceNumber, IsEmergency, IsDeleted, OutstandingAmount, CreatedOn)
VALUES
('Rahul Das','1990-01-01','Male','9999999999','rahul@test.com','INS001',0,0,0,GETDATE()),
('Rahul Das','1990-01-01','Male','9999999999','duplicate@test.com','INS002',0,0,0,GETDATE()),
('Future Baby','2035-01-01','Male','8888888888','future@test.com',NULL,1,0,0,GETDATE());

INSERT INTO Medicines(Name, IsDiscontinued, AllergyGroup, Price)
VALUES
('Paracetamol',0,'NONE',10),
('Penicillin',0,'PENICILLIN',25),
('OldMedicine',1,'NONE',50);

INSERT INTO Beds(WardName, BedNumber, IsOccupied)
VALUES
('General','G-101',0),
('General','G-102',1),
('ICU','ICU-1',0);