CREATE DATABASE  IF NOT EXISTS `datasport` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `datasport`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: datasport
-- ------------------------------------------------------
-- Server version	5.7.23

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tbl_address`
--

DROP TABLE IF EXISTS `tbl_address`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_address` (
  `Id_Address` int(11) NOT NULL AUTO_INCREMENT,
  `Dt_Valid_From` date NOT NULL,
  `Dt_Valid_To` date DEFAULT NULL,
  `Txt_Street_Nr` varchar(10) DEFAULT NULL,
  `Txt_Street` varchar(100) NOT NULL,
  `Txt_Postal_Code` varchar(10) NOT NULL,
  `Nm_Location` varchar(50) NOT NULL,
  `Id_Athlete` int(11) NOT NULL,
  `Id_Country` int(11) NOT NULL,
  PRIMARY KEY (`Id_Address`),
  KEY `fk_Tbl_Address_Tbl_Athlete1_idx` (`Id_Athlete`),
  KEY `fk_Tbl_Address_Tbl_Country_idx` (`Id_Country`),
  CONSTRAINT `fk_Tbl_Address_Tbl_Athlete1` FOREIGN KEY (`Id_Athlete`) REFERENCES `tbl_athlete` (`Id_Athlete`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Tbl_Address_Tbl_Country` FOREIGN KEY (`Id_Country`) REFERENCES `tbl_country` (`Id_Country`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_address`
--

LOCK TABLES `tbl_address` WRITE;
/*!40000 ALTER TABLE `tbl_address` DISABLE KEYS */;
INSERT INTO `tbl_address` VALUES (24,'2018-12-18','0001-01-01','26','ashdah','436','syfhah',31,2),(25,'2018-12-18',NULL,'46','ashah','2526','asddgah',32,1),(26,'2018-12-18','0001-01-01','3433','sgdsa','757','sbhah',33,1),(27,'2018-12-18',NULL,'236','asgashgg','6436','asha',34,1),(28,'2018-12-19','0001-01-01','42','la campagne','404','Pokemon World',35,2);
/*!40000 ALTER TABLE `tbl_address` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_athlete`
--

DROP TABLE IF EXISTS `tbl_athlete`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_athlete` (
  `Id_Athlete` int(11) NOT NULL AUTO_INCREMENT,
  `Nm_First` varchar(45) NOT NULL,
  `Nm_Last` varchar(45) NOT NULL,
  `Dt_Birth` date NOT NULL,
  `Txt_Password_Hash` varchar(50) DEFAULT NULL,
  `Txt_Password_Salt` varchar(50) DEFAULT NULL,
  `Cd_Password_Hash_Algo` varchar(10) DEFAULT NULL,
  `Is_Deleted` tinyint(4) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id_Athlete`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_athlete`
--

LOCK TABLES `tbl_athlete` WRITE;
/*!40000 ALTER TABLE `tbl_athlete` DISABLE KEYS */;
INSERT INTO `tbl_athlete` VALUES (31,'bobi','bobi','2018-12-18',NULL,NULL,NULL,0),(32,'bob','bob','2018-12-18',NULL,NULL,NULL,0),(33,'Michelle','Jackie','2018-12-19',NULL,NULL,NULL,0),(34,'ashah','ahh','2018-12-18',NULL,NULL,NULL,0),(35,'Dylan','Peiry','1998-02-17',NULL,NULL,NULL,0);
/*!40000 ALTER TABLE `tbl_athlete` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_country`
--

DROP TABLE IF EXISTS `tbl_country`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_country` (
  `Id_Country` int(11) NOT NULL AUTO_INCREMENT,
  `Cd_Country` char(2) NOT NULL,
  `Nm_Country` varchar(45) NOT NULL,
  PRIMARY KEY (`Id_Country`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_country`
--

LOCK TABLES `tbl_country` WRITE;
/*!40000 ALTER TABLE `tbl_country` DISABLE KEYS */;
INSERT INTO `tbl_country` VALUES (1,'FR','France'),(2,'CH','Suisse');
/*!40000 ALTER TABLE `tbl_country` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_email`
--

DROP TABLE IF EXISTS `tbl_email`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_email` (
  `Id_Email` int(11) NOT NULL AUTO_INCREMENT,
  `Txt_Email` varchar(100) NOT NULL,
  `Txt_Challenge` varchar(32) NOT NULL,
  `Is_Verified` tinyint(4) NOT NULL DEFAULT '0',
  `Id_Athlete` int(11) NOT NULL,
  PRIMARY KEY (`Id_Email`),
  KEY `fk_Tbl_Email_Tbl_Athlete1_idx` (`Id_Athlete`),
  CONSTRAINT `fk_Tbl_Email_Tbl_Athlete1` FOREIGN KEY (`Id_Athlete`) REFERENCES `tbl_athlete` (`Id_Athlete`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_email`
--

LOCK TABLES `tbl_email` WRITE;
/*!40000 ALTER TABLE `tbl_email` DISABLE KEYS */;
INSERT INTO `tbl_email` VALUES (14,'asaasgsa','',0,31),(15,'wasdga','',0,32),(16,'ash','',0,33),(17,'as','',0,34),(18,'dylan@peiry.com','',0,35);
/*!40000 ALTER TABLE `tbl_email` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_nationality`
--

DROP TABLE IF EXISTS `tbl_nationality`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_nationality` (
  `Id_Athlete` int(11) NOT NULL,
  `Id_Country` int(11) NOT NULL,
  PRIMARY KEY (`Id_Athlete`,`Id_Country`),
  KEY `fk_table2_Tbl_Athlete1_idx` (`Id_Athlete`),
  KEY `fk_table2_Tbl_Country1` (`Id_Country`),
  CONSTRAINT `fk_table2_Tbl_Athlete1` FOREIGN KEY (`Id_Athlete`) REFERENCES `tbl_athlete` (`Id_Athlete`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_table2_Tbl_Country1` FOREIGN KEY (`Id_Country`) REFERENCES `tbl_country` (`Id_Country`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_nationality`
--

LOCK TABLES `tbl_nationality` WRITE;
/*!40000 ALTER TABLE `tbl_nationality` DISABLE KEYS */;
INSERT INTO `tbl_nationality` VALUES (31,2),(32,1),(33,1),(34,1),(35,2);
/*!40000 ALTER TABLE `tbl_nationality` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_race`
--

DROP TABLE IF EXISTS `tbl_race`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_race` (
  `Id_Race` int(11) NOT NULL AUTO_INCREMENT,
  `Nm_Race` varchar(45) NOT NULL,
  `Dttm_Race` date NOT NULL,
  `Dist_In_Km` decimal(6,3) DEFAULT NULL,
  `Nm_Location` varchar(45) NOT NULL,
  `Id_Country` int(11) NOT NULL,
  PRIMARY KEY (`Id_Race`),
  KEY `fk_Tbl_Race_Tbl_Country1_idx` (`Id_Country`),
  CONSTRAINT `fk_Tbl_Race_Tbl_Country1` FOREIGN KEY (`Id_Country`) REFERENCES `tbl_country` (`Id_Country`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_race`
--

LOCK TABLES `tbl_race` WRITE;
/*!40000 ALTER TABLE `tbl_race` DISABLE KEYS */;
INSERT INTO `tbl_race` VALUES (3,'Course 1','2018-12-19',50.250,'Genève',2),(4,'test edited','2018-12-19',325.000,'Paris',1);
/*!40000 ALTER TABLE `tbl_race` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_result`
--

DROP TABLE IF EXISTS `tbl_result`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_result` (
  `Id_Athlete` int(11) NOT NULL,
  `Id_Race` int(11) NOT NULL,
  `Dttm_Registration` datetime NOT NULL,
  `Tm_Start` time DEFAULT NULL,
  `Tm_Finish` time DEFAULT NULL,
  `Tm_Gun_Start` time DEFAULT NULL,
  `Drn_In_Sec` decimal(6,1) DEFAULT NULL,
  PRIMARY KEY (`Id_Athlete`,`Id_Race`),
  KEY `fk_Tbl_Result_Tbl_Race1_idx` (`Id_Race`),
  CONSTRAINT `fk_Tbl_Result_Tbl_Athlete` FOREIGN KEY (`Id_Athlete`) REFERENCES `tbl_athlete` (`Id_Athlete`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Tbl_Result_Tbl_Race1` FOREIGN KEY (`Id_Race`) REFERENCES `tbl_race` (`Id_Race`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_result`
--

LOCK TABLES `tbl_result` WRITE;
/*!40000 ALTER TABLE `tbl_result` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_result` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-12-19 15:31:57
