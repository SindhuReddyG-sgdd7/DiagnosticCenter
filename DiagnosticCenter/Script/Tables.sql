use diagnosticCenter
create table UserLogin
(
	username varchar(20),
	userpwd varchar(50),
	userrole varchar(20) default 'Patient'
)
sp_help AddStaff
sp_help PatientRegistration
drop table PatientRegistration
use diagnosticcenter
create table PatientRegistration
(
	UserName varchar(20),
	UserPwd varchar(50),
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

drop table AddStaff
create table AddStaff
(
	UserName varchar(20),
	UserPwd varchar(50),
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

create table BookAppointment
(
	UserName varchar(20),
	ServiceType varchar(20),
	AppointmentDate varchar(20),
	RFV	varchar(20),
	Gender varchar(10),
	SlotTime varchar(20),
	Status varchar(10),
	AppointmentID varchar(20)
)

insert into BookAppointment(UserName,AppointmentDate) values('Ram','11-12-1993')

select * from BookAppointment
drop table BookAppointment
create table AddPatient
(
	UserName varchar(20),
	PatientName varchar(20),
	Gender varchar(10),
	PatientAge int,
	TestType varchar(20),
	ReferredDoctor varchar(20),
)
	
create proc AddPatientDetails
	@UserName varchar(20),
	@PatientName varchar(20),
	@Gender varchar(10),
	@PatientAge int,
	@TestType varchar(20),
	@ReferredDoctor varchar(20)
as
insert into AddPatient values
(@UserName,@PatientName,@Gender,@PatientAge,@TestType,@ReferredDoctor
)
drop table AddPatient
use DiagnosticCenter	
	
	select * from addstaff
	
	select * from BookAppointment
	
	delete  from AddPatient
	
	
	alter table BookAppointment
	
	select * from UserLogin
	
	delete from addstaff where username = 'RP1186'
	use DiagnosticCenter
	sp_help changepasswordpatient
	
	create proc GetUserPwd