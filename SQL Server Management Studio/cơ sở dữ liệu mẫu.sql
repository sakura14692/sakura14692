create database test
go
use test
go
create table monhoc(
mh int,
ok int,
primary key(mh)






)
alter table monhoc add foreign key(ok) references monhoc
go
insert monhoc

(
mh,
ok
)
values
(
1,
1
)
go

create table sinhvien(
msv int primary key,
b int



)
go
insert monhoc

(
mh,
ok
)
values
(
2,
1
)
go

create table diemthi(
msv int,
mh int,
b int,
primary key(msv,mh,b),
foreign key(msv) references sinhvien,
foreign key(mh) references monhoc



)

