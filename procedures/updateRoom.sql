delimiter //
drop procedure if exists updateRoom;
create procedure updateRoom(in id_ int, in roomTypeId_ int, in capacity_ int)
comment "catalog room update"
begin
if roomTypeId_ in (select id from `database`.`roomtype`)
	then update `database`.`catalog` set roomTypeId = roomTypeId_, 
	capacity = capacity_ where id = id_;
end if;
end//