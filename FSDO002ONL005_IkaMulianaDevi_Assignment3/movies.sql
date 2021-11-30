-- phpMyAdmin SQL Dump
-- version 3.2.4
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Nov 30, 2021 at 05:46 AM
-- Server version: 5.1.41
-- PHP Version: 5.3.1

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `movies`
--

-- --------------------------------------------------------

--
-- Table structure for table `provided`
--

CREATE TABLE IF NOT EXISTS `provided` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `genre` varchar(25) NOT NULL,
  `duration` varchar(10) NOT NULL,
  `releasedate` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Dumping data for table `provided`
--

INSERT INTO `provided` (`id`, `name`, `genre`, `duration`, `releasedate`) VALUES
(1, 'Malficent', 'Sci-fi', '2h 9mins', '2017-08-07 00:00:00'),
(2, 'Avengers End Game', 'Sci-fi', '3h 2mins', '2020-08-17 00:00:00'),
(5, 'Thor Ragnarok', 'Sci-fi', '1h 50mins', '2017-07-22 00:00:00'),
(7, 'Annabelle', 'Horor', '1h 55mins', '2020-08-09 00:00:00'),
(8, 'Dilan', 'Romance', '1h 45mins', '2020-07-17 00:00:00');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
