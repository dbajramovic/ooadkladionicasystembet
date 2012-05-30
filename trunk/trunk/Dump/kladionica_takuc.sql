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
-- Table structure for table `takuc`
--

DROP TABLE IF EXISTS `takuc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `takuc` (
  `IDTakmicenja` int(11) NOT NULL,
  `IDUcesnika` int(11) NOT NULL,
  `idtakuc` varchar(45) NOT NULL,
  PRIMARY KEY (`idtakuc`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `takuc`
--

LOCK TABLES `takuc` WRITE;
/*!40000 ALTER TABLE `takuc` DISABLE KEYS */;
INSERT INTO `takuc` VALUES (1,1,'1'),(1,10,'10'),(1,11,'11'),(1,12,'12'),(1,13,'13'),(1,14,'14'),(1,15,'15'),(1,16,'16'),(1,17,'17'),(1,18,'18'),(1,19,'19'),(1,2,'2'),(1,20,'20'),(2,21,'21'),(2,22,'22'),(2,23,'23'),(2,24,'24'),(2,25,'25'),(2,26,'26'),(2,27,'27'),(2,28,'28'),(2,29,'29'),(1,3,'3'),(2,30,'30'),(2,31,'31'),(2,32,'32'),(2,33,'33'),(2,34,'34'),(2,35,'35'),(2,36,'36'),(2,37,'37'),(2,38,'38'),(2,39,'39'),(1,4,'4'),(2,40,'40'),(5,41,'41'),(5,42,'42'),(5,43,'43'),(5,44,'44'),(5,45,'45'),(5,46,'46'),(5,47,'47'),(5,48,'48'),(5,49,'49'),(1,5,'5'),(5,50,'50'),(5,51,'51'),(5,52,'52'),(5,53,'53'),(5,54,'54'),(5,55,'55'),(5,56,'56'),(5,57,'57'),(5,58,'58'),(5,59,'59'),(1,6,'6'),(5,60,'60'),(5,61,'61'),(5,62,'62'),(5,63,'63'),(5,64,'64'),(5,65,'65'),(5,66,'66'),(1,7,'7'),(1,8,'8'),(1,9,'9');
/*!40000 ALTER TABLE `takuc` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2012-05-30 12:30:10
