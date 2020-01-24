delimiter //
drop procedure if exists addBook;
create procedure addBook(in userId_ int, in roomId_ int, in date_ DATE, in startTime_ datetime, 
						in endTime_ datetime, in purpose_ varchar(200), in isTechEquip_ tinyint)
comment "adding a new book to the booking"
begin
declare maxId int default 0;
set maxId = (select max(id) from booking)+1;
if (userId_ in (select id from `database`.`users`)) and (roomId_ in (select id from `database`.`catalog`))
	then insert into `database`.`booking` values (maxId, userId_, roomId_, date_, startTime_, 
													endTime_, purpose_, isTechEquip_);
end if;
end//