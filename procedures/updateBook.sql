delimiter //
drop procedure if exists updateBook;
create procedure updateBook(in id_ int, in userId_ int, in roomId_ int, in date_ DATE, in startTime_ time, 
						in endTime_ time, in purpose_ varchar(200), in isTechEquip_ tinyint)
comment "book update"
begin
if (userId_ in (select id from `database`.`users`)) and (roomId_ in (select id from `database`.`catalog`))
	then update `database`.`booking` set userId = userId_, roomId = roomId_, date = date_, 
    startTime = startTime_, endTime = endTime_, purpose = purpose_, isTechEquip = isTechEquip_ where id = id_;
end if;
end//
