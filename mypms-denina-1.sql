CREATE DATABASE  IF NOT EXISTS `mypms` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `mypms`;
-- MySQL dump 10.13  Distrib 8.0.43, for Win64 (x86_64)
--
-- Host: localhost    Database: mypms
-- ------------------------------------------------------
-- Server version	8.0.43

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `department_types`
--

DROP TABLE IF EXISTS `department_types`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `department_types` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT 'IT Consultant',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `department_types`
--

LOCK TABLES `department_types` WRITE;
/*!40000 ALTER TABLE `department_types` DISABLE KEYS */;
INSERT INTO `department_types` VALUES (1,'IT Consultant'),(2,'Manager'),(3,'HR Employee'),(4,'Designer');
/*!40000 ALTER TABLE `department_types` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee_archive`
--

DROP TABLE IF EXISTS `employee_archive`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee_archive` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Employee_ID` varchar(45) NOT NULL,
  `Name` varchar(255) DEFAULT NULL,
  `Department` varchar(255) DEFAULT NULL,
  `EmailAddress` varchar(255) DEFAULT 'N/A',
  `BirthDate` datetime DEFAULT NULL,
  `ContactNo` varchar(255) DEFAULT 'N/A',
  `Salary` double DEFAULT '0',
  `TotalOfHours` int DEFAULT '0',
  `Overtime` int DEFAULT '0',
  `Paid` tinyint DEFAULT '0',
  `HireDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `Status` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID_UNIQUE` (`ID`),
  UNIQUE KEY `Employee_ID_UNIQUE` (`Employee_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee_archive`
--

LOCK TABLES `employee_archive` WRITE;
/*!40000 ALTER TABLE `employee_archive` DISABLE KEYS */;
INSERT INTO `employee_archive` VALUES (1,'123','was','IT Consultant','','2025-10-13 21:25:33','',3434343,0,0,0,'2025-11-05 21:25:33',NULL);
/*!40000 ALTER TABLE `employee_archive` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee_list`
--

DROP TABLE IF EXISTS `employee_list`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee_list` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Employee_ID` varchar(45) NOT NULL,
  `Name` varchar(255) DEFAULT NULL,
  `Department` varchar(255) DEFAULT NULL,
  `EmailAddress` varchar(255) DEFAULT 'N/A',
  `BirthDate` datetime DEFAULT NULL,
  `ContactNo` varchar(255) DEFAULT 'N/A',
  `Salary` double DEFAULT '0',
  `TotalOfHours` int DEFAULT '0',
  `Overtime` int DEFAULT '0',
  `Paid` tinyint DEFAULT '0',
  `HireDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `Status` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID_UNIQUE` (`ID`),
  UNIQUE KEY `Employee_ID_UNIQUE` (`Employee_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee_list`
--

LOCK TABLES `employee_list` WRITE;
/*!40000 ALTER TABLE `employee_list` DISABLE KEYS */;
INSERT INTO `employee_list` VALUES (1,'00001-EMP','Mark Shelo A. Denina','Manager','','2006-05-04 00:00:00','',50000,35,10,1,'2025-01-15 00:00:00',NULL),(2,'00002-EMP','Andrei Zantua','Designer','','2025-11-05 21:25:33','',50000,45,12,1,'2025-06-04 00:00:00',NULL),(3,'00003-EMP','Dan Dexter Yoingco','IT Consultant','N/A',NULL,NULL,50000,34,5,0,'2025-03-02 00:00:00',NULL),(4,'00004-EMP','Jami Villareal','Manager','N/A',NULL,NULL,50000,35,7,0,'2025-06-12 00:00:00',NULL),(5,'00005-EMP','CJ Villareal','HR Employee','N/A',NULL,NULL,50000,62,12,0,'2025-10-05 00:00:00',NULL),(7,'3445','test','Manager','test','2025-11-05 21:25:33','',32423423,0,0,0,'2025-11-05 21:25:33',NULL);
/*!40000 ALTER TABLE `employee_list` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employeetable`
--

DROP TABLE IF EXISTS `employeetable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employeetable` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Employee_Name` varchar(255) DEFAULT NULL,
  `Employee_ID` varchar(255) DEFAULT NULL,
  `Password` varchar(255) DEFAULT NULL,
  `Role` varchar(8) DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL,
  `TimeIn` time DEFAULT NULL,
  `TimeOut` time DEFAULT NULL,
  `Salary` decimal(13,4) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Verified_ID` (`Employee_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employeetable`
--

LOCK TABLES `employeetable` WRITE;
/*!40000 ALTER TABLE `employeetable` DISABLE KEYS */;
INSERT INTO `employeetable` VALUES (1,'Danni G. German','00001-HRA','admin000','HR Admin','Active','09:00:00','17:00:00',90000.0000),(2,'Hugh E. Jorgan','00001-HRE','hr123','HR','Active','09:00:00','17:00:00',90000.0000),(3,'Moe E. Lester','00002-HRE','hr456','HR','Inactive','09:00:00','17:00:00',90000.0000),(4,'Ayia V. Dickinson','00001-EMP','pass123','Employee','Inactive','09:00:00','17:00:00',90000.0000),(5,'Ash H. Hölle','00002-EMP','pass456','Employee','Active','09:00:00','17:00:00',90000.0000),(6,'Candice N. Üttzë','00003-EMP','pass789','Employee','Active','09:00:00','17:00:00',90000.0000);
/*!40000 ALTER TABLE `employeetable` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payroll_record`
--

DROP TABLE IF EXISTS `payroll_record`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payroll_record` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `date_time` varchar(255) DEFAULT NULL,
  `employee_id` varchar(255) DEFAULT NULL,
  `name` varchar(255) DEFAULT NULL,
  `department` varchar(255) DEFAULT NULL,
  `sss` double DEFAULT NULL,
  `philhealth` double DEFAULT NULL,
  `pagibig` double DEFAULT NULL,
  `gross_salary` double DEFAULT NULL,
  `net_salary` double DEFAULT NULL,
  `receipt_path` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payroll_record`
--

LOCK TABLES `payroll_record` WRITE;
/*!40000 ALTER TABLE `payroll_record` DISABLE KEYS */;
INSERT INTO `payroll_record` VALUES (3,'2025-10-26 20:04:26.137772','00001-EMP','Mark Shelo A. Denina','IT_Consultant',1000,1200,200,50000,47600,'C:\\Users\\Administrator\\Documents\\MyPMS_Receipts\\00001-EMP\\20251026_200421_00001-EMP.pdf'),(4,'2025-10-27 01:17:38.939632','00002-EMP','Andrei Zantua','IT_Consultant',0,0,0,50000,50000,'C:\\Users\\Administrator\\Documents\\MyPMS_Receipts\\00002-EMP\\20251027_011726_00002-EMP.pdf');
/*!40000 ALTER TABLE `payroll_record` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sss_contri_table`
--

DROP TABLE IF EXISTS `sss_contri_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sss_contri_table` (
  `range1` double DEFAULT NULL,
  `range2` double DEFAULT NULL,
  `contribution` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sss_contri_table`
--

LOCK TABLES `sss_contri_table` WRITE;
/*!40000 ALTER TABLE `sss_contri_table` DISABLE KEYS */;
INSERT INTO `sss_contri_table` VALUES (5250,5749.99,250),(5750,6249.99,275),(6250,6749.99,300),(6750,7249.99,325),(7250,7749.99,350),(7750,8249.99,375),(8250,8749.99,400),(8750,9249.99,425),(9250,9749.99,450),(9750,10249.99,475),(10250,10749.99,500),(10750,11249.99,525),(11250,11749.99,550),(11750,12249.99,575),(12250,12749.99,600),(12750,13249.99,625),(13250,13750,650),(14250,14750,675),(15250,15750,700),(16250,16750,725),(17250,17750,750),(18250,18749.99,775),(14249.99,14749.99,800),(15249.99,15749.99,825),(16249.99,16749.99,850),(17249.99,17749.99,875),(18249.99,18749.99,900),(18750,19249.99,925),(19250,19749.99,950),(19750,20249.99,975),(20250,20749.99,1000),(20750,21249.99,1000),(21250,21749.99,1000),(21750,22249.99,1000),(22250,22750,1000),(22749.99,23249.99,1000),(23250,23749.99,1000),(23750,24249.99,1000),(24250,24749.99,1000),(24750,25249.99,1000),(25250,25749.99,1000),(25750,26249.99,1000),(26250,26749.99,1000),(26750,27249.99,1000),(27250,27749.99,1000),(27750,28249.99,1000),(28250,28749.99,1000),(28750,29249.99,1000),(29250,29749.99,1000),(29750,30249.99,1000),(30250,30749.99,1000),(30750,31249.99,1000),(31250,31749.99,1000),(31750,32249.99,1000),(32250,32749.99,1000),(32750,33249.99,1000),(33250,33749.99,1000),(33750,34249.99,1000),(34250,34749.99,1000);
/*!40000 ALTER TABLE `sss_contri_table` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-11-06  0:25:29
