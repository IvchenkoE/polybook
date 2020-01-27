CREATE DEFINER=`root`@`localhost` PROCEDURE `deleteUserByEmail`(in email_ varchar(45))
BEGIN
	delete from users where email = email_;
END