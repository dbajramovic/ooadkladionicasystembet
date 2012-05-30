CREATE DATABASE  IF NOT EXISTS `kladionica` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `kladionica`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: kladionica
-- ------------------------------------------------------
-- Server version	5.5.23

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
-- Table structure for table `dogadjaji`
--

DROP TABLE IF EXISTS `dogadjaji`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dogadjaji` (
  `ImePU` varchar(30) DEFAULT NULL,
  `ImeDU` varchar(30) DEFAULT NULL,
  `Kvota1` decimal(3,2) DEFAULT '1.00',
  `KvotaX` decimal(3,2) DEFAULT '1.00',
  `Kvota2` decimal(3,2) DEFAULT '1.00',
  `Kvota1X` decimal(3,2) DEFAULT '1.00',
  `KvotaX2` decimal(3,2) DEFAULT '1.00',
  `Kvota12` decimal(3,2) DEFAULT '1.00',
  `Rezultat` int(11) DEFAULT '-1',
  `DatumOdrzavanja` varchar(30) DEFAULT NULL,
  `SatnicaOdrzavanja` int(11) DEFAULT '1200',
  `IdDogadjaja` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`IdDogadjaja`),
  UNIQUE KEY `Id Dogadjaja` (`IdDogadjaja`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dogadjaji`
--

LOCK TABLES `dogadjaji` WRITE;
/*!40000 ALTER TABLE `dogadjaji` DISABLE KEYS */;
INSERT INTO `dogadjaji` VALUES ('West Bromwhich Albion','Chelsea FC London',2.00,1.45,1.90,1.51,1.00,1.10,-1,'16.5.2012. 17:32:15',1700,22),('Chelsea FC London','Tottenham Hotspur',1.00,1.00,1.00,1.00,1.00,1.00,-1,'7.6.2012. 17:36:39',0,23),('Manchester City FC','Queens Park Rangers',2.10,1.00,1.00,1.00,1.00,1.00,-1,'24.5.2012. 10:19:43',1200,24),('Everton FC','Newcastle United',2.10,1.00,1.00,1.00,1.00,1.00,-1,'24.5.2012. 10:19:43',1200,25),('Sunderland','Manchester United',2.10,1.00,1.00,1.01,1.00,1.00,-1,'24.5.2012. 10:19:43',1200,26),('Houston Rockets','Portland Trail Blazers',1.00,3.00,1.00,1.00,1.00,1.00,-1,'22.5.2012. 13:31:29',0,27);
/*!40000 ALTER TABLE `dogadjaji` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2012-05-30 12:30:09
