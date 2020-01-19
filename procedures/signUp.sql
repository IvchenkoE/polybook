DELIMITER //
drop procedure if exists signUp;
create procedure signUp (in email_ varchar(45), in password_ varchar(45), 
                         in firstName_ varchar(45), lastName_ varchar(45),
                         in fatherName_ varchar(45), phoneNumber_ varchar()45,
                         in isAdmin_ boolean, out id_ int)
language sql
deterministic
sql security definer
comment "create new user"
begin
	declare id_ int;
    select id + 1 into id_ from users where id=(select max(id) from users)
	if email_ in (select email from users) then
		-- user with this email already exists
		set id_ = 0;
	else
		insert into users values(id_, email_, password_, firstName_, lastName_, fatherName_, phoneNumber_, isAdmin_);
	end if;
end //
