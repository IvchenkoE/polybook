delimiter //
drop procedure if exists deleteBook;
create procedure deleteBook(in id_ int)
comment "delete reservation"
begin
if id_ in (select id from booking) then	
    delete from `database`.`booking` where id=id_;
end if;
end//