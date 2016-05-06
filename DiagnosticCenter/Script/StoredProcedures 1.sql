sp_tables

select * from PatientRegistration
select * from UserLogin
select * from usersalt

select * from addpatient
select * from BookAppointment
select * from usersalt

create proc UpdateSalt
@UserName varchar(20),
@UserPwd varchar(50)
as
begin
update UserSalt 
set PwdSalt = @UserPwd
where UserName = @UserName
end
drop proc UpdateSalt
delete from PatientRegistration

exec updatesalt 'MT1860','Ram'

insert into UserLogin values('MID7389','ram123','Manager');
use diagnosticcenter
create proc PatientRegDetails
@UserName varchar(20),
@UserPwd varchar(50),
@FirstName varchar(20),
@LastName varchar(20),
@Gender varchar(6),
@DOB date,
@Age int,
@PhoneNo varchar(10),
@EMail varchar(20),
@Address varchar(10),
@City varchar(20),
@PIN	varchar(10)
as
insert into PatientRegistration values
(@UserName,@UserPwd,@FirstName,@LastName,@Gender,@DOB,@Age,@PhoneNo,@EMail,
 @Address,@City,@PIN)
 
 
 sp_help PatientRegDetails
 sp_help PatientRegistration
 drop table PatientRegistration
 
 
 use diagnosticcenter
 drop proc PatientRegDetails
 
 create proc RegDetails
 @UserName varchar(20)
 as
 select * from PatientRegistration 
 where UserName=@UserName
 
 create proc StaffDetails
 @UserName varchar(20)
 as
 select * from AddStaff 
 where UserName=@UserName

sp_help BookAppointment
 
 create proc UserDetails
 @UserName varchar(20),
 @UserPwd varchar(20)
 as
 select UserRole from UserLogin
 where UserName=@UserName and UserPwd=@UserPwd
 

drop proc StaffRegDetails

create proc StaffRegDetails
@UserName varchar(20),
@UserPwd varchar(50),
@FirstName varchar(20),
@LastName varchar(20),
@Gender varchar(6),
@DOB date,
@Age int,
@PhoneNo varchar(10),
@EMail varchar(20),
@Address varchar(10),
@City varchar(20),
@PIN	varchar(10),
@Qualification varchar(20),
@Experience int
as
insert into AddStaff values
(@UserName,@UserPwd,@FirstName,@LastName,@Gender,@DOB,@Age,@PhoneNo,@EMail,
@Address,@City,@PIN,@Qualification, @Experience)


drop proc StaffRegDetails
create proc ViewStaffDetials
as
select FirstName,UserName,PhoneNo,EMail,City,Pincode
from AddStaff


create proc UpdateStaff
@Username varchar(20),
@PhoneNo varchar(20),
@Email varchar(20),
@City varchar(20),
@Pincode varchar(20)
as
update AddStaff
set PhoneNo=@PhoneNo,EMail=@Email,City=@City,Pincode=@Pincode
where UserName=@Username

drop proc UpdateStaff

create proc RemoveStaff
@Username varchar(20)
as
delete AddStaff
where UserName=@Username

sp_help BookAppointment