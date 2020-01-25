DELIMITER //
drop procedure if exists login;
create procedure login (in email_ varchar(45), in password_ varchar(45), 
						out id_ int)
language sql
deterministic
sql security definer
comment "check if the user exists and if the password is right"
begin
    declare valid_password varchar(45);
    if email_ in (select email from users) then
		if password_ = (select users.password from users where users.email = email_) then
			select id into id_ from users where email_ = users.email;
        -- select users.password into valid_password from users where email_ = users.email;
        else
			set id_ = -1;
        end if;
	else
		set id_ = 0;
	end if;
end //