DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `addEquipBook`(in equipId_ int, in bookId_ int)
BEGIN
declare maxId int default 0;
set maxId = (select max(id) from equipforbooking)+1;
insert into `database`.`equipforbooking` values (maxId, equipId_, bookId_);
END$$
DELIMITER ;
