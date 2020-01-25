DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `showUserBooks`(in id_ int)
DETERMINISTIC
COMMENT 'show User Books'
begin
select c.id as 'Номер Аудитории', b.date as 'Дата',
b.startTime as 'Время начала бронирования',
b.endTime as 'Время окончания бронирования',
b.istechEquip as 'Включено ли техн. оборудование',
eq.name as 'Тех. оборудование'
from booking b inner join users u
on b.userid = u.id
inner join catalog c on c.id = b.roomId
left join equipforbooking eqb on eqb.bookid = b.id
left join equipment eq on eq.id = eqb.equipid
where u.id = id_
order by b.date;
end$$
DELIMITER ;