DELIMITER //
drop procedure if exists deleteUser;
create procedure deleteUser (in id_ int)
language sql
deterministic
sql security definer
comment "delete user"
begin
    delete from users where id = id_;
end //