
select * from PatientRegistration

select * from AddStaff

select * from AddPatient

select * from BookAppointment

select * from UserLogin

select * from UserSalt

delete from AddPatient where username='RP1858'

alter table AddStaff alter column EMail varchar(50)


update BookAppointment
set Status = 'Pending'
where username = 'JM1989'

delete from PatientRegistration

delete from BookAppointment where appointmentdate='9/18/2014'

sp_tables