﻿CREATE TABLE NHANVIEN(
	MSNV INT NOT NULL IDENTITY(01,1),
	MANV AS N'NV' + RIGHT(N'00' + CAST(MSNV AS NVARCHAR(2)), 2) PERSISTED NOT NULL PRIMARY KEY,
	NHOTEN NVARCHAR(50) NOT NULL,
	NSDT NVARCHAR(10) NOT NULL,
	NGIOITINH NVARCHAR(4) NOT NULL,
	NEMAIL NVARCHAR(50) NOT NULL,
	CHUCVU NVARCHAR(50) NOT NULL,
	LUONG MONEY NOT NULL,
	NCCCD NVARCHAR(10), /*NEW*/
	NDIACHI NVARCHAR(100), /*NEW*/
	NNGSINH DATETIME /*NEW*/
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
	STAYING BIT /*NEW*/
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
	--NGNHANPHG DATETIME NOT NULL,
	--NGTRPHG DATETIME NOT NULL,
	TIENDATPHG MONEY NOT NULL,
)
GO

CREATE TABLE DICHVU(
	MADV NVARCHAR(4) NOT NULL PRIMARY KEY,
	TENDV NVARCHAR(20) NOT NULL,
	GIADV MONEY NOT NULL
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
	MATKHAU NVARCHAR(250) NOT NULL
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
-- Sample data for NHANVIEN table
INSERT INTO NHANVIEN (NHOTEN, NSDT, NGIOITINH, NEMAIL, CHUCVU, LUONG, NCCCD, NDIACHI, NNGSINH)
VALUES
(N'Nguyễn Văn A', '0987654321', 'Nam', 'nguyenvana@gmail.com', N'Giám đốc', 20000000, '123456789', N'Số 1, Đường 1, Quận 1, TP.HCM', '1980-01-01'),
(N'Trần Thị B', '0912345678', N'Nữ', 'tranb@gmail.com', N'Phó giám đốc', 15000000, '987654321', N'Số 2, Đường 2, Quận 2, TP.HCM', '1982-02-02'),
(N'Lê Văn C', '0934567890', 'Nam', 'levanc@gmail.com', N'Quản lý', 10000000, '456789123', N'Số 3, Đường 3, Quận 3, TP.HCM', '1984-03-03'),
(N'Phạm Thị D', '0967890123', N'Nữ', 'phamd@gmail.com', N'Nhân viên', 7000000, '789123456', N'Số 4, Đường 4, Quận 4, TP.HCM', '1986-04-04'),
(N'Hoàng Văn E', '0923456789', 'Nam', 'hoange@gmail.com', N'Nhân viên', 7000000, '345678912', N'Số 5, Đường 5, Quận 5, TP.HCM', '1988-05-05');
GO

-- Sample data for LOAIPHONG table
INSERT INTO LOAIPHONG (MALOAIPHG, TENLOAIPHG, GIADEM, SUCCHUA, SOGIUONG)
VALUES
('LP01', 'VIP', 1000000, 4, 2),
('LP02', 'Deluxe', 500000, 2, 1),
('LP03', 'Standard', 300000, 2, 1),
('LP04', 'Economy', 200000, 2, 1);
GO

-- Sample data for KHACHHANG table
INSERT INTO KHACHHANG (KHOTEN, KSDT, QUOCTICH, KGIOITINH, KNGSINH, KCCCD, KDIACHI, KEMAIL, STAYING)
VALUES
('John Smith', '0123456789', 'USA', 'Nam', '1990-01-01', 'US123456', '123 Main Street, New York, USA', 'johnsmith@gmail.com', 1),
('Mary Jones', '0987654321', 'UK', N'Nữ', '1991-02-02', 'UK987654', '456 High Street, London, UK', 'maryjones@gmail.com', 1),
('David Lee', '0345678901', 'Singapore', 'Nam', '1992-03-03', 'SG345678', '789 Orchard Road, Singapore', 'davidlee@gmail.com', 0),
('Anna Nguyen', '0567890123', 'Vietnam', N'Nữ', '1993-04-04', 'VN567890', N'12 Lê Lợi, Quận 1, TP.HCM', 'annanguyen@gmail.com', 0),
('Peter Tran', '0789012345', 'Australia', 'Nam', '1994-05-05', 'AU789012', '34 Sydney Road, Melbourne, Australia', 'petertran@gmail.com', 1);
GO

-- Sample data for HOADON table
INSERT INTO HOADON (MAKH, MANV, TONGTIEN, PHGTHUC, NGTHANHTOAN, NGXUATHD, NGNHANPHG, NGTRPHG, NGNHANPHGTHAT, NGTRPHGTHAT)
VALUES
('KH01', 'NV01', 3000000, 'Tiền mặt', '2023-12-01 10:00:00', '2023-12-01 10:00:00', '2023-12-01 14:00:00', '2023-12-04 12:00:00', '2023-12-01 14:00:00', '2023-12-04 12:00:00'),
('KH02', 'NV02', 1500000, 'Thẻ tín dụng', '2023-12-02 11:00:00', '2023-12-02 11:00:00', '2023-12-02 14:00:00', '2023-12-03 12:00:00', '2023-12-02 14:00:00', '2023-12-03 12:00:00'),
('KH03', 'NV03', 900000, 'Tiền mặt', '2023-12-03 12:00:00', '2023-12-03 12:00:00', '2023-12-03 14:00:00', '2023-12-04 12:00:00', '2023-12-03 14:00:00', '2023-12-04 12:00:00'),
('KH04', 'NV04', 600000, 'Thẻ tín dụng', '2023-12-04 13:00:00', '2023-12-04 13:00:00', '2023-12-04 14:00:00', '2023-12-06 12:00:00', '2023-12-04 14:00:00', '2023-12-06 12:00:00'),
('KH05', 'NV05', 2000000, 'Tiền mặt', '2023-12-05 14:00:00', '2023-12-05 14:00:00', '2023-12-05 14:00:00', '2023-12-07 12:00:00', '2023-12-05 14:00:00', '2023-12-07 12:00:00');
GO

-- Sample data for PHONG table
INSERT INTO PHONG (MAPHG, MALOAIPHG, TRANGTHAI, TANG, GHICHU, DONDEP)
VALUES
('P101', 'LP01', N'Bình thường', 1, N'Phòng VIP có ban công nhìn ra hồ bơi', N'Đã dọn'),
('P102', 'LP02', N'Bảo trì', 1, N'Phòng Deluxe có tivi màn hình cong', N'Đã dọn'),
('P103', 'LP03', N'Bình thường', 1, N'Phòng Standard có máy lạnh', N'Đã dọn'),
('P104', 'LP04', N'Bình thường', 1, N'Phòng Economy có quạt', N'Đã dọn'),
('P201', 'LP01', N'Bảo trì', 2, N'Phòng VIP có bồn tắm nằm', N'Đã dọn'),
('P202', 'LP02', N'Bình thường', 2, N'Phòng Deluxe có tủ lạnh mini', N'Đã dọn'),
('P203', 'LP03', N'Bình thường', 2, N'Phòng Standard có bàn làm việc', N'Đã dọn'),
('P204', 'LP04', N'Bình thường', 2, N'Phòng Economy có bàn ghế', N'Đã dọn');
GO

-- Sample data for CTPHG table
INSERT INTO CTPHG (MAPHG, MAHD, TIENDATPHG)
VALUES
('P101', 'HD00001', 1000000),
('P102', 'HD00002', 500000),
('P104', 'HD00003', 200000),
('P201', 'HD00004', 1000000),
('P204', 'HD00005', 200000);
GO

-- Sample data for DICHVU table
INSERT INTO DICHVU (MADV, TENDV, GIADV)
VALUES
('DV01', N'Ăn sáng', 50000),
('DV02', N'Ăn trưa', 100000),
('DV03', N'Ăn tối', 150000),
('DV04', N'Giặt ủi', 20000),
('DV05', N'Xe đưa đón', 500000);
GO

-- Sample data for CTDV table
INSERT INTO CTDV (MAHD, MADV, MAPHG, SOLUONG, THOIGIANSD)
VALUES
('HD00001', 'DV01', 'P101', 2, '2023-12-02 07:00:00'),
('HD00001', 'DV02', 'P101', 2, '2023-12-02 12:00:00'),
('HD00001', 'DV03', 'P101', 2, '2023-12-02 18:00:00'),
('HD00002', 'DV01', 'P102', 1, '2023-12-03 08:00:00'),
('HD00002', 'DV04', 'P102', 5, '2023-12-03 09:00:00'),
('HD00003', 'DV02', 'P104', 1, '2023-12-04 13:00:00'),
('HD00003', 'DV05', 'P104', 1, '2023-12-04 05:00:00')
GO

-- Sample data for TAIKHOAN table
INSERT INTO TAIKHOAN(MANV, TENTK, MATKHAU)
VALUES
('NV01', '', '')
GO

INSERT INTO DOANHTHU (THANG, NAM, TIENPHONG,TIENDICHVU, TIENLUONG) VALUES
(N'Tháng 1',N'Năm 2021', 120000000, 43000000,70000000)
GO