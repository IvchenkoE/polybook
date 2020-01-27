delimiter //
drop procedure if exists addRoom;
create procedure addRoom(in roomTypeId_ int, in capacity_ int, in isTechEquip_ tinyint, in techEquip_ varchar(200))
comment "adding a new room to the catalog"
begin
declare maxId int default 0;
set maxId = (select max(id) from catalog)+1;
if roomTypeId_ in (select id from `database`.`roomtype`)
	then insert into `database`.`catalog` values (maxId, roomTypeId_, capacity_, isTechEquip_, techEquip_);
end if;
end//