create database QuanLyNguoiDung
go

use QuanLyNguoiDung 
go

SET DATEFORMAT DMY
-- userAccount table

create table UserAccount (
	UserName nvarchar(100) primary key,
	PassWord nvarchar(500) not null default 0,
	FullName nvarchar(100) not null default N'User',
	Email nvarchar(150) not null,
	BirthDay Date not null,
)

create table BookShelfs (
	BookShelfCode INT IDENTITY(1,1) PRIMARY KEY,
	BookshelfName nvarchar(100),
	UserName nvarchar(100),
	foreign key (UserName) references UserAccount(UserName),
	Unique (BookshelfName, UserName)
)

create table Books (
	BookCode INT IDENTITY(1,1) PRIMARY KEY,
	BookName nvarchar(300),
	Author nvarchar(300),
	PublishedDate date, 
	BookShelfCode INT,
	foreign key (BookShelfCode) references BookShelfs(BookShelfCode),
	unique (BookName, BookShelfCode)
)

go

drop table Books

go 
Create proc USP_GetAccountByUserName
@username nvarchar(100)
as
begin
Select * from dbo.UserAccount where UserName = @username
	
	
end
go


Select * from dbo.UserAccount
Select * from dbo.BookShelfs

DELETE FROM dbo.BookShelfs;

SELECT FORMAT(GETDATE(), 'dd/MM/yyyy') AS FormattedDate;

UPDATE UserAccount SET BirthDay = FORMAT(BirthDay, 'dd/MM/yyyy');
