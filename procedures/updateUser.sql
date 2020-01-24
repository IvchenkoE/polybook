DELIMITER //
drop procedure if exists updateUser;
create procedure updateUser (in email_ varchar(45), in firstName_ varchar(45), 
							 in lastName_ varchar(45), in fatherName_ varchar(45), 
                             in phoneNumber_ varchar(45))
language sql
deterministic
sql security definer
comment "update user info"
begin
	declare id_ int;
	if email_ in (select email from users) then
		-- user with this email exists
        select id into id_ from users where email_ = email;
        update users 
		set 
          firstName = firstName_,
          lastName = lastName_,
          fatherName = fatherName_,
          phoneNumber = phoneNumber_
		where 
          id = id_;
	end if;
end //