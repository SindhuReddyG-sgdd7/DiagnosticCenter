select * from UserLogin

select * from AddStaff

create proc ChangePasswordStaff
@OldPwd varchar(50),
@NewPwd varchar(50)
as
begin
update AddStaff
set UserPwd=@NewPwd
where UserPwd=@OldPwd
end

create proc ChangePasswordPatient
@OldPwd varchar(50),
@NewPwd varchar(50)
as
begin
update PatientRegistration
set UserPwd=@NewPwd
where UserPwd=@OldPwd
end

sp_help Userlogin

sp_help updatepassword

use diagnosticcenter

sp_help changepasswordpatient

drop proc changepasswordstaff

create proc UpdatePassword
@OldPwd varchar(50),
@NewPwd varchar(50)
as
begin
update UserLogin
set UserPwd=@NewPwd
where UserPwd=@OldPwd
end

drop proc updatepassword
select * from BookAppointment

insert into BookAppointment(username,AppointmentDate) values('rouya','11/12/1993')

sp_help InsertUsersalt