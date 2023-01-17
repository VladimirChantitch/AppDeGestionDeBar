DROP TABLE IF EXISTS `table`;
CREATE TABLE `table` (
  `idTable` int,
  `Libelle` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idTable`),
  UNIQUE KEY `Libelle_UNIQUE` (`Libelle`)
);