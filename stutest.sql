/*
 Navicat Premium Data Transfer

 Source Server         : Test
 Source Server Type    : MySQL
 Source Server Version : 50648
 Source Host           : localhost:3306
 Source Schema         : stutest

 Target Server Type    : MySQL
 Target Server Version : 50648
 File Encoding         : 65001

 Date: 05/06/2020 19:34:06
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for class
-- ----------------------------
DROP TABLE IF EXISTS `class`;
CREATE TABLE `class`  (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `classes` varchar(2) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `gdatime` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 4 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of class
-- ----------------------------
INSERT INTO `class` VALUES (1, 'A', '2020-06-05');
INSERT INTO `class` VALUES (2, 'B', '2020-07-05');
INSERT INTO `class` VALUES (3, 'C', '2020-08-05');

-- ----------------------------
-- Table structure for class_course
-- ----------------------------
DROP TABLE IF EXISTS `class_course`;
CREATE TABLE `class_course`  (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `classes` varchar(8) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `course` varchar(8) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 7 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of class_course
-- ----------------------------
INSERT INTO `class_course` VALUES (1, '1', '1');
INSERT INTO `class_course` VALUES (2, '1', '4');
INSERT INTO `class_course` VALUES (3, '2', '1');
INSERT INTO `class_course` VALUES (4, '2', '2');
INSERT INTO `class_course` VALUES (5, '3', '3');
INSERT INTO `class_course` VALUES (6, '3', '5');

-- ----------------------------
-- Table structure for course
-- ----------------------------
DROP TABLE IF EXISTS `course`;
CREATE TABLE `course`  (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `course` varchar(6) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `teacher` varchar(3) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 6 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of course
-- ----------------------------
INSERT INTO `course` VALUES (1, 'JAVA', '周老师');
INSERT INTO `course` VALUES (2, 'C', '吴老师');
INSERT INTO `course` VALUES (3, 'C++', '吴老师');
INSERT INTO `course` VALUES (4, 'C#', '郑老师');
INSERT INTO `course` VALUES (5, 'Python', '郑老师');

-- ----------------------------
-- Table structure for student
-- ----------------------------
DROP TABLE IF EXISTS `student`;
CREATE TABLE `student`  (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(3) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `class` varchar(1) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 9 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of student
-- ----------------------------
INSERT INTO `student` VALUES (1, '李勇', 'A');
INSERT INTO `student` VALUES (2, '刘晨', 'A');
INSERT INTO `student` VALUES (3, '王敏', 'C');
INSERT INTO `student` VALUES (4, '张立', 'B');
INSERT INTO `student` VALUES (5, '刘琛', 'B');
INSERT INTO `student` VALUES (6, '李强', 'B');
INSERT INTO `student` VALUES (7, '张平', 'C');
INSERT INTO `student` VALUES (8, '陈树', 'A');

SET FOREIGN_KEY_CHECKS = 1;
