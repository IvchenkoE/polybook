delimiter //
drop procedure if exists deleteRoom;
create procedure deleteRoom(in id_ int)
comment "removal of a room from the catalog"
begin
if id_ in (select id from catalog) then	
	delete from `database`.`catalog` where id=id_;
end if;
end//