create database test
go
use test
go
 create table hocsinh
 (
 mhs varchar(10),
 primary key(mhs),
 ths nvarchar(100),
 ns date,
 gt nvarchar(10),
 id INT NOT NULL IDENTITY(1,1)
 )
 go
 insert hocsinh (mhs,ths,ns,gt)
 values
 (
 'a1',
 N'lê văn lâm',
 '1992-9-5',
 N'nam'
 
 


 )
 go
 insert hocsinh (mhs,ths,ns,gt)
 values
 (
 'a2',
 N'lê thi lan',
 '1992-2-5',
 N'nam'
 
 


 )

 go

insert hocsinh (mhs,ths,ns,gt)
 values
 (
 'a3',
 N'trần xuân hậu',
 '1992-1-5',
 N'nam'
 
 


 )







