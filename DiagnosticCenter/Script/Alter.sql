select * from PatientRegistration
select * from UserLogin
select * from usersalt
select * from Addstaff
select * from AddPatient
select * from BookAppointment


alter table PatientRegistration alter column Address varchar(100)
sp_tables

delete from UserLogin where username = 'JM1261' 

sp_tables

sp_help mangerpwd

sp_help UserSalt

 where username <> 'RP1261' or username <> 'JM1261'

alter table BookAppointment alter column AppointmentDate varchar(20) not null

alter table BookAppointment add constraint pk_BookAppointment primary key(UserName,ServiceType,AppointmentDate)

delete from BookAppointment where username = 'JM1027'

delete from userlogin where username = 'JM1380'
sp_help PatientRegistration
delete
alter table Addstaff alter column EMail varchar(50) not null
alter table Addstaff add constraint pk_emailStaff primary key(EMail)

sp_tables

select * from BookAppointment


create proc UpdateStatus
@AppointmentDate varchar(30)
as
begin
update BookAppointment
set Status = 'Confirmed'
where AppointmentDate = @AppointmentDate
end


sp_help BookAppointment

insert into UserLogin values('MID1212','473DBE66F91E1B83CEF496E904B19D89','Manager')