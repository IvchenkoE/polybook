ALTER TABLE `database`.`booking` 
ADD CONSTRAINT `Booking_User_FK`
  FOREIGN KEY (`userId`)
  REFERENCES `database`.`users` (`id`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;

ALTER TABLE `database`.`booking` 
ADD CONSTRAINT `Booking_Room_FK`
  FOREIGN KEY (`roomId`)
  REFERENCES `database`.`catalog` (`id`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;

ALTER TABLE `database`.`catalog` 
ADD CONSTRAINT `Room_RoomType_FK`
  FOREIGN KEY (`roomTypeId`)
  REFERENCES `database`.`roomtype` (`id`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;


ALTER TABLE `database`.`equipforroom` 
ADD CONSTRAINT `Equip_M2M_FK`
  FOREIGN KEY (`equipId`)
  REFERENCES `database`.`equipment` (`id`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION,
ADD CONSTRAINT `Room_M2M_FK`
  FOREIGN KEY (`roomId`)
  REFERENCES `database`.`catalog` (`id`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;


ALTER TABLE `database`.`equipforbooking` 
ADD CONSTRAINT `Equip_M2M_FK2`
  FOREIGN KEY (`equipId`)
  REFERENCES `database`.`equipment` (`id`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION,
ADD CONSTRAINT `Booking_M2M_FK2`
  FOREIGN KEY (`bookId`)
  REFERENCES `database`.`booking` (`id`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;
