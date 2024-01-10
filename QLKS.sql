﻿CREATE DATABASE QLKS
GO
USE QLKS
GO
CREATE TABLE NHANVIEN(
	MSNV INT NOT NULL IDENTITY(01,1),
	MANV AS N'NV' + RIGHT(N'00' + CAST(MSNV AS NVARCHAR(2)), 2) PERSISTED NOT NULL PRIMARY KEY,
	NHOTEN NVARCHAR(50) NOT NULL,
	NSDT NVARCHAR(10) NOT NULL,
	NGIOITINH NVARCHAR(4) NOT NULL,
	NEMAIL NVARCHAR(50) NOT NULL,
	CHUCVU NVARCHAR(50) NOT NULL,
	LUONG MONEY NOT NULL,
	NCCCD NVARCHAR(12), /*NEW*/
	NDIACHI NVARCHAR(100), /*NEW*/
	NNGSINH DATETIME /*NEW*/,
HOATDONG BIT NOT NULL DEFAULT 1
)
GO

CREATE TABLE LOAIPHONG(
	MALOAIPHG NVARCHAR(4) NOT NULL PRIMARY KEY,
	TENLOAIPHG NVARCHAR(10) NOT NULL,
	GIADEM MONEY NOT NULL,
	SUCCHUA TINYINT, /*NEW*/
	SOGIUONG TINYINT /*NEW*/
	/*XOA COT:
	MAXTRGTHANH 
	MAXTHIEUNHI
	MAXSOSINH*/
)
GO

CREATE TABLE KHACHHANG(
	MSKH INT NOT NULL IDENTITY(01,1),
	MAKH AS N'KH' + RIGHT(N'00' + CAST(MSKH AS NVARCHAR(2)), 2) PERSISTED NOT NULL PRIMARY KEY,
	KHOTEN NVARCHAR(50) NOT NULL,
	KSDT NVARCHAR(10) NOT NULL,
	QUOCTICH NVARCHAR(50) NOT NULL,
	KGIOITINH NVARCHAR(4) NOT NULL,
	KNGSINH DATETIME NOT NULL,
	KCCCD NVARCHAR(12) NOT NULL,
	KDIACHI NVARCHAR(100) NOT NULL,
	KEMAIL NVARCHAR(50), /*NEW*/
	STAYING BIT /*NEW*/,
	HOATDONG BIT NOT NULL DEFAULT 1
	/*XOA COT:
	CHECKIN
	CHECKOUT
	CHEKOUT
	ROOMID*/
)
GO

CREATE TABLE HOADON(
	MSHD INT NOT NULL IDENTITY(1,1),
	MAHD AS N'HD' + RIGHT(N'00000' + CAST(MSHD AS NVARCHAR(5)), 5) PERSISTED NOT NULL PRIMARY KEY,
	MAKH NVARCHAR(4) NOT NULL FOREIGN KEY REFERENCES KHACHHANG(MAKH),
	MANV NVARCHAR(4) NOT NULL FOREIGN KEY REFERENCES NHANVIEN(MANV),
	TONGTIEN MONEY,
	PHGTHUC NVARCHAR(50),
	NGTHANHTOAN SMALLDATETIME,
	NGXUATHD SMALLDATETIME,
	NGNHANPHG SMALLDATETIME,
	NGTRPHG SMALLDATETIME,
	NGNHANPHGTHAT SMALLDATETIME,
	NGTRPHGTHAT SMALLDATETIME
) 
GO

CREATE TABLE PHONG(
	MAPHG NVARCHAR(4) NOT NULL PRIMARY KEY,
	MALOAIPHG NVARCHAR(4) NOT NULL FOREIGN KEY REFERENCES LOAIPHONG(MALOAIPHG),
	TRANGTHAI NVARCHAR(50) NOT NULL,
	TANG TINYINT NOT NULL,
	GHICHU NVARCHAR(250),
	DONDEP NVARCHAR(20) NOT NULL
	/*XOA COT MAKS*/
)
GO

CREATE TABLE CTPHG(
	MAPHG NVARCHAR(4) NOT NULL FOREIGN KEY REFERENCES PHONG(MAPHG),
	MAHD NVARCHAR(7) NOT NULL FOREIGN KEY REFERENCES HOADON(MAHD),
	TIENDATPHG MONEY
)
GO

CREATE TABLE DICHVU(
	MSDV INT NOT NULL IDENTITY(1,1),
	MADV AS N'DV' + RIGHT(N'00' + CAST(MSDV AS NVARCHAR(2)), 2) PERSISTED NOT NULL PRIMARY KEY,
	TENDV NVARCHAR(20) NOT NULL,
	GIADV MONEY NOT NULL,
	HOATDONG BIT NOT NULL DEFAULT 1
)
GO

CREATE TABLE CTDV(
	MAHD NVARCHAR(7) NOT NULL FOREIGN KEY REFERENCES HOADON(MAHD),
	MADV NVARCHAR(4) NOT NULL FOREIGN KEY REFERENCES DICHVU(MADV),
	MAPHG NVARCHAR(4) NOT NULL FOREIGN KEY REFERENCES PHONG(MAPHG),
	SOLUONG INT NOT NULL,
	THOIGIANSD SMALLDATETIME NOT NULL
)
GO

CREATE TABLE TAIKHOAN(
	MANV NVARCHAR(4) NOT NULL FOREIGN KEY REFERENCES NHANVIEN(MANV),
	TENTK NVARCHAR(250) NOT NULL,
	MATKHAU NVARCHAR(250) NOT NULL,
HOATDONG BIT NOT NULL DEFAULT 1
) /*NEW*/
GO

CREATE TABLE DOANHTHU (
    THANG NVARCHAR(50) NOT NULL,
    NAM NVARCHAR(50) NOT NULL,
    TIENPHONG DECIMAL NULL,
    TIENDICHVU DECIMAL NULL,
    TIENLUONG DECIMAL NULL,
	TONGNHAP AS (ISNULL(TIENPHONG, 0) + ISNULL(TIENDICHVU, 0)),
    TIENDOANHTHU AS (ISNULL(TIENPHONG, 0) + ISNULL(TIENDICHVU, 0) - ISNULL(TIENLUONG, 0)),
    --PRIMARY KEY (THANG, NAM)
)
GO

CREATE FUNCTION CHECKROOM (@MAPHG NVARCHAR(4), @NGNHANPHG SMALLDATETIME, @NGTRPHG SMALLDATETIME)
RETURNS INT
AS
BEGIN
	DECLARE @MAHD1 NVARCHAR(7), @MAHD2 NVARCHAR(7)
	SELECT @MAHD1 = HOADON.MAHD	FROM HOADON 
									INNER JOIN CTPHG ON CTPHG.MAHD = HOADON.MAHD
									WHERE MAPHG = @MAPHG
									AND ((NGNHANPHG <= @NGNHANPHG AND NGTRPHG >= @NGNHANPHG AND NGTRPHGTHAT IS NULL) OR (NGNHANPHG <= @NGNHANPHG AND NGTRPHGTHAT >= @NGNHANPHG AND NGTRPHGTHAT IS NOT NULL)
									OR (NGNHANPHG <= @NGTRPHG AND NGTRPHG >= @NGTRPHG AND NGTRPHGTHAT IS NULL) OR (NGNHANPHG <= @NGTRPHG AND NGTRPHGTHAT >= @NGTRPHG AND NGTRPHGTHAT IS NOT NULL))
	SELECT @MAHD2 = HOADON.MAHD	FROM HOADON 
									INNER JOIN CTPHG ON CTPHG.MAHD = HOADON.MAHD
									WHERE MAPHG = @MAPHG
									AND ((NGNHANPHG>= @NGNHANPHG AND NGTRPHG <= @NGTRPHG AND NGTRPHGTHAT IS NULL) OR (NGNHANPHG >= @NGNHANPHG AND NGTRPHGTHAT <= @NGTRPHG AND NGTRPHGTHAT IS NOT NULL))
	IF(@MAHD1 IS NOT NULL OR @MAHD2 IS NOT NULL)
		RETURN 0
	ELSE
		RETURN 1
	RETURN -1
END
GO

CREATE FUNCTION TONGTIENDICHVU( @MAHD CHAR(7), @MADV CHAR(4))
RETURNS MONEY 
AS
BEGIN
	DECLARE @GIADV MONEY, @TONGSOLUONG INT
	SELECT @TONGSOLUONG = SUM(SOLUONG)FROM CTDV WHERE CTDV.MAHD = @MAHD AND MADV = @MADV
	SELECT @GIADV = GIADV FROM DICHVU WHERE MADV = @MADV
	RETURN @GIADV * @TONGSOLUONG
END
go 

CREATE TRIGGER TRG_CTPHG_TIENDATPHG
ON CTPHG
FOR INSERT
AS
BEGIN
	DECLARE @MAHD CHAR(7), @MAPHG CHAR(4), @NGNHANPHG SMALLDATETIME, @NGTRPHG SMALLDATETIME, @GIADEM MONEY
	SELECT @MAHD = MAHD, @MAPHG = MAPHG FROM INSERTED
	SELECT @NGNHANPHG = NGNHANPHG, @NGTRPHG = NGTRPHG FROM HOADON WHERE MAHD = @MAHD
	SELECT @GIADEM = GIADEM FROM LOAIPHONG, PHONG WHERE LOAIPHONG.MALOAIPHG = PHONG.MALOAIPHG AND MAPHG = @MAPHG
	
	UPDATE CTPHG
	SET TIENDATPHG = DATEDIFF(DAY, @NGNHANPHG, @NGTRPHG) * @GIADEM
	WHERE TIENDATPHG IS NULL
END
GO

CREATE TRIGGER TRG_HOADON_CTPHG_TONGTIEN
ON CTPHG
AFTER INSERT
AS
BEGIN
	DECLARE @MAHD CHAR(7), @MAPHG CHAR(5), @TIENDATPHG MONEY, @TONGTIEN MONEY
	SELECT @MAHD = MAHD, @MAPHG = MAPHG FROM INSERTED
	SELECT @TIENDATPHG = TIENDATPHG FROM CTPHG WHERE MAHD = @MAHD AND MAPHG = MAPHG
	SELECT @TONGTIEN = TONGTIEN FROM HOADON WHERE MAHD = @MAHD
	
	IF(@TONGTIEN IS NULL)
		UPDATE HOADON
		SET TONGTIEN = @TIENDATPHG
		WHERE MAHD = @MAHD
	ELSE
		UPDATE HOADON
		SET TONGTIEN = TONGTIEN + @TIENDATPHG
		WHERE MAHD = @MAHD
END
GO

CREATE TRIGGER TRG_HOADON_CTDV_TONGTIEN
ON CTDV
AFTER INSERT
AS
BEGIN
	DECLARE @MAHD CHAR(7), @MADV CHAR(5), @SOLUONG INT, @GIADV MONEY
	SELECT @MAHD = MAHD, @MADV = MADV, @SOLUONG = SOLUONG FROM INSERTED
	SELECT @GIADV = GIADV FROM DICHVU WHERE MADV = @MADV

	UPDATE HOADON
	SET TONGTIEN = TONGTIEN + @GIADV * @SOLUONG
	WHERE MAHD = @MAHD
END
GO

CREATE FUNCTION TONGTIENPHONGTHANG (@NAM INT, @THANG INT)
RETURNS DECIMAL(19,4)
AS
BEGIN
	DECLARE @TONGTIENPHG DECIMAL(19,4), @TIENPHG DECIMAL(19,4)
	DECLARE CUR CURSOR FOR
		SELECT CAST(TIENDATPHG AS DECIMAL(19,4))
		FROM CTPHG, HOADON
		WHERE CTPHG.MAHD = HOADON.MAHD
		AND YEAR(HOADON.NGTHANHTOAN) = @NAM AND MONTH(HOADON.NGTHANHTOAN) = @THANG

	SET @TONGTIENPHG = 0

	OPEN CUR 
	FETCH NEXT FROM CUR
		INTO @TIENPHG

	WHILE @@FETCH_STATUS = 0
	BEGIN
		SET @TONGTIENPHG = @TONGTIENPHG + @TIENPHG * 1.1
		FETCH NEXT FROM CUR
			INTO @TIENPHG
	END

	CLOSE CUR
	DEALLOCATE CUR

	RETURN @TONGTIENPHG
END
GO

CREATE FUNCTION TONGTIENDICHVUTHANG (@NAM INT, @THANG INT)
RETURNS DECIMAL(19,4)
AS
BEGIN
	DECLARE @TONGTIENDICHVU DECIMAL(19,4), @GIADV DECIMAL(19,4), @SOLUONG INT
	DECLARE CUR CURSOR FOR
		SELECT CAST(GIADV AS DECIMAL(19,4)), SOLUONG
		FROM CTDV, HOADON, DICHVU
		WHERE CTDV.MAHD = HOADON.MAHD AND CTDV.MADV = DICHVU.MADV
		AND YEAR(HOADON.NGTHANHTOAN) = @NAM AND MONTH(HOADON.NGTHANHTOAN) = @THANG

	SET @TONGTIENDICHVU = 0

	OPEN CUR 
	FETCH NEXT FROM CUR
		INTO @GIADV, @SOLUONG

	WHILE @@FETCH_STATUS = 0
	BEGIN
		SET @TONGTIENDICHVU = @TONGTIENDICHVU + @GIADV * @SOLUONG * 1.1
		FETCH NEXT FROM CUR
			INTO @GIADV, @SOLUONG
	END

	CLOSE CUR
	DEALLOCATE CUR

	RETURN @TONGTIENDICHVU
END
GO

CREATE FUNCTION TONGTIENLUONGTHANG ()
RETURNS DECIMAL(19,4)
AS
BEGIN
	DECLARE @TONGTIENLUONG DECIMAL(19,4)
	SELECT @TONGTIENLUONG = SUM(LUONG)
							FROM NHANVIEN
							WHERE HOATDONG = 1

	IF(@TONGTIENLUONG IS NULL)
		SET @TONGTIENLUONG = 0

	RETURN @TONGTIENLUONG
END	
GO

CREATE PROCEDURE DOANHTHUTUNGTHANG @NAM INT
AS
BEGIN
	CREATE TABLE #DOANHTHU(
		THANG INT,
		THUNHAP DECIMAL(19,4),
		CHIPHI DECIMAL(19,4),
		DOANHTHU DECIMAL(19,4)
		)
	DECLARE @PHONG DECIMAL(19,4), @DICHVU DECIMAL(19,4), @LUONG DECIMAL(19,4), @DOANHTHU DECIMAL(19,4), @THANG INT

	SET @THANG = 1
	SET @LUONG = DBO.TONGTIENLUONGTHANG()

	WHILE (@THANG <= 12)
	BEGIN
		SET @PHONG = DBO.TONGTIENPHONGTHANG(@NAM, @THANG)
		SET @DICHVU = DBO.TONGTIENDICHVUTHANG(@NAM, @THANG)
		SET @DOANHTHU = @PHONG + @DICHVU - @LUONG

		INSERT INTO #DOANHTHU VALUES(@THANG, @PHONG + @DICHVU, @LUONG, @DOANHTHU)

		SET @THANG = @THANG + 1
	END
	SELECT * FROM #DOANHTHU
	DROP TABLE #DOANHTHU
END
GO

CREATE PROCEDURE CHITIETDOANHTHUTUNGTHANG @NAM INT
AS
BEGIN
	CREATE TABLE #DOANHTHU(
		THANG INT,
		PHONG DECIMAL(19,4),
		DICHVU DECIMAL(19,4),
		LUONG DECIMAL(19,4),
		DOANHTHU DECIMAL(19,4)
		)
	DECLARE @PHONG DECIMAL(19,4), @DICHVU DECIMAL(19,4), @LUONG DECIMAL(19,4), @DOANHTHU DECIMAL(19,4), @THANG INT

	SET @THANG = 1
	SET @LUONG = DBO.TONGTIENLUONGTHANG()

	WHILE (@THANG <= 12)
	BEGIN
		SET @PHONG = DBO.TONGTIENPHONGTHANG(@NAM, @THANG)
		SET @DICHVU = DBO.TONGTIENDICHVUTHANG(@NAM, @THANG)
		SET @DOANHTHU = @PHONG + @DICHVU - @LUONG

		INSERT INTO #DOANHTHU VALUES(@THANG, @PHONG, @DICHVU, @LUONG, @DOANHTHU)

		SET @THANG = @THANG + 1
	END
	SELECT * FROM #DOANHTHU
	DROP TABLE #DOANHTHU
END
GO

INSERT INTO NHANVIEN (NHOTEN, NSDT, NGIOITINH, NEMAIL, CHUCVU, LUONG, NCCCD, NDIACHI, NNGSINH)
VALUES
(N'Lê Văn C', '0934567890', 'Nam', 'levanc@gmail.com', N'Quản lý', 10000000, '456789123', N'Số 3, Đường 3, Quận 3, TP.HCM', '1984-03-03'),
(N'Phạm Thị D', '0967890123', N'Nữ', 'phamd@gmail.com', N'Lễ tân', 7000000, '789123456', N'Số 4, Đường 4, Quận 4, TP.HCM', '1986-04-04')
GO

INSERT INTO LOAIPHONG (MALOAIPHG, TENLOAIPHG, GIADEM, SUCCHUA, SOGIUONG)
VALUES
('LP01', 'VIP', 1000000, 4, 2),
('LP02', 'Deluxe', 500000, 2, 1),
('LP03', 'Standard', 300000, 2, 1),
('LP04', 'Economy', 200000, 2, 1);
GO

INSERT INTO KHACHHANG (KHOTEN, KSDT, QUOCTICH, KGIOITINH, KNGSINH, KCCCD, KDIACHI, KEMAIL, STAYING)
VALUES
('John Smith', '0123456789', 'USA', 'Nam', '1990-01-01', 'US123456', '123 Main Street, New York, USA', 'johnsmith@gmail.com', 0),
('Mary Jones', '0987654321', 'UK', N'Nữ', '1991-02-02', 'UK987654', '456 High Street, London, UK', 'maryjones@gmail.com', 0)
GO

INSERT INTO PHONG (MAPHG, MALOAIPHG, TRANGTHAI, TANG, GHICHU, DONDEP)
VALUES
('P101', 'LP01', N'Bình thường', 1, N'', N'Đã dọn'),
('P102', 'LP02', N'Bảo trì', 1, N'', N'Đã dọn'),
('P103', 'LP03', N'Bình thường', 1, N'', N'Đã dọn'),
('P104', 'LP04', N'Bình thường', 1, N'', N'Đã dọn'),
('P201', 'LP01', N'Bảo trì', 2, N'', N'Đã dọn'),
('P202', 'LP02', N'Bình thường', 2, N'', N'Đã dọn'),
('P203', 'LP03', N'Bình thường', 2, N'', N'Đã dọn'),
('P204', 'LP04', N'Bình thường', 2, N'', N'Đã dọn');
GO

INSERT INTO DICHVU (TENDV, GIADV)
VALUES
(N'Ăn sáng', 50000),
(N'Ăn trưa', 100000),
(N'Ăn tối', 150000),
(N'Giặt ủi', 20000),
(N'Xe đưa đón', 500000);
GO

INSERT INTO TAIKHOAN(MANV, TENTK, MATKHAU)
VALUES
('NV01', 'ltc', 'ltc@')
GO
