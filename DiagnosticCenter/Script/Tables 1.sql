create table UserLogin
(
	username varchar(20),
	userpwd varchar(20),
	userrole varchar(20) default 'Patient'
)


create table PatientRegistration
(
	UserName varchar(20),
	UserPwd varchar(20),
	FirstName varchar(20),
	LastName varchar(20),
	Gender varchar(6),
	DOB	date,
	Age int,
	PhoneNo varchar(10),
	EMail varchar(20),
	Address varchar(50),
	City varchar(20),
	Pincode varchar(6)
)

create table AddStaff
(
	UserName varchar(20),
	UserPwd varchar(20),
	FirstName varchar(20),
	LastName varchar(20),
	Gender varchar(6),
	DOB	date,
	Age int,
	PhoneNo varchar(10),
	EMail varchar(20),
	Address varchar(50),
	City varchar(20),
	Pincode varchar(6),
	Qualification varchar(20),
	Experience int
)
use diagnosticcenter

sp_help AddStaff

create table BookAppointment
(
	UserName varchar(20),
	ServiceType varchar(20),
	AppointmentDate date,
	RFV	varchar(20),
	SlotTime varchar(20),
	Status varchar(10),
	AppointmentID varchar(20)
)

create table AddPatient
(
	UserName varchar(20),
	PatientName varchar(20),
	PatientAge int,
	TestType varchar(20),
	ReferredDoctor varchar(20),
)