DROP TABLE IF EXISTS `commande`;
DROP TABLE IF EXISTS `demande`;
DROP TABLE IF EXISTS `stock`;
DROP TABLE IF EXISTS `employe`;
DROP TABLE IF EXISTS `table`;
CREATE TABLE `stock` (
  `idStock` int NOT NULL,
  `Libelle` varchar(45) NOT NULL,
  `Categorie` varchar(45) NOT NULL,
  `Volume` int DEFAULT NULL,
  `Prix` int DEFAULT NULL,
  PRIMARY KEY (`idStock`)
);
CREATE TABLE `employe` (
  `idEmploye` int NOT NULL,
  `Nom` varchar(45) DEFAULT NULL,
  `Prenom` varchar(45) DEFAULT NULL,
  `Role` int DEFAULT NULL,
  PRIMARY KEY (`idEmploye`)
);
CREATE TABLE `table` (
  `idTable` int,
  `Libelle` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idTable`),
  UNIQUE KEY `Libelle_UNIQUE` (`Libelle`)
);
CREATE TABLE `demande` (
  `IDPKDemande` int NOT NULL AUTO_INCREMENT,
  `IDDemande` int DEFAULT NULL,
  `IDStock` int DEFAULT NULL,
  `Nombre` int DEFAULT NULL,
  `flagsupp` tinyint DEFAULT NULL,
  PRIMARY KEY (`IDPKDemande`),
  KEY `IDStock` (`IDStock`),
  CONSTRAINT `demande_ibfk_1` FOREIGN KEY (`IDStock`) REFERENCES `stock` (`idStock`)
);
CREATE TABLE `commande` (
  `idCommande` int NOT NULL AUTO_INCREMENT,
  `prix` int NOT NULL,
  `idDemande` int DEFAULT NULL,
  `idEmploye` int DEFAULT NULL,
  PRIMARY KEY (`idCommande`),
  KEY `idDemande` (`idDemande`),
  KEY `idEmploye` (`idEmploye`),
  CONSTRAINT `commande_ibfk_1` FOREIGN KEY (`idDemande`) REFERENCES `demande` (`IDPKDemande`),
  CONSTRAINT `commande_ibfk_2` FOREIGN KEY (`idEmploye`) REFERENCES `employe` (`idEmploye`)
);