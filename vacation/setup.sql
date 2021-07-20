CREATE TABLE Accounts(
id VARCHAR(255) NOT NULL primary key comment 'primary key',
createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'create time',
updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'update time',
name varchar(255) NOT NULL comment 'Users given name',
email varchar(255) NOT NULL comment 'Auth Email',
picture varchar(255) NOT NULL comment 'Picture URL'
) default charset utf8 comment '';