use master;
go
drop database if exists Sosu;
create database Sosu;
go
use Sosu;
go

set dateformat dmy;

-- Tables
create table Employees(
	EmployeeId int primary key identity(1,1) not null,
	Name nvarchar(max) not null,
	Initials nvarchar(10) not null,
);

create table Residents(
	ResidentId int primary key identity(1,1) not null,
	Name nvarchar(max) not null,
	RoomId nvarchar(10) not null,
);

create table Tasks(
	TaskId int primary key identity(1,1) not null,
	Title nvarchar(100) not null,
	Description nvarchar(max) not null,
	StartDate datetime not null,
	EndDate datetime not null,
	IsComplete bit default 0 not null,
	CompletedBy int foreign key references Employees(EmployeeId) null,
	ResidentId int foreign key references Residents(ResidentId) not null,
);

create table Notes(
	primary key(EmployeeId, TaskId),
	EmployeeId int foreign key references Employees(EmployeeId) not null, 
	TaskId int foreign key references Tasks(TaskId) not null,
	Note nvarchar(max) not null,
);

-- Values
insert into Employees(Name, Initials) values
	('Employee1', 'E1'),
	('Employee2', 'E2');

insert into Residents(Name, RoomId) values
	('Resident1', 'A1'),
	('Resident2', 'A2'),
	('Resident3', 'A3');

insert into Tasks(Title, Description, StartDate, EndDate, IsComplete, CompletedBy, ResidentId) values
	('Make the bed', 'Title', '19/06/2023 09:30:00.000', '19/06/2023 10:00:00.000', 0, null, 1),
	('Make the bed', 'Title', '19/06/2023 09:30:00.000', '19/06/2023 10:00:00.000', 1, 2, 3);

insert into Notes(EmployeeId, TaskId, Note) values
	(2, 2, 'Went smoothly'),
	(1, 1, 'I''ll do it');