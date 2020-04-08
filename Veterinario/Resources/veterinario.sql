-- MariaDB dump 10.17  Distrib 10.4.11-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: veterinario
-- ------------------------------------------------------
-- Server version	10.4.11-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Current Database: `veterinario`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `veterinario` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `veterinario`;

--
-- Table structure for table `animales`
--

DROP TABLE IF EXISTS `animales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `animales` (
  `codigo` int(9) NOT NULL,
  `nombre` varchar(25) NOT NULL,
  `nacimiento` date DEFAULT NULL,
  `raza` varchar(40) DEFAULT NULL,
  `dueño` varchar(10) NOT NULL,
  `especie` varchar(20) DEFAULT NULL,
  `sexo` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`codigo`),
  KEY `dueño` (`dueño`),
  CONSTRAINT `animales_ibfk_1` FOREIGN KEY (`dueño`) REFERENCES `cliente` (`dni`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `animales`
--

LOCK TABLES `animales` WRITE;
/*!40000 ALTER TABLE `animales` DISABLE KEYS */;
INSERT INTO `animales` VALUES (1,'Tula','2012-05-11','Pomerania','75953515P','Perro','Hembra'),(2,'Rayo','2019-06-01','Husky Siberiano','26351695T','Perro','Macho'),(3,'Drako','2017-08-24','Labrador','56954261H','Perro','Macho'),(4,'Nina','2015-04-30','Bengala','32621583Q','Gato','Hembra'),(5,'Bal','2014-06-18','Toyger','32621583Q','Gato','Macho');
/*!40000 ALTER TABLE `animales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `dni` varchar(10) NOT NULL,
  `nombre` varchar(25) NOT NULL,
  `apellido` varchar(25) NOT NULL,
  `direccion` varchar(100) DEFAULT NULL,
  `telefono` varchar(40) NOT NULL,
  `usuario` varchar(20) NOT NULL,
  `contraseña` varchar(20) NOT NULL,
  PRIMARY KEY (`dni`),
  UNIQUE KEY `usuario` (`usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES ('26351695T','Paula','Revuelta','Calle Postas 43','635156842','Revuelta','Maquinon'),('32621583Q','Miriam','Aguirre','Calle Moreras 66','605065319','Aguirre','Cardio'),('45856519G','Antonio','Reinosa','Calle Almibar 24','675963812','Reinosa','Motocarro'),('51545987A','Jose','Espinosa','Calle del Rey 57','654654632','Espinosa','Automovil'),('56954261H','Alberto','Prieto','Calle Florida 18','685296351','Prieto','Carricoche'),('75953515P','Ignaicio','Garcia','Calle Infantas 46','682153953','Garcia','Manuscrito'),('82493162L','Cristian','Perez','Calle Mostesinos 73','784621953','Perez','Esternon');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleado`
--

DROP TABLE IF EXISTS `empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empleado` (
  `dni` varchar(10) NOT NULL,
  `nombre` varchar(25) NOT NULL,
  `apellido` varchar(25) NOT NULL,
  `direccion` varchar(100) DEFAULT NULL,
  `telefono` varchar(40) NOT NULL,
  `usuario` varchar(20) NOT NULL,
  `contraseña` varchar(20) NOT NULL,
  PRIMARY KEY (`dni`),
  UNIQUE KEY `usuario` (`usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleado`
--

LOCK TABLES `empleado` WRITE;
/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
INSERT INTO `empleado` VALUES ('45856519G','Antonio','Reinosa','Calle Almibar 24','675963812','Reinosa','Motocarro'),('51545987A','Jose','Espinosa','Calle del Rey 57','654654632','Espinosa','Automovil'),('56954261H','Alberto','Prieto','Calle Florida 18','685296351','Prieto','Carricoche'),('82493162L','Cristian','Perez','Calle Mostesinos 73','784621953','Perez','Esternon');
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleado_animal`
--

DROP TABLE IF EXISTS `empleado_animal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empleado_animal` (
  `empleado` varchar(10) NOT NULL,
  `animal` int(9) NOT NULL,
  `fecha` date NOT NULL,
  `hora_inicio` time NOT NULL,
  `hora_final` time NOT NULL,
  KEY `empleado` (`empleado`),
  KEY `animal` (`animal`),
  CONSTRAINT `empleado_animal_ibfk_1` FOREIGN KEY (`empleado`) REFERENCES `empleado` (`dni`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `empleado_animal_ibfk_2` FOREIGN KEY (`animal`) REFERENCES `animales` (`codigo`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleado_animal`
--

LOCK TABLES `empleado_animal` WRITE;
/*!40000 ALTER TABLE `empleado_animal` DISABLE KEYS */;
/*!40000 ALTER TABLE `empleado_animal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleado_proceso`
--

DROP TABLE IF EXISTS `empleado_proceso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empleado_proceso` (
  `empleado` varchar(10) NOT NULL,
  `proceso` int(9) NOT NULL,
  KEY `empleado` (`empleado`),
  KEY `proceso` (`proceso`),
  CONSTRAINT `empleado_proceso_ibfk_1` FOREIGN KEY (`empleado`) REFERENCES `empleado` (`dni`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `empleado_proceso_ibfk_2` FOREIGN KEY (`proceso`) REFERENCES `proceso` (`codigo`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleado_proceso`
--

LOCK TABLES `empleado_proceso` WRITE;
/*!40000 ALTER TABLE `empleado_proceso` DISABLE KEYS */;
INSERT INTO `empleado_proceso` VALUES ('45856519G',4),('45856519G',5),('51545987A',1),('51545987A',6),('82493162L',7),('56954261H',3),('56954261H',2),('82493162L',5),('51545987A',4),('51545987A',2),('51545987A',3),('51545987A',1),('56954261H',4),('56954261H',1);
/*!40000 ALTER TABLE `empleado_proceso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proceso`
--

DROP TABLE IF EXISTS `proceso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proceso` (
  `codigo` int(9) NOT NULL,
  `nombre` varchar(25) NOT NULL,
  `descripcion` varchar(100) NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proceso`
--

LOCK TABLES `proceso` WRITE;
/*!40000 ALTER TABLE `proceso` DISABLE KEYS */;
INSERT INTO `proceso` VALUES (1,'Vacuna Antirrabitica','Vacuna para prevenir a rabia'),(2,'Castracion','Castramiento del animal'),(3,'Estirpacion','Estripacion de quiste'),(4,'Infeccion','Infeccion tratada con antibioticos'),(6,'Desinfeccion','Desinfecion del animal interior'),(7,'Certificado de salud','Observacion del animal de forma anual');
/*!40000 ALTER TABLE `proceso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proceso_animal`
--

DROP TABLE IF EXISTS `proceso_animal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proceso_animal` (
  `proceso` int(9) NOT NULL,
  `animal` int(9) NOT NULL,
  `fecha_inicio` date NOT NULL,
  `fecha_final` date DEFAULT NULL,
  KEY `proceso` (`proceso`),
  KEY `animal` (`animal`),
  CONSTRAINT `proceso_animal_ibfk_1` FOREIGN KEY (`proceso`) REFERENCES `proceso` (`codigo`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `proceso_animal_ibfk_2` FOREIGN KEY (`animal`) REFERENCES `animales` (`codigo`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proceso_animal`
--

LOCK TABLES `proceso_animal` WRITE;
/*!40000 ALTER TABLE `proceso_animal` DISABLE KEYS */;
INSERT INTO `proceso_animal` VALUES (6,4,'2020-04-03','2020-04-03'),(2,4,'2019-03-03','2019-03-05'),(2,1,'2020-01-29','2020-02-01'),(1,2,'2020-04-07','2020-04-07'),(1,3,'2020-03-03','2020-03-03'),(1,4,'2020-02-19','2020-02-19'),(7,5,'2020-01-25','2020-01-25');
/*!40000 ALTER TABLE `proceso_animal` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-04-08 12:37:22
