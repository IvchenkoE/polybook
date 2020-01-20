DELIMITER //
drop procedure if exists login;
create procedure login (in email_ varchar(45), in password_ varchar(45), 
						out id_ int)
language sql
deterministic
sql security definer
comment "check if the user exists and if the password is right"
begin
    if email_ in (select email from users) then
		if password_ = (select users.password from users where users.email = email_) then
			select id into id_ from users where email_ = users.email;
        else
        	-- password is not correct
			set id_ = -1;
        end if;
	else
		-- email is not correct
		set id_ = 0;
	end if;
end //
