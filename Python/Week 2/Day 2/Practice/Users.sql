INSERT INTO users (First_name , Last_name, Email) VALUES
('jon' ,'snow' , 'jon@gmail'),
('arya' ,'stark' , 'arya@gmail'),
('ned' ,'stark' , 'yusf@gmail');
SELECT * FROM users;
SET SQL_SAFE_UPDATES = 0;
select * from users  ;
SELECT * FROM users WHERE id = 30;
UPDATE users SET Last_name = 'Winterfell'  WHERE id =30;
select First_name from users  ;
DELETE FROM users WHERE id=29;












