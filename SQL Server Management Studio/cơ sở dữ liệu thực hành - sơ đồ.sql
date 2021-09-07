
create database quanlihocsinh
go
use quanlihocsinh
go
----------------------------------------------
------------- TẠO BẢNG TRƯỜNG ------------------
create table truong
(
mt varchar(10) primary key ,--mã trường
ttr nvarchar(100),--tên trường
dc nvarchar(100)--địa chỉ

)
go
insert truong
(mt,
ttr,
dc)
values
(
'hk',
N'Hương Khê',
N'Hương Khê - Hà Tĩnh '
)
-------------------------------------------------
-------------- TẠO BẢNG KHỐI LỚP ------------------------
create table klop
(
mkl varchar(10) primary key,--mã khối lớp
tkl nvarchar(100),--tên khối lớp
mt varchar(10), foreign key (mt) references truong(mt)
)
go
insert klop
(
mkl,
tkl,
mt
)
values
(
'k10',
N'Khối 10',
'hk'

)

go
-------------------------------------------------------------
----------------------- TẠO BẢNG LỚP -----------------------------
create table lop
(
ml varchar(10) primary key ,--mã lớp 
tl nvarchar(100) ,--tên lớp
gvcn nvarchar(100),--giáo viên chủ nhiệm
lt nvarchar(100),--lớp trưởng
mkl varchar(10),foreign key (mkl) references klop(mkl),

)
go
insert lop
(
ml,
tl,
gvcn,
lt,
mkl
)
values 
(
'10a3',
N'Lớp 10A3',
N'Lưu Thị Thủy',
N'Lê Khắc Sáng',
'k10'

)
go
-------------------------------------------------------------
---------------- TẠO BẢNG TỔ -----------------------------------
create table tto
(
mtt varchar(10) primary key ,--mã tổ
tt nvarchar(100) ,--tên tổ
totr nvarchar(100),--tổ trưởng
ml varchar(10),foreign key (ml) references lop(ml)

)
go
insert tto
(
mtt,
tt,
totr,
ml
)
values
(
't1',
N'tổ 1',
N'Lê Thị Hà',
'10a3'
)
go

insert tto
(
mtt,
tt,
totr,
ml
)
values
(
't2',
N'tổ 2',
N'Lê Thị Hạnh',
'10a3'
)
go


insert tto
(
mtt,
tt,
totr,
ml
)
values
(
't3',
N'tổ 3',
N'Nguyễn Thị Nga',
'10a3'
)
go


insert tto
(
mtt,
tt,
totr,
ml
)
values
(
't4',
N'tổ 4',
N'Phan Văn An',
'10a3'
)
go



----------------------------------------------------------------------------
-------------------------TẠO BẢNG HỌC SINH---------------------------------
create table hocsinh
(
mhs varchar(10) primary key,
ths nvarchar(100),
ns date,
mtt varchar(10),foreign key (mtt) references tto(mtt)

)
go
insert hocsinh
(
mhs,
ths,
ns,
mtt

)
values
(
'a1',
N'Trần Văn Chung',
'19920215',
't4'
)

insert hocsinh
(
mhs,
ths,
ns,
mtt

)
values
(
'a2',
N'Nguyễn Thị Nga',
'19920315',
't2'
)

insert hocsinh
(
mhs,
ths,
ns,
mtt

)
values
(
'a3',
N'Nguyễn Phi Tú ',
'19920415',
't3'
)

insert hocsinh
(
mhs,
ths,
ns,
mtt

)
values
(
'a4',
N'Hoàng Thị Thủy',
'19920615',
't1'
)

insert hocsinh
(
mhs,
ths,
ns,
mtt

)
values
(
'a5',
N'Hoàng Thị Nhung',
'19920116',
't4'
)

insert hocsinh
(
mhs,
ths,
ns,
mtt

)
values
(
'a6',
N'Trần Thị Tình',
'19920115',
't2'
)

insert hocsinh
(
mhs,
ths,
ns,
mtt

)
values
(
'a7',
N'Đinh Văn Tâm',
'19921112',
't3'
)

insert hocsinh
(
mhs,
ths,
ns,
mtt

)
values
(
'a8',
N'Phan Việt Hoàng',
'19920115',
't2'
)

insert hocsinh
(
mhs,
ths,
ns,
mtt

)
values
(
'a9',
N'Nguyễn Thị Nga',
'19920120',
't3'
)

insert hocsinh
(
mhs,
ths,
ns,
mtt

)
values
(
'a10',
N'Nguyễn Thu Hiền',
'19920128',
't2'
)

insert hocsinh
(
mhs,
ths,
ns,
mtt

)
values
(
'a11',
N'Lê Thị Hà',
'19920115',
't1'
)

insert hocsinh
(
mhs,
ths,
ns,
mtt

)
values
(
'a12',
N'Lê Khắc Sáng',
'19920130',
't4'
)

insert hocsinh
(
mhs,
ths,
ns,
mtt

)
values
(
'a13',
N'Phan Văn An',
'19920112',
't3'
)

insert hocsinh
(
mhs,
ths,
ns,
mtt

)
values
(
'a14',
N'Trần Văn Lĩnh',
'19920815',
't2'
)

insert hocsinh
(
mhs,
ths,
ns,
mtt

)
values
(
'a15',
N'Nguyễn Thanh Vinh',
'19921119',
't3'
)

insert hocsinh
(
mhs,
ths,
ns,
mtt

)
values
(
'a16',
N'Tôn Thi Na',
'19920121',
't1'
)

insert hocsinh
(
mhs,
ths,
ns,
mtt

)
values
(
'a17',
N'Lê Thị Hạnh',
'19921231',
't2'
)
go

---------------------------------------------------------------------------
------------------TẠO BẢNG BỘ MÔN--------------------------------------------
create table bomon
(
mbm varchar(10) primary key ,
trbm varchar(10),
tbm nvarchar(100),
mt varchar(10) ,foreign key(mt) references truong(mt)

)
go

insert bomon
(
mbm,
trbm,
tbm,
mt)
values
(
'sinh',
'gv1',
N'Sinh Học',
'hk'
)
go

insert bomon
(
mbm,
trbm,
tbm,
mt)
values
(
'toan',
'gv2',
N'Toán',
'hk'
)
go

insert bomon
(
mbm,
trbm,
tbm,
mt)
values
(
'hoa',
'gv3',
N'Hoá Học',
'hk'
)
go
insert bomon
(
mbm,
trbm,
tbm,
mt)
values
(
'ly',
'gv4',
N'Vật Lý',
'hk'
)
go

insert bomon
(
mbm,
trbm,
tbm,
mt)
values
(
'van',
'gv12',
N'Ngữ Văn',
'hk'
)
go


insert bomon
(
mbm,
trbm,
tbm,
mt)
values
(
'su',
'gv13',
N'Lịch Sử',
'hk'
)
go

insert bomon
(
mbm,
trbm,
tbm,
mt)
values
(
'dia',
'gv14',
N'Địa Lý',
'hk'
)
go

insert bomon
(
mbm,
trbm,
tbm,
mt)
values
(
'anh',
'gv15',
N'Tiếng Anh',
'hk'
)
go



----------------------------------------------------------------------------
------------------------- TẠO BẢNG GIÁO VIÊN ----------------------------------------
create table giaovien 
(
mgv varchar(10) primary key,
tgv nvarchar(100),
nsgv date,
mbm varchar(10),foreign key(mbm) references bomon(mbm)
)
go
insert giaovien
(
mgv,
tgv,
nsgv,
mbm

)
values 
(
'gv1',
N'Lưu Thị Thuỷ',
'19870216',
'sinh'

)
go 

insert giaovien
(
mgv,
tgv,
nsgv,
mbm

)
values 
(
'gv6',
N'Hoàng Thị Lài',
'19950420',
'sinh'

)
go 

insert giaovien
(
mgv,
tgv,
nsgv,
mbm

)
values 
(
'gv2',
N'Trần Văn Lâm',
'19870215',
'toan'

)
go 

insert giaovien
(
mgv,
tgv,
nsgv,
mbm

)
values 
(
'gv7',
N'Lê Thị Thu Thanh',
'19800816',
'hoa'

)
go 

insert giaovien
(
mgv,
tgv,
nsgv,
mbm

)
values 
(
'gv3',
N'Liên Thanh Long',
'19870216',
'hoa'

)
go 

insert giaovien
(
mgv,
tgv,
nsgv,
mbm

)
values 
(
'gv9',
N'Tôn Tố Trân',
'19870926',
'ly'

)
go 

insert giaovien
(
mgv,
tgv,
nsgv,
mbm

)
values 
(
'gv4',
N'Trình Lập',
'19880927',
'ly'

)
go 

insert giaovien
(
mgv,
tgv,
nsgv,
mbm

)
values 
(
'gv10',
N'Trần Hoa',
'19880927',
'toan'

)
go


insert giaovien
(
mgv,
tgv,
nsgv,
mbm

)
values 
(
'gv12',
N'Trần Hùng',
'19850930',
'van'

)
go
insert giaovien
(
mgv,
tgv,
nsgv,
mbm

)
values 
(
'gv13',
N'Phan Công Hoa',
'19880427',
'su'

)
go
insert giaovien
(
mgv,
tgv,
nsgv,
mbm

)
values 
(
'gv14',
N'Trần Hoa',
'19950927',
'dia'

)
go
insert giaovien
(
mgv,
tgv,
nsgv,
mbm

)
values 
(
'gv15',
N'Lê Thị Thiên',
'19880922',
'anh'

)
go

----------------------------------------------------
----------------TẠO BẢNG THỜI KHÓA BIỂU------------

create table thoikhoabieu
(
stt numeric,
thu nvarchar(10),primary key(thu),
tiet1 nvarchar(50),
tiet2 nvarchar(50),
tiet3 nvarchar(50),
tiet4 nvarchar(50),
tiet5 nvarchar(50),

ml varchar(10), 
foreign key(ml) references lop

)
go
insert thoikhoabieu
(
stt,
thu,
tiet1,
tiet2,
tiet3,
tiet4,
tiet5,
ml


)
values
(
1,
N'Thứ Hai',
N'Toán',
N'Vật Lý',
N'Tiếng Anh',
N'Hóa Học',
N'Chào Cờ',
'10a3'



)
go

insert thoikhoabieu
(
stt,
thu,
tiet1,
tiet2,
tiet3,
tiet4,
tiet5,
ml


)
values
(
2,
N'Thứ Ba',
N'Tiếng Anh',
N'Vật Lý',
N'Toán',
N'Lịch Sử',
N'',
'10a3'



)
go

insert thoikhoabieu
(
stt,
thu,
tiet1,
tiet2,
tiet3,
tiet4,
tiet5,
ml


)
values
(
3,
N'Thứ Tư',
N'Ngữ Văn',
N'Toán',
N'Sinh Học',
N'Tiếng Anh',
N'',
'10a3'



)


go
insert thoikhoabieu
(
stt,
thu,
tiet1,
tiet2,
tiet3,
tiet4,
tiet5,
ml


)
values
(
4,
N'Thứ Năm',
N'Toán',
N'Hóa Học',
N'Địa Lý',
N'Sinh Học',
N'',
'10a3'



)
go

insert thoikhoabieu
(
stt,
thu,
tiet1,
tiet2,
tiet3,
tiet4,
tiet5,
ml


)
values
(
5,
N'Thứ Sáu',
N'Giáo Dục Quốc Phòng',
N'Địa Lý',
N'Anh',
N'Ngữ Văn',
N'',
'10a3'



)
go

insert thoikhoabieu
(
stt,
thu,
tiet1,
tiet2,
tiet3,
tiet4,
tiet5,
ml


)
values
(
6,
N'Thứ Bảy',
N'Ngữ Văn',
N'Địa Lý',
N'Lịch Sử',
N'Sinh Học',
N'',
'10a3'



)
go

insert thoikhoabieu
(
stt,
thu,
tiet1,
tiet2,
tiet3,
tiet4,
tiet5,
ml


)
values
(
7,
N'CN',
N'',
N'',
N'',
N'',
N'',
'10a3'



)
go
-------------------------------------------------------
---------------TẠO BẢNG KẾT QUẢ HỌC TẬP--------------------------
create table ketquahoctap
(
mbm varchar(10),
mhs varchar(10),
primary key(mbm,mhs),
tenbaikiemtra nvarchar(50),
thoigian nvarchar(15),
diemso dec(4,2),
foreign key(mbm) references bomon,
foreign key(mhs) references hocsinh


)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'toan',
'a1',
N'Kiểm tra 15 phút',
N'15 phút',
8.5

)
go

insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'ly',
'a1',
N'Kiểm tra 1 tiết',
N'45 phút',
8.5

)
go

insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'hoa',
'a1',
N'Kiểm tra Hoc Kỳ 1',
N'60 phút',
8.5

)
go


insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'sinh',
'a1',
N'Kiểm tra 15 phút',
N'15 phút',
8.5

)
go

insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'van',
'a1',
N'Kiểm tra 15 phút',
N'15 phút',
5.5

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'su',
'a1',
N'Kiểm tra 15 phút',
N'15 phút',
8.5

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'dia',
'a1',
N'Kiểm tra 15 phút',
N'15 phút',
9

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'anh',
'a1',
N'Kiểm tra 15 phút',
N'15 phút',
7

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'toan',
'a2',
N'Kiểm tra 15 phút',
N'15 phút',
4

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'ly',
'a2',
N'Kiểm tra 15 phút',
N'15 phút',
6

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'hoa',
'a2',
N'Kiểm tra 15 phút',
N'15 phút',
10

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'sinh',
'a2',
N'Kiểm tra 15 phút',
N'15 phút',
8.5

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'toan',
'a3',
N'Kiểm tra 15 phút',
N'15 phút',
9

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'ly',
'a3',
N'Kiểm tra 15 phút',
N'15 phút',
2

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'hoa',
'a3',
N'Kiểm tra 15 phút',
N'15 phút',
1

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'sinh',
'a3',
N'Kiểm tra 15 phút',
N'15 phút',
0

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'van',
'a3',
N'Kiểm tra 15 phút',
N'15 phút',
3

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'su',
'a3',
N'Kiểm tra 15 phút',
N'15 phút',
4

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'dia',
'a3',
N'Kiểm tra 15 phút',
N'15 phút',
5

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'anh',
'a3',
N'Kiểm tra 15 phút',
N'15 phút',
6

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'toan',
'a4',
N'Kiểm tra 15 phút',
N'15 phút',
8.5

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'ly',
'a4',
N'Kiểm tra 15 phút',
N'15 phút',
7

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'hoa',
'a4',
N'Kiểm tra 15 phút',
N'15 phút',
8.5

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'sinh',
'a4',
N'Kiểm tra 15 phút',
N'15 phút',
8.5

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'van',
'a4',
N'Kiểm tra 15 phút',
N'15 phút',
8.5

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'su',
'a4',
N'Kiểm tra 15 phút',
N'15 phút',
8.5

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'dia',
'a4',
N'Kiểm tra 15 phút',
N'15 phút',
8.5

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'anh',
'a4',
N'Kiểm tra 15 phút',
N'15 phút',
8.5

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'toan',
'a5',
N'Kiểm tra 15 phút',
N'15 phút',
8.5

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'ly',
'a5',
N'Kiểm tra 15 phút',
N'15 phút',
8.5

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'hoa',
'a5',
N'Kiểm tra 15 phút',
N'15 phút',
8.5

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'sinh',
'a5',
N'Kiểm tra 15 phút',
N'15 phút',
8.25

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'van',
'a5',
N'Kiểm tra 15 phút',
N'15 phút',
5

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'su',
'a5',
N'Kiểm tra 15 phút',
N'15 phút',
7

)
go

insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'dia',
'a5',
N'Kiểm tra 15 phút',
N'15 phút',
4

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'anh',
'a5',
N'Kiểm tra 15 phút',
N'15 phút',
10

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'toan',
'a6',
N'Kiểm tra 15 phút',
N'15 phút',
9

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'ly',
'a6',
N'Kiểm tra 1 tiết',
N'45 phút',
2

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'hoa',
'a6',
N'Kiểm tra 15 phút',
N'15 phút',
8

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'sinh',
'a6',
N'Kiểm tra 15 phút',
N'15 phút',
9.5

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'van',
'a6',
N'Kiểm tra 15 phút',
N'15 phút',
5

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'su',
'a6',
N'Kiểm tra 1 tiết',
N'45 phút',
8.5

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'dia',
'a6',
N'Kiểm tra 15 phút',
N'15 phút',
7.5

)
go
insert ketquahoctap
(
mbm,
mhs,
tenbaikiemtra,
thoigian,
diemso



)
values
(
'anh',
'a6',
N'Kiểm tra 15 phút',
N'15 phút',
6.5

)
go







































