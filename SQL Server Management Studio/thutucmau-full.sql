create database kiemtra
go
use kiemtra
go
create table chek
(
 a int,
 b int,
 c int,
 d varchar(100)


)
 go 
 create proc ok3
@a int,@b int,@d varchar(100)
as
begin
declare @c int=@a+@b
set @d  = 'KH ' + LEFT(newid(),8)
insert into chek(a,b,c,d) values (@a,@b,@c,@d)
select * from chek
end
go
 exec ok3 @a=1,@b=3,@d=''