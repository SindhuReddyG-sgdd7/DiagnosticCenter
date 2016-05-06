use DiagnosticCenter
select * from UserLogin

create proc ViewStaffDetials
as
select FirstName,UserName,PhoneNo,EMail,City,Pincode
from AddStaff