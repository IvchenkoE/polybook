delimiter //
drop procedure if exists updateBook;
create procedure updateBook(in id_ int, in userId_ int, in roomId_ int, in date_ DATE, in startTime_ time, 
						in endTime_ time, in purpose_ varchar(200), in isTechEquip_ tinyint)
comment "adding a new book to the booking"
begin
declare c int default 0;
set c = (select count(id) from booking 
			where (roomId = roomId_) and (date = date_) and (startTime_ < endTime_) and
				((startTime_ <= endTime and startTime_ > startTime) or 
				(endTime_ < endTime and endTime_ >= startTime) or
                (startTime_ <= startTime and endTime_ >= endTime)));
if (c = 0) then update `database`.`booking` set userId = userId_, roomId = roomId_, 
			date = date_, startTime = startTime_, endTime = endTime_, 
            purpose = purpose_, isTechEquip = isTechEquip_ where id = id_;
end if;
select c;
end//