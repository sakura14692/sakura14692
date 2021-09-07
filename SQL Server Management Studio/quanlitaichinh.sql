create database quanlitaichinh
go
use quanlitaichinh
go
create table dautu
(
mdt varchar(10) primary key(mdt),
hangmucdautu nvarchar(50),
soluongsanpham int,
ngaykhoicong date,
ngayhachtoan date,
id int not null identity (1,1)

)
go

create table doitac
(
madoitac varchar(10) primary key(madoitac),
tendoitac nvarchar(50),
ngaysinh date,
gioitinh nvarchar(5),
diachi nvarchar(100),
sodienthoai numeric,
sovongiaodich int,
id int not null identity (1,1),
mdt varchar(10),foreign key(mdt) references dautu




)
 go

 create table ketoan
 (
 loinhuandukien int not null,
 loinhuanthucte int not null,
 thamhutvondukien int not null,
 thamhutvonthucte int not null,
 id int not null identity (1,1),
 mdt varchar(10),foreign key(mdt) references dautu

 
 )
