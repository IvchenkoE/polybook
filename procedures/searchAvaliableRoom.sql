delimiter //
drop procedure if exists searchAvaliableRoom;
create procedure searchAvaliableRoom(in date_ date, in startTime_ time, in endTime_ time, in roomType_ varchar(45), 
									 in isMicrophone_ tinyint, in isProjector_ tinyint, in isComputer_ tinyint, in isInterBoard_ tinyint)
comment ""
begin
	declare microphoneId int default 0;
    declare projectorId int default 0; 
    declare computerId int default 0; 
    declare interBoardId int default 0;
    
	if isMicrophone_ = 1 then
		select id into microphoneId from equipment where name = 'Микрофон';
	end if;
	if isProjector_ = 1 then
		select id into projectorId from equipment where name = 'Проектор';
	end if;
	if isComputer_ = 1 then
		select id into computerId from equipment where name = 'Персональный компьютер';
	end if;
	if isInterBoard_ = 1 then
		select id into interBoardId from equipment where name = 'Интерактивная доска';
	end if;
    create index id on catalog(id);
    create index roomTypeId on catalog(roomTypeId);
    if roomType_ = 'Все' then
		select distinct catalog.id as "Номер аудитории", catalog.capacity as "Вместительность", roomType.type as "Тип"
		from catalog
        inner join equipforroom
		on catalog.id = equipforroom.roomId
		inner join equipment
		on equipforroom.equipId = equipment.id
		inner join roomType 
		on catalog.roomTypeId = roomType.id -- and roomType.type = roomType_
		where catalog.id not in 
			(select roomId from booking 
				where (booking.date = date_ and ((booking.startTime <= startTime_ and booking.endTime > startTime_)
											or (booking.startTime < endTime_ and booking.endTime >= endTime_)
											or (booking.startTime >= startTime_ and booking.endTime <= endTime_))))
				and catalog.id in (select catalog.id from catalog
								join equipforroom on catalog.id = equipforroom.roomId
								join equipment on equipforroom.equipId = equipment.id
                                join roomType on catalog.roomTypeId = roomType.id
									where (isMicrophone_ = 0 or equipforroom.equipId = microphoneId))
				and catalog.id in (select catalog.id from catalog
								join equipforroom on catalog.id = equipforroom.roomId
								join equipment on equipforroom.equipId = equipment.id
                                join roomType on catalog.roomTypeId = roomType.id
									where (isProjector_ = 0 or equipforroom.equipId = projectorId))
				and catalog.id in (select catalog.id from catalog
								join equipforroom on catalog.id = equipforroom.roomId
								join equipment on equipforroom.equipId = equipment.id
                                join roomType on catalog.roomTypeId = roomType.id
									where (isComputer_ = 0 or equipforroom.equipId = computerId))
				and catalog.id in (select catalog.id from catalog
								join equipforroom on catalog.id = equipforroom.roomId
								join equipment on equipforroom.equipId = equipment.id
                                join roomType on catalog.roomTypeId = roomType.id
									where (isInterBoard_ = 0 or equipforroom.equipId = interBoardId));
	else
        select distinct catalog.id as "Номер аудитории", catalog.capacity as "Вместительность", roomType.type as "Тип", equipment.name as "Тех.обор"
		from catalog
        inner join equipforroom
		on catalog.id = equipforroom.roomId
		inner join equipment
		on equipforroom.equipId = equipment.id
		inner join roomType 
		on catalog.roomTypeId = roomType.id and roomType.type = roomType_
		where catalog.id not in 
			(select roomId from booking 
				where (booking.date = date_ and ((booking.startTime <= startTime_ and booking.endTime > startTime_)
											or (booking.startTime < endTime_ and booking.endTime >= endTime_)
											or (booking.startTime >= startTime_ and booking.endTime <= endTime_))))
				and catalog.id in (select catalog.id from catalog
								join equipforroom on catalog.id = equipforroom.roomId
								join equipment on equipforroom.equipId = equipment.id
                                join roomType on catalog.roomTypeId = roomType.id
									where (isMicrophone_ = 0 or equipforroom.equipId = microphoneId))
				and catalog.id in (select catalog.id from catalog
								join equipforroom on catalog.id = equipforroom.roomId
								join equipment on equipforroom.equipId = equipment.id
                                join roomType on catalog.roomTypeId = roomType.id
									where (isProjector_ = 0 or equipforroom.equipId = projectorId))
				and catalog.id in (select catalog.id from catalog
								join equipforroom on catalog.id = equipforroom.roomId
								join equipment on equipforroom.equipId = equipment.id
                                join roomType on catalog.roomTypeId = roomType.id
									where (isComputer_ = 0 or equipforroom.equipId = computerId))
				and catalog.id in (select catalog.id from catalog
								join equipforroom on catalog.id = equipforroom.roomId
								join equipment on equipforroom.equipId = equipment.id
                                join roomType on catalog.roomTypeId = roomType.id
									where (isInterBoard_ = 0 or equipforroom.equipId = interBoardId));
    end if;
end// 