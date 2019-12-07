-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Dec 07, 2019 at 12:37 AM
-- Server version: 5.7.24-log
-- PHP Version: 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `flowers`
--

-- --------------------------------------------------------

--
-- Table structure for table `flowers_table`
--

CREATE TABLE `flowers_table` (
  `flower_id` int(20) UNSIGNED NOT NULL COMMENT 'primary_key',
  `flower_name` varchar(255) COLLATE latin1_bin DEFAULT NULL,
  `flower_description` mediumtext COLLATE latin1_bin
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_bin;

--
-- Dumping data for table `flowers_table`
--

INSERT INTO `flowers_table` (`flower_id`, `flower_name`, `flower_description`) VALUES
(1, 'Lotus', 'The Lotus (Nelumbo nucifera) symbolizes purity, beauty, majesty, grace, fertility, wealth, richness, knowledge and serenity'),
(2, 'Tulip', 'Tulips (Tulipa) form a genus of spring-blooming perennial herbaceous bulbiferous geophytes (having bulbs as storage organs)'),
(3, 'Lily', 'The lily is a genus of flowering plant. There are many species of lilies, like trumpet lilies and tiger lilies. They are usually quite tall, and are perennials.'),
(4, 'Sunflower', 'Sunflower, Helianthus annuus, is an herbaceous annual plant in the family Asteraceae, grown for its seeds. The plant has a thick, hairy, erect stem which gives rise to a large flower head. ... Sunflowers are annual plants, harvested after one growing season and can reach 1–3.5 m (3.3–11.5 ft) in height.'),
(5, 'Rose', 'A rose is a woody perennial flowering plant of the genus Rosa, in the family Rosaceae, or the flower it bears.');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `flowers_table`
--
ALTER TABLE `flowers_table`
  ADD PRIMARY KEY (`flower_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `flowers_table`
--
ALTER TABLE `flowers_table`
  MODIFY `flower_id` int(20) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'primary_key', AUTO_INCREMENT=13;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
