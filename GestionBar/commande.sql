DROP TABLE IF EXISTS `commande`;
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
)