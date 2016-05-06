use diagnosticcenter
create trigger UserLoginInsert on PatientRegistration
after insert
as
begin
declare @user_id varchar(20),@user_pwd varchar(50)
select @user_id = i.UserName,@user_pwd = i.UserPwd
from inserted i
insert into UserLogin(UserName,UserPwd,UserRole) values(@user_id,@user_pwd,default)
print 'after insert'
end

drop trigger UserLoginInsert

create trigger StaffLoginInsert on AddStaff
after insert
as
begin
declare @user_id varchar(20),@user_pwd varchar(50)
select @user_id = i.UserName,@user_pwd = i.UserPwd
from inserted i
insert into UserLogin(UserName,UserPwd,UserRole) values(@user_id,@user_pwd,'Staff')
print 'after insert'
end

select * from BookAppointment