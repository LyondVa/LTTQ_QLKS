﻿ALTER TABLE [dbo].[employee]
ADD [position] INT NULL;
select * from employee

CREATE TABLE LOAIPHONG(
	MALOAIPHG CHAR(4) NOT NULL PRIMARY KEY,
	TENLOAIPHG VARCHAR(10),
	GIADEM MONEY,
	MAXTRGTHANH TINYINT,
	MAXTHIEUNHI TINYINT,
	MAXSOSINH TINYINT
)
CREATE TABLE PHONG(
	MAPHG CHAR(4) NOT NULL PRIMARY KEY,
	MALOAIPHG CHAR(4) FOREIGN KEY REFERENCES LOAIPHONG(MALOAIPHG),
	TRANGTHAI VARCHAR(10),
)
ALTER TABLE PHONG
ADD TANG TINYINT

ALTER TABLE LOAIPHONG
ALTER COLUMN TENLOAIPHG VARCHAR(50)
