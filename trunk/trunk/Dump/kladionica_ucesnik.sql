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
-- Table structure for table `ucesnik`
--

DROP TABLE IF EXISTS `ucesnik`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ucesnik` (
  `iducesnik` int(11) NOT NULL AUTO_INCREMENT,
  `ime` varchar(45) DEFAULT NULL,
  `picpath` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`iducesnik`)
) ENGINE=InnoDB AUTO_INCREMENT=67 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ucesnik`
--

LOCK TABLES `ucesnik` WRITE;
/*!40000 ALTER TABLE `ucesnik` DISABLE KEYS */;
INSERT INTO `ucesnik` VALUES (1,'Chelsea FC London','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Chelsea.png'),(2,'Arsenal FC London','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Arsenal.png'),(3,'Manchester City FC','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\ManchesterCity.png'),(4,'Manchester United','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\ManchesterUTD.png'),(5,'Aston Villa','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\AstonVilla.png'),(6,'Bolton Wanderers','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Bolton.png'),(7,'Everton FC','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Everton.png'),(8,'Liverpool FC','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Liverpool.png'),(9,'Fulham','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Fulham.png'),(10,'Norwich City','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Norwich.png'),(11,'Swansea City','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Swansea.png'),(12,'Tottenham Hotspur','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Tottenham.png'),(13,'West Bromwhich Albion','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\WBA.png'),(14,'Newcastle United','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Newcastle.png'),(15,'Wolverhampton Wanderers','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Wolverhampton.png'),(16,'Blackburn Rovers','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Blackburn.png'),(17,'Sunderland','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Sunderland.png'),(18,'Queens Park Rangers','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\QPR.png'),(19,'Stoke City','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Stoke.png'),(20,'Wigan Athletic','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Wigan.png'),(21,'Atalanta','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Atalanta.png'),(22,'Bologna','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Bologna.png'),(23,'Catacia Calcio','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Catania.png'),(24,'AC Cesena ','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Cesena.png'),(25,'Chievo Verona','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Chievo.png'),(26,'ACF Fiorentina','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Fiorentina.png'),(27,'Juventus FC','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Juventus.png'),(28,'AS Roma','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Roma.png'),(29,'Novara Calcio','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Novara.png'),(30,'AC Milan','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\ACMilan.png'),(31,'FC Internazionale','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Inter.png'),(32,'Udinese Calcio','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Udinese.png'),(33,'AS Siena','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Siena.png'),(34,'SS Lazio','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Lazio'),(35,'Palermo','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Palermo.png'),(36,'Genoa','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Genoa.png'),(37,'Lecce','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Lecce.png'),(38,'Napoli','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Napoli.png'),(39,'Parma','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Parma.png'),(40,'Cagliari Calcio','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Cagliari.png'),(41,'Portland Trail Blazers','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Portland.png'),(42,'Golden State Warriors','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\GSW.png'),(43,'LA Clippers','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\LAC.png'),(44,'LA Lakers','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\LAL.png'),(45,'Phoenix Suns','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\PHX.png'),(46,'Utah Jazz','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\UTH.png'),(47,'Denver Nuggets','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\DEN.png'),(48,'Oklahoma City Thunder','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\OKC.png'),(49,'Dallas Mavericks','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\DAL.png'),(50,'San Antonio Spurs','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\SAS.png'),(51,'Houston Rockets','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\HOU.png'),(52,'New Orleans Hornets','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\NOH.png'),(53,'Memphis Grizzlies','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\MEM.png'),(54,'Atlanta Hawks','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\ATL.png'),(55,'Orlando Magic','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\ORL.gif'),(56,'Miami Heat','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\MIA.png'),(57,'Boston Celtics','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\BOS.png'),(58,'Brookly Nets','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\BRO.png'),(59,'Philadephia 76rs','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\PHI.png'),(60,'Washington Wizards','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\WAS.png'),(61,'Cleaveland Cavaliers','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\CLE.png'),(62,'Detroit Pistons','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\DET.png'),(63,'Minnesota Timberwolves','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\MIN.png'),(64,'MIlwakee Bucks','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\MIL.png'),(65,'Chicago Bulls','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\CHI.png'),(66,'Indiana Pacers','C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\IND.png');
/*!40000 ALTER TABLE `ucesnik` ENABLE KEYS */;
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
