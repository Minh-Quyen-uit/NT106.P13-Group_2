create database QuanLyNguoiDung
go

use QuanLyNguoiDung 
go

set dateformat DMY
-- userAccount table

create table UserAccount (
	UserName nvarchar(100) primary key,
	PassWord nvarchar(500) not null default 0,
	FullName nvarchar(100) not null default N'User',
	Email nvarchar(150) not null,
	BirthDay Date not null,
)
go

insert into UserAccount values ('admin01', 'admin01123456@', 'Nguyễn Minh Quyền', 'admin01@gmail.com', '05/11/2005')

insert into UserAccount values ('staff01', 'staff01123456@', 'Le Minh Quan', 'staff01@gmail.com', '02/09/2005')

go 
Create proc USP_GetAccountByUserName
@username nvarchar(100)
as
begin
Select * from dbo.UserAccount where UserName = @username
	
	
end
go

Exec dbo.USP_GetAccountByUserName @username = N'staff01'

Select * from dbo.UserAccount