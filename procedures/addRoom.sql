delimiter //
drop procedure if exists addRoom;
create procedure addRoom(in id_ int, roomTypeId_ int, in capacity_ int, in isTechEquip_ tinyint, in techEquip_ varchar(200))
comment "adding a new room to the catalog"
begin
if roomTypeId_ in (select id from `database`.`roomtype`)
	then insert into `database`.`catalog` values (id_, roomTypeId_, capacity_, isTechEquip_, techEquip_);
end if;
end//