use DiagnosticCenter
create proc BookAppDetails
@PatientName varchar(20),
@Gender varchar(10),
@ServiceType varchar(20),
@AppointmentDate varchar(20),
@RFV	varchar(20),
@Status varchar(10)
as
insert into BookAppointment values
(@PatientName, @Gender, @ServiceType, @AppointmentDate, @RFV,
 @Status)
 drop proc BookAppDetails
 select * from PatientRegistration
 select * from BookAppointment
 
 drop table BookAppointment
 
 create table BookAppointment
(
	PatientName varchar(20),
	Gender varchar(10),
	ServiceType varchar(20),
	AppointmentDate varchar(20),
	RFV	varchar(20),
	Status varchar(10),
	AppointmentID int identity(10001,1)
)