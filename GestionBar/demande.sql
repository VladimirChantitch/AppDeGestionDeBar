DROP TABLE IF EXISTS `demande`;
CREATE TABLE `demande` (
  `IDPKDemande` int NOT NULL AUTO_INCREMENT,
  `IDDemande` int DEFAULT NULL,
  `IDStock` int DEFAULT NULL,
  `Nombre` int DEFAULT NULL,
  `flagsupp` tinyint DEFAULT NULL,
  PRIMARY KEY (`IDPKDemande`),
  KEY `IDStock` (`IDStock`),
  CONSTRAINT `demande_ibfk_1` FOREIGN KEY (`IDStock`) REFERENCES `stock` (`idStock`)
)