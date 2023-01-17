DROP TABLE IF EXISTS `employe`;
CREATE TABLE `employe` (
  `idEmploye` int NOT NULL,
  `Nom` varchar(45) DEFAULT NULL,
  `Prenom` varchar(45) DEFAULT NULL,
  `Role` int DEFAULT NULL,
  PRIMARY KEY (`idEmploye`)
)