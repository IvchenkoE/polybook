delimiter //
drop procedure if exists newUpdateBook;
create procedure newUpdateBook(in userId_ int, in roomId_ int, in date_ DATE, in startTime_ time, 
						in endTime_ time, in purpose_ varchar(200), in isTechEquip_ tinyint)
comment "adding a new book to the booking"
begin
declare Id_ int default 0;
declare c int default 0;
set Id_ = (select max(id) from booking);
set Id_ = Id_ +1;
set c = (select count(id) from booking 
			where (roomId = roomId_) and (date = date_) and (startTime_ < endTime_) and
				((startTime_ <= endTime and startTime_ > startTime) or 
				(endTime_ < endTime and endTime_ >= startTime) or
                (startTime_ <= startTime and endTime_ >= endTime)));
if (c = 0) then update `database`.`booking` set userId = userId_, roomId = roomId_, 
			date = date_, startTime = startTime_, endYime = endTime_, 
            purpose = purpose_, isTechEquip = isTechEquip_ where id = Id_;
end if;
select c;
end//