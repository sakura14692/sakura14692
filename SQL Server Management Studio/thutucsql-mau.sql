create proc ok3
@a int,@b int
as
begin
declare @c int=@a+@b
insert into chek(a,b,c) values (@a,@b,@c)
select * from chek
end
go
exec ok3 @a=10,@b=2










