CREATE DATABASE DB_QLKS
GO

USE DB_QLKS
GO

CREATE TABLE dbo.Employees (
	emp_id INT IDENTITY(1, 1) NOT NULL,
	firstname NVARCHAR(20) NULL,
	lastname NVARCHAR(20) NULL,
	email NVARCHAR(30) NULL,
	gender NVARCHAR(10) NULL,
	bdate DATETIME NULL,
	hdate DATETIME NULL,
	title NVARCHAR(20) NOT NULL,
	reportsto INT NULL,
	address NVARCHAR(30) NULL,
	photo IMAGE NULL
	
	CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED ([emp_id] ASC),
	CONSTRAINT [FK_Employees_Employees] FOREIGN KEY ([reportsto]) REFERENCES [dbo].[Employees] ([emp_id]),
	CONSTRAINT [CK_bdate] CHECK(DATEDIFF(year,bdate,getdate()) >= 18 AND DATEDIFF(year,bdate,getdate()) <= 60)
)
GO
ALTER TABLE Employees
ADD phone NVARCHAR(50) NULL;

-- Get id identity from table when insert employee
DROP PROCEDURE [dbo].[AddEmployeeReturnIDwithoutput];  
GO 

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddEmployeeReturnIDwithoutput]
	@fn NVARCHAR(20),
	@ln NVARCHAR(20) ,
	@eml NVARCHAR(30),
	@gdr NVARCHAR(10),
	@bdt DATETIME,
	@hdt DATETIME,
	@tle NVARCHAR(20),
	@adrs NVARCHAR(30),
	@pic IMAGE NULL,
	@phn NVARCHAR(50),
    @id int output
AS
BEGIN
      SET NOCOUNT ON;
      INSERT INTO  Employees (LastName, FirstName, Email, Title, Gender, BDate, HDate, Address, Phone, Photo)
      VALUES (@ln, @fn, @eml, @tle, @gdr, @bdt, @hdt, @adrs, @phn, @pic)
      SET @id=SCOPE_IDENTITY()
      RETURN  @id
END
--

CREATE TABLE dbo.Accounts (
	acc_id INT IDENTITY(1, 1) NOT NULL,
	username NVARCHAR(30) NOT NULL,
	password NVARCHAR(30) NOT NULL
	
	CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED ([acc_id] ASC)
)
GO
CREATE TABLE dbo.EmployeeAccounts (
	acc_id	INT NOT NULL,
	emp_id INT NOT NULL

	CONSTRAINT [PK_EmployeeAccounts] PRIMARY KEY NONCLUSTERED ([acc_id] ASC, [emp_id] ASC),
    CONSTRAINT [FK_EmployeeAccounts_Employees] FOREIGN KEY ([emp_id]) REFERENCES [dbo].[Employees] ([emp_id]),
    CONSTRAINT [FK_EmployeeAccounts_Accounts] FOREIGN KEY ([acc_id]) REFERENCES [dbo].[Accounts] ([acc_id])
)
GO

SELECT Accounts.acc_id, Employees.title
FROM Accounts, Employees, EmployeeAccounts
WHERE Accounts.acc_id = EmployeeAccounts.acc_id AND Employees.emp_id = EmployeeAccounts.emp_id

--ROOMS
CREATE TABLE dbo.RoomTypes (
	room_type_id INT NOT NULL,
	room_type_name NVARCHAR(30) NULL,
	room_capacity INT NULL,
	room_num_beds INT NULL,
	room_price INT NULL,
	CONSTRAINT [PK_RoomTypes] PRIMARY KEY CLUSTERED ([room_type_id] ASC)
)
GO

insert into dbo.RoomTypes (room_type_id, room_type_name, room_capacity, room_num_beds, room_price) values (1, 'Single', 1, 1, 300000)
insert into dbo.RoomTypes (room_type_id, room_type_name, room_capacity, room_num_beds, room_price) values (2, 'Double', 2, 2, 500000)
insert into dbo.RoomTypes (room_type_id, room_type_name, room_capacity, room_num_beds, room_price) values (3, 'Suite', 4, 4, 900000)
GO




CREATE TABLE dbo.RoomStatus (
	status_id BIT NOT NULL,
	status_name NVARCHAR(30) NULL
	CONSTRAINT [PK_RoomStatus] PRIMARY KEY CLUSTERED ([status_id] ASC)
)
GO
INSERT INTO dbo.RoomStatus (status_id, status_name) VALUES (0, 'Empty');
INSERT INTO dbo.RoomStatus (status_id, status_name) VALUES (1, 'Full');
CREATE TABLE dbo.Rooms (
	room_id INT IDENTITY(1, 1) NOT NULL,
	room_type_id INT NULL,
	status_id BIT
	
	CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED ([room_id] ASC),
	CONSTRAINT [FK_Rooms_RoomTypes] FOREIGN KEY ([room_type_id]) REFERENCES [dbo].[RoomTypes] (room_type_id),
	CONSTRAINT [FK_Rooms_RoomStatus] FOREIGN KEY ([status_id]) REFERENCES [dbo].[RoomStatus] (status_id),
)
GO

insert into Rooms (room_type_id, status_id) values (1, 0);
insert into Rooms (room_type_id, status_id) values (3, 0);
insert into Rooms (room_type_id, status_id) values (3, 0);
insert into Rooms (room_type_id, status_id) values (2, 0);
insert into Rooms (room_type_id, status_id) values (1, 0);
GO

--DGV ROOMS
Select room_id, room_type_name, room_capacity, room_num_beds, room_price, status_name
FROM Rooms, RoomTypes, RoomStatus
WHERE Rooms.room_type_id = RoomTypes.room_type_id and Rooms.status_id = RoomStatus.status_id
GO
Select room_capacity, room_num_beds, room_price 
                FROM RoomTypes 
                WHERE room_type_id = 1
--
--END ROOMS

DBCC CHECKIDENT ('Employees', RESEED, 1)  
DBCC CHECKIDENT ('Accounts', RESEED, 1)  
INSERT INTO Accounts VALUES ('admin', 1)
INSERT INTO EmployeeAccounts VALUES(1, 1)
INSERT INTO Employees VALUES ('Thanh', 'Trung', 'thanhtrung5763@gmail.com', 'Male', '2001-10-19', '2021-04-06', 'Admin', NULL, 'BH', NULL, '576-245-123')
INSERT INTO Accounts VALUES ('t', 1)
INSERT INTO EmployeeAccounts VALUES(3, 3)

INSERT INTO Employees VALUES ('Tuan', 'Tran', 'tuant3883@gmail.com', 'Male', '2001-10-19', '2021-04-06', 'Janitor', NULL, 'BH', 0xFFD8FFE000104A46494600010101000000000000FFE100764578696600004D4D002A00000008000187690004000000010000001A00000000000192860007000000420000002C00000000554E49434F4445000043006F006D00700072006500730073006500640020006200790020006A007000650067002D007200650063006F, '574-243-183')

Select Rooms.room_type_id, room_type_name From Rooms, RoomTypes Where Rooms.room_type_id = RoomTypes.room_type_id;
Delete From Rooms Where room_type_id = 7
Delete From RoomTypes Where room_type_name = 'President'


Create Table dbo.Shifts (
	shift_id INT  NOT NULL,
	shift_name NVARCHAR(30) NULL,
	time_start Time NULL,
	time_end Time NULL,
	num_manager INT NULL,
	num_receptionist INT NULL,
	num_janitor INT NULL

	CONSTRAINT [PK_Shifts] PRIMARY KEY CLUSTERED ([shift_id] ASC)
)
GO


Select * From Employees Where title='Manager'

Create Table dbo.Schedules (
	schedule_id INT NOT NULL,
	shift_id INT NOT NULL,
	emp_id INT NOT NULL,
	firstname NVarChar(20) NULL,
	lastname NVarChar(20) NULL,
	title NVarChar(30) NULL,
	date_start DateTime NULL,
	date_end DateTime NULL,
	Monday NVarChar(20) NUll,
	Tuesday NVarChar(20) NUll,
	Wednesday NVarChar(20) NUll,
	Thursday NVarChar(20) NUll,
	Friday NVarChar(20) NUll,
	Saturday NVarChar(20) NUll,
	Sunday NVarChar(20) NUll,

)
GO
Delete From dbo.Schedules
DROP TAble dbo.Schedules

Select * From dbo.Schedules

Select Count(distinct schedule_id) From dbo.Schedules