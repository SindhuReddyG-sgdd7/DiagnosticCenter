use DiagnosticCenter
create proc BookAppDetails
@UserName varchar(20),
@PatientName varchar(20),
@Gender varchar(10),
@ServiceType varchar(20),
@AppointmentDate varchar(20),
@RFV	varchar(20),
@Status varchar(10)
as
insert into BookAppointment values
(@UserName,@PatientName, @Gender, @ServiceType, @AppointmentDate, @RFV,
 @Status)
 
 drop proc BookAppDetails
 select * from PatientRegistration
 select * from BookAppointment
 
 drop table BookAppointment
 
 create table BookAppointment
(
	UserName varchar(20),
	PatientName varchar(20),
	Gender varchar(10),
	ServiceType varchar(20),
	AppointmentDate varchar(20),
	RFV	varchar(20),
	Status varchar(10),
	AppointmentID int identity(10001,1)
)

select * from PatientRegistration

select * from UserLogin

select * from BookAppointment

create proc SearchAppointmentId
@AppointmentID varchar(20),
@UserName varchar(20)
as
begin
select * from BookAppointment where AppointmentID = @AppointmentID and UserName = @UserName
end

create proc RemoveAppointmentID
@AppointmentID varchar(20),
@UserName varchar(20)
as 
begin
delete from BookAppointment where AppointmentID = @AppointmentID and UserName = @UserName
end

select * from PatientRegistration

select * from UserLogin

create proc ChangePasswordPatient
@OldPwd varchar(20),
@NewPwd varchar(20)
as
begin
update PatientRegistration
set UserPwd = @NewPwd
where UserPwd = @OldPwd
end

sp_help UpdatePassword