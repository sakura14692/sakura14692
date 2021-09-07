create database quanlitaichinh
go
use quanlitaichinh
go
create table dautu
(
madautu varchar(10) primary key(madautu),
hangmucdautu nvarchar(100),
tensanpham nvarchar(100),
soluong int,
donvi nvarchar(10),
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
hinhthuchoptac nvarchar(500),
id int not null identity (1,1),
madautu varchar(10),foreign key(madautu) references dautu




)
 go

 create table ketoan
 (
 tongdoanhthudukien int,
 tongdoanhthuthucte int,
 tienvondukien int,
 tienvonthucte int,
 dinhphidukien int,
 dinhphithucte int,
 bienphidukien int,
 bienphithucte int,
 loinhuantrensanphamdukien int,
 loinhuantrensanphamthucte int,
 tongloinhuandukien int,
 tongloinhuanthucte int,
 diembaohoavon int,
 id int not null identity (1,1),
 madautu varchar(10),foreign key(madautu) references dautu

 
 )
  go
  