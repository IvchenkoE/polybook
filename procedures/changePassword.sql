DELIMITER //
drop procedure if exists changePassword;
create procedure changePassword (in email_ varchar(45), in old_password_ varchar(45), 
								 in new_password_ varchar(45))
language sql
deterministic
sql security definer
comment "change password"
begin
    declare id_ int;
    if email_ in (select email from users) then
		if old_password_ = (select users.password from users where users.email = email_) then
			select id into id_ from users where email = email_;
			update users
            set 
              password = new_password_
			where
            id = id_;
        else
        	-- password is not correct
			set id_ = -1;
        end if;
	else
		-- email is not correct
		set id_ = 0;
	end if;
end //