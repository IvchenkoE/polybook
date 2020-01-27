-- create table 'users'
CREATE TABLE `database`.`users` (
  `id` INT NOT NULL,
  `email` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  `firstName` VARCHAR(45) NULL,
  `lastName` VARCHAR(45) NULL,
  `fatherName` VARCHAR(45) NULL,
  `phoneNumber` VARCHAR(45) NULL,
  `isAdmin` TINYINT NOT NULL,
  PRIMARY KEY (`id`));

--create teble 'catalog'
CREATE TABLE `database`.`catalog` (
  `id` INT NOT NULL,
  `roomTypeId` INT NOT NULL,
  `capacity` INT NOT NULL,
  `isTechEquip` TINYINT NOT NULL,
  `techEquip` VARCHAR(200) NULL,
  PRIMARY KEY (`id`));

--create table 'booking'
CREATE TABLE `database`.`booking` (
  `id` INT NOT NULL,
  `userId` INT NOT NULL,
  `roomId` INT NOT NULL,
  `date` DATE NOT NULL,
  `startTime` DATETIME NOT NULL,
  `endTime` DATETIME NOT NULL,
  `purpose` VARCHAR(200) NULL,
  `isTechEquip` TINYINT NOT NULL,
  PRIMARY KEY (`id`));

--create table 'roomtype'
CREATE TABLE `database`.`roomtype` (
  `id` INT NOT NULL,
  `type` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`));

--create table 'equipment'
CREATE TABLE `database`.`equipment` (
  `id` INT NOT NULL,
  `name` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`id`));

--create table 'equipforroom'
CREATE TABLE `database`.`equipforroom` (
  `id` INT NOT NULL,
  `equipId` INT NOT NULL,
  `roomId` INT NOT NULL,
  PRIMARY KEY (`id`));


--create table 'equipforbooking'
CREATE TABLE `database`.`equipforbooking` (
  `id` INT NOT NULL,
  `equipId` INT NOT NULL,
  `bookId` INT NOT NULL,
  PRIMARY KEY (`id`));
