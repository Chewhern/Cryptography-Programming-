-- phpMyAdmin SQL Dump
-- version 4.5.4.1deb2ubuntu2.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Oct 24, 2020 at 01:07 PM
-- Server version: 5.7.31-0ubuntu0.16.04.1
-- PHP Version: 7.0.33-0ubuntu0.16.04.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ChatApplication`
--

-- --------------------------------------------------------

--
-- Table structure for table `Chat_Message`
--

CREATE TABLE `Chat_Message` (
  `FK_ID` varchar(500) NOT NULL,
  `Message` text,
  `Sender_Name` varchar(500) DEFAULT NULL,
  `Receiver_Status` varchar(500) DEFAULT NULL,
  `Salt` text,
  `Nonce` text,
  `Int_ID` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `DF_Public_Key`
--

CREATE TABLE `DF_Public_Key` (
  `Requestor_1` varchar(500) CHARACTER SET utf8mb4 DEFAULT NULL,
  `Requestor_1_PK` text CHARACTER SET utf8mb4,
  `Last_Checked_Date_R1` datetime DEFAULT NULL,
  `Requestor_2` varchar(500) CHARACTER SET utf8mb4 DEFAULT NULL,
  `Requestor_2_PK` text CHARACTER SET utf8mb4,
  `Last_Checked_Date_R2` datetime DEFAULT NULL,
  `Status` varchar(500) CHARACTER SET utf8mb4 DEFAULT NULL,
  `ID` varchar(500) CHARACTER SET utf8mb4 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `Salt_Table`
--

CREATE TABLE `Salt_Table` (
  `User_Name` varchar(500) CHARACTER SET utf8mb4 NOT NULL,
  `Salt` varchar(500) CHARACTER SET utf8mb4 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `User`
--

CREATE TABLE `User` (
  `Email` text CHARACTER SET utf8mb4 NOT NULL,
  `User_Name` varchar(500) CHARACTER SET utf8mb4 NOT NULL,
  `Password` text CHARACTER SET utf8mb4 NOT NULL,
  `Status` varchar(500) CHARACTER SET utf8mb4 DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Chat_Message`
--
ALTER TABLE `Chat_Message`
  ADD PRIMARY KEY (`Int_ID`);

--
-- Indexes for table `DF_Public_Key`
--
ALTER TABLE `DF_Public_Key`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `Salt_Table`
--
ALTER TABLE `Salt_Table`
  ADD PRIMARY KEY (`Salt`);

--
-- Indexes for table `User`
--
ALTER TABLE `User`
  ADD PRIMARY KEY (`User_Name`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `Chat_Message`
--
ALTER TABLE `Chat_Message`
  MODIFY `Int_ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
