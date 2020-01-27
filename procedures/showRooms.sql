delimiter //
drop procedure if exists showRooms;
create procedure showRooms()
comment ""
begin
	select catalog.id as "Номер аудитории", catalog.capacity as "Вместимость", roomtype.type as "Тип" FROM database.catalog
	inner join roomtype on 
	roomtype.id = catalog.roomTypeId;
end