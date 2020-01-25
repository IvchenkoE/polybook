delimiter //
drop procedure if exists searchRoomWithoutEquip;
create procedure searchRoomWithoutEquip(in date_ date, in startTime_ time, in endTime_ time, in roomType_ varchar(45))
comment ""
begin
	if roomType_ = 'Все' then
		select catalog.id as "Номер аудитории", catalog.capacity as "Вместительность", roomType.type as "Тип"
		from catalog
		inner join roomType 
		on catalog.roomTypeId = roomType.id -- and roomType.type = roomType_
		where (catalog.id not in 
			(select roomId from booking 
            where (booking.date = date_ and ((booking.startTime <= startTime_ and booking.endTime > startTime_)
										or (booking.startTime < endTime_ and booking.endTime >= endTime_)
										or (booking.startTime >= startTime_ and booking.endTime <= endTime_)))));
	else
		select catalog.id as "Номер аудитории", catalog.capacity as "Вместительность", roomType.type as "Тип" 
		from catalog
		inner join roomType 
		on catalog.roomTypeId = roomType.id and roomType.type = roomType_
		where catalog.id not in (select roomId 
								 from booking 
								 where (booking.date = date_ 
								  and ((booking.startTime <= startTime_ and booking.endTime > startTime_)
									or (booking.startTime < endTime_ and booking.endTime >= endTime_)
									or (booking.startTime >= startTime_ and booking.endTime <= endTime_)))); 
	end if;
end