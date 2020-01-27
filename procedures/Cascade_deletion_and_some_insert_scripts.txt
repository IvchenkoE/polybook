INSERT INTO `database`.`roomtype` (`id`, `type`) VALUES ('1', 'Лекционная');
INSERT INTO `database`.`roomtype` (`id`, `type`) VALUES ('2', 'Лаборатория');
INSERT INTO `database`.`roomtype` (`id`, `type`) VALUES ('3', 'Учебная');

INSERT INTO `database`.`catalog` (`id`, `roomTypeId`, `capacity`, `isTechEquip`) VALUES ('101', '1', '100', '1');
INSERT INTO `database`.`catalog` (`id`, `roomTypeId`, `capacity`, `isTechEquip`) VALUES ('102', '2', '20', '1');
INSERT INTO `database`.`catalog` (`id`, `roomTypeId`, `capacity`, `isTechEquip`) VALUES ('103', '3', '30', '1');
INSERT INTO `database`.`catalog` (`id`, `roomTypeId`, `capacity`, `isTechEquip`) VALUES ('104', '3', '40', '1');

INSERT INTO `database`.`equipment` (`id`, `name`) VALUES ('1', 'Микрофон');
INSERT INTO `database`.`equipment` (`id`, `name`) VALUES ('2', 'Проектор');
INSERT INTO `database`.`equipment` (`id`, `name`) VALUES ('3', 'Персональный компьютер');
INSERT INTO `database`.`equipment` (`id`, `name`) VALUES ('4', 'Интерактивная доска');

INSERT INTO `database`.`equipforroom` (`id`, `equipId`, `roomId`) VALUES ('1', '1', '102');
INSERT INTO `database`.`equipforroom` (`id`, `equipId`, `roomId`) VALUES ('2', '2', '102');

INSERT INTO `database`.`equipforbooking` (`id`, `equipId`, `bookId`) VALUES ('1', '1', '2');
INSERT INTO `database`.`equipforbooking` (`id`, `equipId`, `bookId`) VALUES ('2', '2', '2');

ALTER TABLE `database`.`equipforbooking` 
DROP FOREIGN KEY `Booking_M2M_FK2`,
DROP FOREIGN KEY `Equip_M2M_FK2`;
ALTER TABLE `database`.`equipforbooking` 
ADD CONSTRAINT `Booking_M2M_FK2`
  FOREIGN KEY (`bookId`)
  REFERENCES `database`.`booking` (`id`)
  ON DELETE CASCADE
  ON UPDATE NO ACTION,
ADD CONSTRAINT `Equip_M2M_FK2`
  FOREIGN KEY (`equipId`)
  REFERENCES `database`.`equipment` (`id`)
  ON DELETE CASCADE
  ON UPDATE NO ACTION;

ALTER TABLE `database`.`booking` 
DROP FOREIGN KEY `Booking_Room_FK1`,
DROP FOREIGN KEY `Booking_User_FK`;
ALTER TABLE `database`.`booking` 
ADD CONSTRAINT `Booking_Room_FK1`
  FOREIGN KEY (`roomId`)
  REFERENCES `database`.`catalog` (`id`)
  ON DELETE CASCADE
  ON UPDATE NO ACTION,
ADD CONSTRAINT `Booking_User_FK`
  FOREIGN KEY (`userId`)
  REFERENCES `database`.`users` (`id`)
  ON DELETE CASCADE
  ON UPDATE NO ACTION;

ALTER TABLE `database`.`catalog` 
DROP FOREIGN KEY `Room_RoomType_FK`;
ALTER TABLE `database`.`catalog` 
ADD CONSTRAINT `Room_RoomType_FK`
  FOREIGN KEY (`roomTypeId`)
  REFERENCES `database`.`roomtype` (`id`)
  ON DELETE CASCADE
  ON UPDATE NO ACTION;

ALTER TABLE `database`.`equipforroom` 
DROP FOREIGN KEY `Equip_M2M_FK`,
DROP FOREIGN KEY `Room_M2M_FK`;
ALTER TABLE `database`.`equipforroom` 
ADD CONSTRAINT `Equip_M2M_FK`
  FOREIGN KEY (`equipId`)
  REFERENCES `database`.`equipment` (`id`)
  ON DELETE CASCADE
  ON UPDATE NO ACTION,
ADD CONSTRAINT `Room_M2M_FK`
  FOREIGN KEY (`roomId`)
  REFERENCES `database`.`catalog` (`id`)
  ON DELETE CASCADE
  ON UPDATE NO ACTION;

