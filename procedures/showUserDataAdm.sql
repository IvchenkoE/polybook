DELIMITER //
drop procedure if exists showUserDataAdm;
create procedure showUserDataAdm (in id_ int)
language sql
deterministic
sql security definer
comment "show user"
begin
    select email, firstName, lastName, fatherName, phoneNumber, password, isAdmin
    from users where id = id_;
end //