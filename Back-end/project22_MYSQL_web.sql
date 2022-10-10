CREATE SCHEMA `project22` ;


CREATE TABLE `ai_result` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `urc` int(11) NOT NULL,
  `result_id` int(11) DEFAULT NULL,
  `social_flag` varchar(2) DEFAULT NULL,
  `economical_flag` varchar(2) DEFAULT NULL,
  `envirment_flag` varchar(2) DEFAULT NULL,
  `influence_flag` varchar(2) DEFAULT NULL,
  `active` varchar(1) DEFAULT NULL,
  `date` varchar(10) DEFAULT NULL,
  `time` varchar(8) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;

CREATE TABLE `user` (
  `ID` int(11) NOT NULL,
  `urc` int(11) NOT NULL,
  `us_date` varchar(10) DEFAULT NULL,
  `us_time` varchar(8) DEFAULT NULL,
  `active` varchar(2) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT AUTO_INCREMENT=1 CHARSET=utf8mb4;

CREATE TABLE `set_name_answer` (
  `id` int(2) NOT NULL AUTO_INCREMENT,
  `set_name` varchar(30) DEFAULT NULL,
  `set_group` int(2) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4;
INSERT INTO `set_name_answer` VALUES (1,'Yes',1),(2,'No',1),(3,'No',2),(4,'Probably not',2),(5,'Probably yes',2),(6,'None',3),(7,'Very little',3),(8,'Some',3),(9,'A lot',3);

CREATE TABLE `result_question` (
  `ID` int(11) NOT NULL,
  `urc` int(11) NOT NULL,
  `social` int(2) DEFAULT NULL,
  `economical` int(2) DEFAULT NULL,
  `envirment` int(2) DEFAULT NULL,
  `influence` int(2) DEFAULT NULL,
  `active` varchar(1) DEFAULT NULL,
  `date` varchar(10) DEFAULT NULL,
  `time` varchar(8) DEFAULT NULL,
  PRIMARY KEY (`ID`,`urc`)
) ENGINE=InnoDB  AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;

CREATE TABLE `input_question` (
  `id` int(11) NOT NULL,
  `id_question` int(4) NOT NULL,
  `urc` int(11) NOT NULL,
  `active` varchar(1) DEFAULT NULL,
  `date` varchar(10) DEFAULT NULL,
  `time` varchar(8) DEFAULT NULL,
  `answer` int(2) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT AUTO_INCREMENT=1 CHARSET=utf8mb4;

CREATE TABLE `display_info_result` (
  `id` int(12) NOT NULL,
  `titel` longtext DEFAULT NULL,
  `link` tinytext DEFAULT NULL,
  `image_path` mediumtext DEFAULT NULL,
  `display_info_resultcol` varchar(45) DEFAULT NULL,
  `discription` mediumtext DEFAULT NULL,
  `source_information` mediumtext DEFAULT NULL,
  `date` varchar(10) DEFAULT NULL,
  `time` varchar(8) DEFAULT NULL,
  `category` int(4) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT AUTO_INCREMENT=1 CHARSET=utf8mb4;


CREATE TABLE `question` (
  `ID` int(4) NOT NULL AUTO_INCREMENT,
  `category` int(4) DEFAULT NULL,
  `question` tinytext DEFAULT NULL,
  `active` varchar(1) DEFAULT NULL,
  `date` varchar(10) DEFAULT NULL,
  `time` varchar(8) DEFAULT NULL,
  `sub_categorys` int(2) DEFAULT NULL,
  `show_sub_category` blob DEFAULT NULL,
  `set_categorys` int(2) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=1048 DEFAULT CHARSET=utf8mb4;

INSERT INTO `question` VALUES (1000,2002,'Will responsible purchasing policies be used within your business?','d','2022-10-01','22:32:24',0,'',NULL),(1001,2002,'Do you plan to use Fskattsedel for your business?','d','2022-10-01','22:32:40',0,'',NULL),(1002,2002,'Is it likely for your business to expand in the next few years?','d','2022-10-01','22:32:58',0,'',NULL),(1003,2002,'Would your business idea help generate profit for other companies ?','d','2022-10-01','22:33:18',0,'',NULL),(1004,2002,'Is it possible for the business to be developped without additional investments and infrastructure ?','d','2022-10-01','22:33:53',0,'',NULL),(1005,2002,'Are the produced services or goods affordable for the targeted customer ?','d','2022-10-01','22:34:14',0,'',NULL),(1006,2002,'How many existing competing market solutions would you estimate exist ?','d','2022-10-01','22:34:28',0,'',NULL),(1007,2002,'How much energy do you estimate your business will use ?','d','2022-10-01','22:34:41',0,'',NULL),(1008,2002,'Do you plan to use green energy for most of the energy consumption ?','d','2022-10-01','22:35:00',0,'',NULL),(1009,2002,'How much do you plan to invest to make your business more green ?','d','2022-10-01','22:35:13',0,'',NULL),(1010,2002,'Is it ahead of the technology compared to existing market solutions?','d','2022-10-01','22:35:32',0,'',NULL),(1011,2002,'By changing your processes to be more ecological, would your company still be able to satisfy customer needs?','d','2022-10-01','22:35:48',0,'',NULL),(1012,2001,'Are there any measures taken to improve working conditions ? Work from home, schedule, workload...','d','2022-10-01','22:36:06',0,'',NULL),(1013,2001,'Are there any measures taken to improve safety in the work environment ?','d','2022-10-01','22:36:17',0,'',NULL),(1014,2001,'Have you considered to give the opportunity to employees to unionize?','d','2022-10-01','22:37:04',0,'',NULL),(1015,2001,'Are there planned measures to prevent risks of child labour or social damage?','d','2022-10-01','22:37:47',0,'',NULL),(1016,2001,'Are there any risks today or in the future of an unhealthy work environment ?','d','2022-10-01','22:38:09',0,'',NULL),(1017,2001,'Is there a plan to allow for employees to have an health care hour (friskvård)','d','2022-10-01','22:38:49',0,'',NULL),(1018,2001,'Does the company plan to pay travel expenses to the employees?','d','2022-10-01','22:39:08',0,'',NULL),(1019,2001,'To what extent do you plan to include the employees in the company s decision making?','d','2022-10-01','22:40:34',0,'',NULL),(1020,2001,'Is the working environment suitable for people with disabilities?','d','2022-10-01','22:41:11',0,'',NULL),(1021,2001,'Do you have a strategy in order to support employment of staff with diverging ages, gender and religious views?','d','2022-10-01','22:41:30',0,'',NULL),(1022,2001,'Do you have a stategy to ensure equal pay regardless of gender?','d','2022-10-01','22:41:47',0,'',NULL),(1023,2001,'Do you plan to hire people from diveerging age groups ?','d','2022-10-01','22:42:05',0,'',NULL),(1024,2001,'Is there any plan to allow for interships and aprentices?','d','2022-10-01','22:42:57',0,'',NULL),(1025,2001,'Are there any collective agreements for employees ? Ex. collective agreements for the truck drivers?','d','2022-10-01','22:43:14',0,'',NULL),(1026,2003,'Is the process going to use extracted materials (metal, coal, oil)?','d','2022-10-01','22:43:35',0,'',NULL),(1027,2003,'Are fossil fuels planned to be used in some parts of the business process ?','d','2022-10-01','22:49:13',0,'',NULL),(1028,2003,'Are carbon dioxide emissions going to occur in some parts of the business process ?','d','2022-10-01','22:49:50',0,'',NULL),(1029,2003,'Will your business be able to switch to a more green energy source in the near future ? Ex electric trucks in the next 10 years','d','2022-10-01','22:56:13',0,'',NULL),(1030,2003,'Does your buisness idea involves direct or indirect animal use?','d','2022-10-01','22:56:30',0,'',NULL),(1031,2003,'Are there any measures taken against animal exploitation?','d','2022-10-01','22:56:46',0,'',NULL),(1032,2003,'Will there be animal product in your transformed goods ? Ex : animal fat in candies','d','2022-10-01','22:57:05',0,'',NULL),(1033,2003,'Do you plan to propose alternative for meat-based products (vegan...)','d','2022-10-01','22:57:21',0,'',NULL),(1034,2003,'Do your business idea plan to support locally sourced products or services?','d','2022-10-01','22:57:36',0,'',NULL),(1035,2003,'Are there releases of persistent or bioaccumulating chemicals in use or production of products ?','d','2022-10-01','22:57:55',0,'',NULL),(1036,2003,'Does your businss idea involves physical degradation of nature ? Ex : Taking down trees','d','2022-10-01','22:58:12',0,'',NULL),(1037,2003,'Is your business idea about producing goods ?','d','2022-10-01','22:58:32',0,'',NULL),(1038,2003,'Does the process or product contain any toxic chemicals? Ex : including suppliers','d','2022-10-01','22:58:46',0,'',NULL),(1039,2003,'Is the product designed with repairability in mind ?','d','2022-10-01','22:59:00',0,'',NULL),(1040,2003,'Is the process going to use the Reduce, Reuse, Recycle method ?','d','2022-10-01','22:59:17',0,'',NULL),(1041,2003,'Are there any dangerous residual products during the end-of-life cycle?','d','2022-10-01','22:59:31',0,'',NULL),(1042,2003,'How much byproduct is expected to remain from the production line ?','d','2022-10-01','22:59:49',0,'',NULL),(1043,2003,'How much of the waste product is going to be reused during the product lifecycle ?','d','2022-10-01','23:00:06',0,'',NULL),(1044,2003,'Willl the company take responsibility for the product life cycle?','d','2022-10-01','23:00:22',0,'',NULL),(1045,2004,'Do you plan to cooperate with other entepreneurs or companies with assignments regarding sustainibility?','d','2022-10-01','23:00:40',0,'',NULL),(1046,2004,'Do you plan to be a member in a union who work in order to promote sustainibility work?','d','2022-10-01','23:00:58',0,'',NULL),(1047,2004,'Do you plan to share information on how you work with sustainibility to other companies?','d','2022-10-01','23:01:15',0,'',NULL);

