delimiter //
drop procedure if exists addBook;
create procedure addBook(in userId_ int, in roomId_ int, in date_ DATE, in startTime_ time, 
						in endTime_ time, in purpose_ varchar(200), in isTechEquip_ tinyint)
comment "adding a new book to the booking"
begin
declare Id_ int default 0;
declare c int default 0;
set id_ = (select max(id) from booking);
set id_ = id_ +1;
set c = (select count(id) from booking 
			where (roomId = roomId_) and (date = date_) and (startTime_ < endTime_) and
				((startTime_ <= endTime and startTime_ > startTime) or 
				(endTime_ < endTime and endTime_ >= startTime) or
                (startTime_ <= startTime and endTime_ >= endTime)));
if (c = 0) then insert into `database`.`booking` values(id_ , userId_, roomId_, date_, startTime_, 
						endTime_, purpose_, isTechEquip_) ;
end if;
select c;
end//