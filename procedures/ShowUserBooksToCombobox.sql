DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `showUserBooksSh`(in id_ int)
BEGIN
select b.id as 'id', c.id as 'roomnum', b.date as 'date', 
    b.startTime as 'sttime',
    b.endTime as 'endtime'
    from booking b inner join users u 
		on b.userid = u.id 
			inner join catalog c on c.id = b.roomId
        where u.id = id_
        order by b.date;
END$$
DELIMITER ;
