-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  mer. 12 déc. 2018 à 11:10
-- Version du serveur :  5.7.23
-- Version de PHP :  7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `datasport`
--
CREATE DATABASE IF NOT EXISTS `datasport` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `datasport`;

-- --------------------------------------------------------

--
-- Structure de la table `tbl_address`
--

DROP TABLE IF EXISTS `tbl_address`;
CREATE TABLE IF NOT EXISTS `tbl_address` (
  `Id_Address` int(11) NOT NULL AUTO_INCREMENT,
  `Dt_Valid_From` datetime NOT NULL,
  `Dt_Valid_To` datetime DEFAULT NULL,
  `Txt_Street_Nr` varchar(10) DEFAULT NULL,
  `Txt_Street` varchar(100) NOT NULL,
  `Txt_Postal_Code` varchar(10) NOT NULL,
  `Nm_Location` varchar(50) NOT NULL,
  `Cd_Country` char(2) NOT NULL,
  `Id_Athlete` int(11) NOT NULL,
  PRIMARY KEY (`Id_Address`),
  KEY `fk_Tbl_Address_Tbl_Athlete1_idx` (`Id_Athlete`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `tbl_address`
--

INSERT INTO `tbl_address` (`Id_Address`, `Dt_Valid_From`, `Dt_Valid_To`, `Txt_Street_Nr`, `Txt_Street`, `Txt_Postal_Code`, `Nm_Location`, `Cd_Country`, `Id_Athlete`) VALUES
(1, '2000-01-01 00:00:00', '2001-12-12 00:00:00', '01', 'chemin emile paquin', '1212', 'maison', 'CH', 1),
(2, '2001-12-12 00:00:00', NULL, '05', 'Trimer', '1215', 'Galère', 'FR', 2),
(3, '2001-12-13 00:00:00', NULL, '26', 'rue du bout-du-monde', '1526', 'limite', 'UN', 1);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_athlete`
--

DROP TABLE IF EXISTS `tbl_athlete`;
CREATE TABLE IF NOT EXISTS `tbl_athlete` (
  `Id_Athlete` int(11) NOT NULL AUTO_INCREMENT,
  `Nm_First` varchar(45) NOT NULL,
  `Nm_Last` varchar(45) NOT NULL,
  `Dt_Birth` date NOT NULL,
  `Txt_Password_Hash` varchar(50) DEFAULT NULL,
  `Txt_Password_Salt` varchar(50) DEFAULT NULL,
  `Cd_Password_Hash_Algo` varchar(10) DEFAULT NULL,
  `Is_Deleted` tinyint(4) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id_Athlete`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `tbl_athlete`
--

INSERT INTO `tbl_athlete` (`Id_Athlete`, `Nm_First`, `Nm_Last`, `Dt_Birth`, `Txt_Password_Hash`, `Txt_Password_Salt`, `Cd_Password_Hash_Algo`, `Is_Deleted`) VALUES
(1, '1', '2', '1998-03-03', NULL, NULL, NULL, 0),
(2, '3', '5', '1997-05-11', NULL, NULL, NULL, 0);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_country`
--

DROP TABLE IF EXISTS `tbl_country`;
CREATE TABLE IF NOT EXISTS `tbl_country` (
  `Id_Country` int(11) NOT NULL AUTO_INCREMENT,
  `Cd_Country` char(2) NOT NULL,
  `Nm_Country` varchar(45) NOT NULL,
  PRIMARY KEY (`Id_Country`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `tbl_country`
--

INSERT INTO `tbl_country` (`Id_Country`, `Cd_Country`, `Nm_Country`) VALUES
(1, 'CH', 'Suisse'),
(2, 'FR', 'France'),
(3, 'UN', 'Nations Unie');

-- --------------------------------------------------------

--
-- Structure de la table `tbl_email`
--

DROP TABLE IF EXISTS `tbl_email`;
CREATE TABLE IF NOT EXISTS `tbl_email` (
  `Id_Email` int(11) NOT NULL AUTO_INCREMENT,
  `Txt_Email` varchar(100) NOT NULL,
  `Txt_Challenge` varchar(32) NOT NULL,
  `Is_Verified` tinyint(4) NOT NULL DEFAULT '0',
  `Id_Athlete` int(11) NOT NULL,
  PRIMARY KEY (`Id_Email`),
  KEY `fk_Tbl_Email_Tbl_Athlete1_idx` (`Id_Athlete`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `tbl_email`
--

INSERT INTO `tbl_email` (`Id_Email`, `Txt_Email`, `Txt_Challenge`, `Is_Verified`, `Id_Athlete`) VALUES
(1, 'tom.rsr@eduge.ch', 'uniqID', 1, 1);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_nationality`
--

DROP TABLE IF EXISTS `tbl_nationality`;
CREATE TABLE IF NOT EXISTS `tbl_nationality` (
  `Id_Athlete` int(11) NOT NULL,
  `Id_Country` int(11) NOT NULL,
  PRIMARY KEY (`Id_Athlete`,`Id_Country`),
  KEY `fk_table2_Tbl_Athlete1_idx` (`Id_Athlete`),
  KEY `fk_table2_Tbl_Country1` (`Id_Country`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `tbl_nationality`
--

INSERT INTO `tbl_nationality` (`Id_Athlete`, `Id_Country`) VALUES
(1, 1),
(1, 3),
(2, 2);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_race`
--

DROP TABLE IF EXISTS `tbl_race`;
CREATE TABLE IF NOT EXISTS `tbl_race` (
  `Id_Race` int(11) NOT NULL AUTO_INCREMENT,
  `Nm_Race` varchar(45) NOT NULL,
  `Dttm_Race` date NOT NULL,
  `Dist_In_Km` decimal(6,3) DEFAULT NULL,
  `Nm_Location` varchar(45) NOT NULL,
  `Id_Country` int(11) NOT NULL,
  PRIMARY KEY (`Id_Race`),
  KEY `fk_Tbl_Race_Tbl_Country1_idx` (`Id_Country`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `tbl_race`
--

INSERT INTO `tbl_race` (`Id_Race`, `Nm_Race`, `Dttm_Race`, `Dist_In_Km`, `Nm_Location`, `Id_Country`) VALUES
(1, 'première course de l\'association', '2001-05-22', '5.000', 'bout-du-monde', 1),
(2, 'deuxième course', '2001-05-23', '3.000', 'lac-léman', 1);

-- --------------------------------------------------------

--
-- Structure de la table `tbl_result`
--

DROP TABLE IF EXISTS `tbl_result`;
CREATE TABLE IF NOT EXISTS `tbl_result` (
  `Id_Athlete` int(11) NOT NULL,
  `Id_Race` int(11) NOT NULL,
  `Dttm_Registration` datetime NOT NULL,
  `Tm_Start` time DEFAULT NULL,
  `Tm_Finish` time DEFAULT NULL,
  `Tm_Gun_Start` time DEFAULT NULL,
  `Drn_In_Sec` decimal(6,1) DEFAULT NULL,
  PRIMARY KEY (`Id_Athlete`,`Id_Race`),
  KEY `fk_Tbl_Result_Tbl_Race1_idx` (`Id_Race`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `tbl_result`
--

INSERT INTO `tbl_result` (`Id_Athlete`, `Id_Race`, `Dttm_Registration`, `Tm_Start`, `Tm_Finish`, `Tm_Gun_Start`, `Drn_In_Sec`) VALUES
(1, 1, '2001-05-02 11:40:42', '10:05:00', '11:05:00', '10:05:05', '167.0'),
(2, 1, '2001-05-02 11:40:42', '10:05:00', '11:05:00', '10:05:05', '156.0');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `tbl_address`
--
ALTER TABLE `tbl_address`
  ADD CONSTRAINT `fk_Tbl_Address_Tbl_Athlete1` FOREIGN KEY (`Id_Athlete`) REFERENCES `tbl_athlete` (`Id_Athlete`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `tbl_email`
--
ALTER TABLE `tbl_email`
  ADD CONSTRAINT `fk_Tbl_Email_Tbl_Athlete1` FOREIGN KEY (`Id_Athlete`) REFERENCES `tbl_athlete` (`Id_Athlete`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `tbl_nationality`
--
ALTER TABLE `tbl_nationality`
  ADD CONSTRAINT `fk_table2_Tbl_Athlete1` FOREIGN KEY (`Id_Athlete`) REFERENCES `tbl_athlete` (`Id_Athlete`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_table2_Tbl_Country1` FOREIGN KEY (`Id_Country`) REFERENCES `tbl_country` (`Id_Country`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `tbl_race`
--
ALTER TABLE `tbl_race`
  ADD CONSTRAINT `fk_Tbl_Race_Tbl_Country1` FOREIGN KEY (`Id_Country`) REFERENCES `tbl_country` (`Id_Country`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `tbl_result`
--
ALTER TABLE `tbl_result`
  ADD CONSTRAINT `fk_Tbl_Result_Tbl_Athlete` FOREIGN KEY (`Id_Athlete`) REFERENCES `tbl_athlete` (`Id_Athlete`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Tbl_Result_Tbl_Race1` FOREIGN KEY (`Id_Race`) REFERENCES `tbl_race` (`Id_Race`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
