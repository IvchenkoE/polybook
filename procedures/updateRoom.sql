delimiter //
drop procedure if exists updateRoom;
create procedure updateRoom(in id_ int, in roomTypeId_ int, in capacity_ int, in isTechEquip_ tinyint, in techEquip_ varchar(200))
comment "catalog room update"
begin
if roomTypeId_ in (select id from `database`.`roomtype`)
	then update `database`.`catalog` set roomTypeId = roomTypeId_, 
	capacity = capacity_, isTechEquip = isTechEquip_, techEquip = techEquip_ where id = id_;
end if;
end//