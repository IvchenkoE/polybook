DELIMITER //
drop procedure if exists login;
create procedure login (in email_ varchar(45), in password_ varchar(45))
language sql
deterministic
sql security definer
comment "check if the user exists and if the password is right"
begin
    if email_ in (select email from users) then
		if password_ = (select users.password from users where users.email = email_) then
			select id from users where email_ = users.email;
		end if;
	end if;
end //
