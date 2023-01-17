DROP TABLE IF EXISTS `stock`;
CREATE TABLE `stock` (
  `idStock` int NOT NULL,
  `Libelle` varchar(45) NOT NULL,
  `Volume` int DEFAULT NULL,
  `Prix` int DEFAULT NULL,
  PRIMARY KEY (`idStock`)
)