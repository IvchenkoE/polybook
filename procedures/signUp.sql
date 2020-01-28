DELIMITER //
drop procedure if exists signUp;
create procedure signUp (in email_ varchar(45), in password_ varchar(45))
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
		insert into users values(id_, email_, password_, null, null, null, null, false);
	end if;
end //