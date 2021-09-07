create database testmatusinh
go
use testmatusinh
go



create table thong_tin_du_an_da_trien_khai
(
ma_du_an varchar(20),
ten_du_an nvarchar(100),
ngay_khoi_cong date,
so_san_pham int,
ten_san_pham nvarchar(100),
so_von int,
loi_nhuan int,
doanh_thu int

)
go
create proc them_du_an
@ma_du_an varchar(50),@ten_du_an nvarchar(100),@ngay_khoi_cong date,@so_san_pham int,@ten_san_pham nvarchar(100),@so_von int,@loi_nhuan int,@doanh_thu int
as
begin

set @ma_du_an  = 'DU_AN_' + LEFT(newid(),8)
insert into thong_tin_du_an_da_trien_khai(ma_du_an,ten_du_an,ngay_khoi_cong,so_san_pham,ten_san_pham,so_von,loi_nhuan,doanh_thu) values (@ma_du_an,@ten_du_an,@ngay_khoi_cong,@so_san_pham,@ten_san_pham,@so_von,@loi_nhuan,@doanh_thu)
select * from thong_tin_du_an_da_trien_khai

end
go
 exec them_du_an @ma_du_an='',@ten_du_an=N'Mua gió',@ngay_khoi_cong = '2020-6-30',@so_san_pham = 20,@ten_san_pham=N'Gió trầm',@so_von = 20000000,@loi_nhuan = 5000000,@doanh_thu = 70000000


