DELIMITER //
drop procedure if exists addUser;
create procedure addUser (in email_ varchar(45), in password_ varchar(45), 
                         in firstName_ varchar(45), in lastName_ varchar(45),
                         in fatherName_ varchar(45), in phoneNumber_ varchar(45),
                         in isAdmin_ tinyint)
language sql
deterministic
sql security definer
comment "create new user"
begin
    declare id_ int default 0;
	if email_ in (select email from users) then
		-- user with this email already exists
		select id_;
	else
		select id + 1 into id_ from users where id=(select max(id) from users);
		insert into users values(id_, email_, password_, firstName_, lastName_, fatherName_, phoneNumber_, isAdmin_);
	end if;
end //