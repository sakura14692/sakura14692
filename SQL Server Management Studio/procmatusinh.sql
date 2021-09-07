create proc test
as
begin
declare @next varchar(20)
set @next= 'kh ' +LEFT(newid(),5)
while (exists(select id from hocsinh where id=@next))
begin
set @next ='kh ' +LEFT(newid(),5)
 end
 select @next
end
