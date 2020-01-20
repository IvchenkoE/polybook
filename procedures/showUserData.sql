DELIMITER //
drop procedure if exists showUserData;
create procedure showUserData (in id_ int)
language sql
deterministic
sql security definer
comment "show user"
begin
    select email, firstName, lastName, fatherName, phoneNumber 
    from users where id = id_;
end //