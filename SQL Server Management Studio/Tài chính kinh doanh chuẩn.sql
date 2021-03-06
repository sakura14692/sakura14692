create database TaiChinhKinhDoanh
go
use TaiChinhKinhDoanh
go

create table hinh_nen
(
doi_tuong nvarchar(100),
nguon nvarchar(150)
) 
go


create table dieu_khien_checkbox_su_dung_hinh_nen
(
mode nvarchar(10) not null

) 
go


create table dang_nhap
(
ten_dang_nhap varchar(50),
primary key(ten_dang_nhap),
mat_khau varchar(50) not null,
xac_nhan_mat_khau varchar(50) not null,
ho_ten nvarchar(100),
so_dien_thoai varchar(20),
email varchar(100),
id int NOT NULL IDENTITY(1,1)
)
go




create table ho_so_admin
(
ten_dang_nhap nvarchar(100) ,
primary key(ten_dang_nhap),
mat_khau varchar(50) not null,
ho_ten nvarchar(100),
so_dien_thoai varchar(50),
email varchar(50)

)

go

create table tat_bat_che_do_bao_mat_voi_CheckBox
(
hoi_mat_khau_ung_dung varchar(10) not null,
hoi_mat_khau_Admin_khi_xem_thong_tin_nguoi_dung  varchar(10) not null

)




 create table thong_tin_du_an_da_trien_khai
(
ma_du_an varchar(20),
primary key(ma_du_an),
ten_du_an nvarchar(100),
ngay_khoi_cong varchar(20),
so_san_pham int,
ten_san_pham nvarchar(100),
so_von bigint,
loi_nhuan bigint,
doanh_thu bigint

)
go
create proc them_du_an
@ma_du_an varchar(50),@ten_du_an nvarchar(100),@ngay_khoi_cong varchar(20),@so_san_pham int,@ten_san_pham nvarchar(100),@so_von bigint,@loi_nhuan bigint,@doanh_thu bigint
as
begin

set @ma_du_an  = 'DUAN ' + LEFT(newid(),8)
insert into thong_tin_du_an_da_trien_khai(ma_du_an,ten_du_an,ngay_khoi_cong,so_san_pham,ten_san_pham,so_von,loi_nhuan,doanh_thu) values (@ma_du_an,@ten_du_an,@ngay_khoi_cong,@so_san_pham,@ten_san_pham,@so_von,@loi_nhuan,@doanh_thu)
select * from thong_tin_du_an_da_trien_khai

end
go
create proc sua_du_an
@ma_du_an varchar(20),@ten_du_an nvarchar(100),@ngay_khoi_cong varchar(20),@so_san_pham int,@ten_san_pham nvarchar(100),@so_von float,@loi_nhuan float,@doanh_thu float
as
begin


update thong_tin_du_an_da_trien_khai set
ten_du_an = @ten_du_an,ngay_khoi_cong = @ngay_khoi_cong,so_san_pham = @so_san_pham,ten_san_pham = @ten_san_pham,so_von = @so_von,loi_nhuan = @loi_nhuan,doanh_thu = @doanh_thu where ma_du_an = @ma_du_an
select * from thong_tin_du_an_da_trien_khai

end

go
 exec them_du_an @ma_du_an='',@ten_du_an=N'Mua nhà',@ngay_khoi_cong = '2020-6-30',@so_san_pham = 20,@ten_san_pham=N'Gió trầm',@so_von = 20000000,@loi_nhuan = 5000000,@doanh_thu = 70000000

update thong_tin_du_an_da_trien_khai set  ten_du_an = N'Mua ok',ngay_khoi_cong = '2020-10-30',so_san_pham = 20,ten_san_pham = N'Gió trầm',so_von = 20000000,loi_nhuan = 5000000,doanh_thu = 70000000 where  ma_du_an = 'DUAN B4003768'
--delete thong_tin_du_an_da_trien_khai where ma_du_an = 'DUAN EE6BA5AD'
select * from thong_tin_du_an_da_trien_khai
go
go





 create table xay_dung_ke_hoach_cho_du_an_moi
(
ma_du_an varchar(20),
primary key(ma_du_an),
ten_du_an nvarchar(100),
ngay_khoi_cong_du_kien varchar(20),
so_san_pham_du_tinh int,
ten_san_pham nvarchar(100),
so_von_du_kien bigint,
loi_nhuan_du_kien bigint,


)
go
create proc them_ke_hoach
@ma_du_an varchar(50),@ten_du_an nvarchar(100),@ngay_khoi_cong_du_kien varchar(20),@so_san_pham_du_tinh int,@ten_san_pham nvarchar(100),@so_von_du_kien bigint,@loi_nhuan_du_kien bigint
as
begin

set @ma_du_an  = 'DUAN ' + LEFT(newid(),8)
insert into xay_dung_ke_hoach_cho_du_an_moi(ma_du_an,ten_du_an,ngay_khoi_cong_du_kien,so_san_pham_du_tinh,ten_san_pham,so_von_du_kien,loi_nhuan_du_kien) values (@ma_du_an,@ten_du_an,@ngay_khoi_cong_du_kien,@so_san_pham_du_tinh,@ten_san_pham,@so_von_du_kien,@loi_nhuan_du_kien)
select * from xay_dung_ke_hoach_cho_du_an_moi

end
go
 exec them_ke_hoach @ma_du_an='',@ten_du_an=N'Mua gió',@ngay_khoi_cong_du_kien = '2020-6-30',@so_san_pham_du_tinh = 20,@ten_san_pham=N'Gió trầm',@so_von_du_kien = 20000000,@loi_nhuan_du_kien = 5000000



 create table quan_ly_thong_tin_doi_tac
(
ma_doi_tac varchar(20),
primary key(ma_doi_tac),
ten_doi_tac nvarchar(100),
nghe_nghiep nvarchar(100),
so_dien_thoai varchar(20),
ngay_sinh varchar(20),
dia_chi nvarchar(200),
ngay_bat_dau_hop_tac varchar(20)


)
go
create proc them_doi_tac
@ma_doi_tac varchar(50),@ten_doi_tac nvarchar(100),@nghe_nghiep nvarchar(100),@so_dien_thoai varchar(20),@ngay_sinh varchar(20),@dia_chi nvarchar(200),@ngay_bat_dau_hop_tac varchar(20)
as
begin

set @ma_doi_tac  = 'DOITAC ' + LEFT(newid(),8)
insert into quan_ly_thong_tin_doi_tac(ma_doi_tac,ten_doi_tac,nghe_nghiep,so_dien_thoai,ngay_sinh,dia_chi,ngay_bat_dau_hop_tac) values (@ma_doi_tac,@ten_doi_tac,@nghe_nghiep,@so_dien_thoai,@ngay_sinh,@dia_chi,@ngay_bat_dau_hop_tac)
select * from quan_ly_thong_tin_doi_tac

end
go
 exec them_doi_tac @ma_doi_tac ='',@ten_doi_tac=N'Đặng Thị Hằng',@nghe_nghiep = N'Giáo Viên',@so_dien_thoai ='0979134636',@ngay_sinh = N'1972-5-11',@dia_chi=N'Hương Khê-Hà Tĩnh',@ngay_bat_dau_hop_tac = '2020-7-5'

 go



 create table thu_vao
 (
 ma_so_khoan_thu varchar(50),
 primary key(ma_so_khoan_thu),
 ten_khoan_thu nvarchar(100),
 so_tien bigint,
 nguon_goc nvarchar(100)
 
 )

 go
 create proc them_khoan_thu
 @ma_so_khoan_thu varchar(50),@ten_khoan_thu nvarchar(100),@so_tien bigint,@nguon_goc varchar(100)
 as
 begin
 set @ma_so_khoan_thu = 'KHOANTHU ' + LEFT(newid(),8)
 insert thu_vao(ma_so_khoan_thu,ten_khoan_thu,so_tien,nguon_goc) values(@ma_so_khoan_thu,@ten_khoan_thu,@so_tien,@nguon_goc)
 select * from thu_vao

 end
 go
 exec them_khoan_thu @ma_so_khoan_thu = '',@ten_khoan_thu = N'Bán gió',@so_tien = 9523000000 ,@nguon_goc = N'Bán gió'
 --delete thu_vao
 go





  create table chi_ra
 (
 ma_so_khoan_chi varchar(50),
 primary key(ma_so_khoan_chi),
 ten_khoan_chi nvarchar(100),
 so_tien bigint,
 muc_dich nvarchar(100)
 
 )

 go
 create proc them_khoan_chi
 @ma_so_khoan_chi varchar(50),@ten_khoan_chi nvarchar(100),@so_tien bigint,@muc_dich varchar(100)
 as
 begin
 set @ma_so_khoan_chi = 'KHOANCHI ' + LEFT(newid(),8)
 insert chi_ra(ma_so_khoan_chi,ten_khoan_chi,so_tien,muc_dich) values(@ma_so_khoan_chi,@ten_khoan_chi,@so_tien,@muc_dich)
 select * from chi_ra

 end
 go
 exec them_khoan_chi @ma_so_khoan_chi = '',@ten_khoan_chi = N'Mua gió ở Phúc Trạch',@so_tien = 380000000,@muc_dich = N'Mua gió'
-- delete chi_ra
 go











-- insert hinh nền
insert hinh_nen(doi_tuong,nguon) values(N'Trang chủ','')
insert hinh_nen(doi_tuong,nguon) values(N'Hệ thống','')
insert hinh_nen(doi_tuong,nguon) values(N'Admin','')
insert hinh_nen(doi_tuong,nguon) values(N'Tiện ích','')
insert hinh_nen(doi_tuong,nguon) values(N'Trợ giúp','')
insert hinh_nen(doi_tuong,nguon) values(N'Hộp tin nhắn thông báo','')
insert hinh_nen(doi_tuong,nguon) values(N'Hộp tin nhắn thực thi','')
insert hinh_nen(doi_tuong,nguon) values(N'Hình nền cửa sổ ngoài','')
insert hinh_nen(doi_tuong,nguon) values(N'Hình nền trình phát nhạc','')
insert hinh_nen(doi_tuong,nguon) values(N'Hình nền trình phát video','')
insert hinh_nen(doi_tuong,nguon) values(N'Hình nền lịch','')

-- insert on_off checkbox
insert dieu_khien_checkbox_su_dung_hinh_nen (mode) values(N'on')

-- insert tài khoản
insert dang_nhap(ten_dang_nhap,mat_khau,xac_nhan_mat_khau,ho_ten,so_dien_thoai,email) 
values ('vuong','1234','1234',N'Lê Viết Trung','0979279572','sakura14692@gmail.com')



-- insert hồ sơ Admin
insert ho_so_admin(ten_dang_nhap,mat_khau,ho_ten,so_dien_thoai,email) 
values ('trungpro','1234',N'Lê Viết Trung','0979279572','sakura14692@gmail.com')

-- insert tắt bật chế độ bảo mật
insert tat_bat_che_do_bao_mat_voi_CheckBox(hoi_mat_khau_ung_dung,hoi_mat_khau_Admin_khi_xem_thong_tin_nguoi_dung) 
values('on','on')





