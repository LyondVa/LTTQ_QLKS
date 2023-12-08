CREATE DATABASE QLKS
USE QLKS

CREATE TABLE NHANVIEN(
	MANV NVARCHAR(4) NOT NULL PRIMARY KEY,
	NHOTEN NVARCHAR(50) NOT NULL,
	NSDT NVARCHAR(10) NOT NULL,
	NGIOITINH NVARCHAR(4) NOT NULL,
	NEMAIL NVARCHAR(50) NOT NULL,
	POSITION TINYINT NOT NULL,
	CHUCVU NVARCHAR(50) NOT NULL,
	LUONG MONEY NOT NULL,
	NCCCD NVARCHAR(10), /*NEW*/
	NDIACHI NVARCHAR(100), /*NEW*/
	NNGSINH DATETIME /*NEW*/
)

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

CREATE TABLE KHACHHANG(
	MAKH NVARCHAR(4) NOT NULL PRIMARY KEY,
	KHOTEN NVARCHAR(50) NOT NULL,
	KSDT NVARCHAR(10) NOT NULL,
	QUOCTICH NVARCHAR(50) NOT NULL,
	KGIOITINH NVARCHAR(4) NOT NULL,
	KNGSINH DATETIME NOT NULL,
	KCCCD NVARCHAR(12) NOT NULL,
	KDIACHI NVARCHAR(100) NOT NULL,
	KEMAIL NVARCHAR(50), /*NEW*/
	CHECKEDOUT BIT /*NEW*/
	/*XOA COT:
	CHECKIN
	CHECKOUT
	CHEKOUT
	ROOMID*/
)

CREATE TABLE HOADON(
	MAHD NVARCHAR(7) NOT NULL PRIMARY KEY,
	MAKH NVARCHAR(4) NOT NULL FOREIGN KEY REFERENCES KHACHHANG(MAKH),
	MANV NVARCHAR(4) NOT NULL FOREIGN KEY REFERENCES NHANVIEN(MANV),
	TONGTIEN MONEY NOT NULL,
	PHGTHUC NVARCHAR(50) NOT NULL,
	NGTHANHTOAN SMALLDATETIME NOT NULL,
	NGXUATHD SMALLDATETIME NOT NULL,
) 

CREATE TABLE PHONG(
	MAPHG NVARCHAR(4) NOT NULL PRIMARY KEY,
	MALOAIPHG NVARCHAR(4) NOT NULL FOREIGN KEY REFERENCES LOAIPHONG(MALOAIPHG),
	TRANGTHAI NVARCHAR(50) NOT NULL,
	TANG TINYINT NOT NULL,
	GHICHU TEXT
	/*XOA COT MAKS*/
)

CREATE TABLE CTPHG(
	MAPHG NVARCHAR(4) NOT NULL FOREIGN KEY REFERENCES PHONG(MAPHG),
	MAHD NVARCHAR(7) NOT NULL FOREIGN KEY REFERENCES HOADON(MAHD),
	NGNHANPHG DATETIME NOT NULL,
	NGTRPHG DATETIME NOT NULL,
	TIENDATPHG MONEY NOT NULL,
)

CREATE TABLE DICHVU(
	MADV NVARCHAR(4) NOT NULL PRIMARY KEY,
	TENDV NVARCHAR(20) NOT NULL,
	GIADV MONEY NOT NULL
)

CREATE TABLE CTDV(
	MAHD NVARCHAR(7) NOT NULL FOREIGN KEY REFERENCES HOADON(MAHD),
	MADV NVARCHAR(4) NOT NULL FOREIGN KEY REFERENCES DICHVU(MADV),
	SOLUONG INT NOT NULL,
	THOIGIANSD SMALLDATETIME NOT NULL
)

CREATE TABLE TAIKHOAN(
	MANV NVARCHAR(4) NOT NULL FOREIGN KEY REFERENCES NHANVIEN(MANV),
	TENTK NVARCHAR(250) NOT NULL,
	MATKHAU NVARCHAR(250) NOT NULL
) /*NEW*/

-- Revised sample data for NHANVIEN table
INSERT INTO NHANVIEN (MANV, NHOTEN, NSDT, NGIOITINH, NEMAIL, POSITION, CHUCVU, LUONG, NCCCD, NDIACHI, NNGSINH) VALUES
('NV01', 'Nguyen Van A', '0000000000', 'Nam', 'nva@example.com', 1, 'Quan ly', 15000000, 'ABC123456', 'XYZ Street, Fantasy City', '1980-01-01'),
('NV02', 'Tran Thi B', '1111111111', 'Nu', 'ttb@example.com', 2, 'Nhan vien', 8000000, 'DEF987654', 'ABC Avenue, Imaginary Town', '1990-02-02');

-- Revised sample data for LOAIPHONG table
INSERT INTO LOAIPHONG (MALOAIPHG, TENLOAIPHG, GIADEM, SUCCHUA, SOGIUONG) VALUES
('LP01', 'VIP', 2000000, 2, 1),
('LP02', 'STD', 1000000, 4, 2);

-- Revised sample data for KHACHHANG table
INSERT INTO KHACHHANG (MAKH, KHOTEN, KSDT, QUOCTICH, KGIOITINH, KNGSINH, KCCCD, KDIACHI, KEMAIL, CHECKEDOUT) VALUES
('KH01', 'John Smith', '2222222222', 'USA', 'Nam', '1985-03-03', 'GHI123456', 'LMN Street, Nowhere City', 'jsmith@example.com', 0),
('KH02', 'Le Thi C', '3333333333', 'Vietnam', 'Nu', '1995-04-04', 'JKL987654', 'OPQ Road, Neverland', 'ltc@example.com', 1);

-- Revised sample data for HOADON table
INSERT INTO HOADON (MAHD, MAKH, MANV, TONGTIEN, PHGTHUC, NGTHANHTOAN, NGXUATHD) VALUES
('HD00001', 'KH01', 'NV01', 3000000, 'Tien mat', '2023-12-08 10:00:00', '2023-12-08 10:05:00'),
('HD00002', 'KH02', 'NV02', 1500000, 'The tin dung', '2023-12-09 11:00:00', '2023-12-09 11:05:00');

-- Revised sample data for PHONG table
INSERT INTO PHONG (MAPHG, MALOAIPHG, TRANGTHAI, TANG, GHICHU) VALUES
('P001', 'LP01', 'Trong', 1, 'Phong moi sua chua xong'),
('P002', 'LP02', 'Dang su dung', 2, 'Phong co view dep');

-- Revised sample data for CTPHG table
INSERT INTO CTPHG (MAPHG, MAHD, NGNHANPHG, NGTRPHG, TIENDATPHG) VALUES
('P001', 'HD00001', '2023-12-07 14:00:00', '2023-12-08 12:00:00', 500000),
('P002', 'HD00002', '2023-12-09 13:00:00', '2023-12-10 11:00:00', 300000);

-- Revised sample data for DICHVU table
INSERT INTO DICHVU (MADV, TENDV, GIADV) VALUES
('DV01', 'An sang', 50000),
('DV02', 'Giat ui', 100000);

-- Revised sample data for CTDV table
INSERT INTO CTDV (MAHD, MADV, SOLUONG, THOIGIANSD) VALUES
('HD00001', 'DV01', 2, '2023-12-08 07:30:00'),
('HD00002', 'DV02', 1, '2023-12-09 09:00:00');

-- Revised sample data for TAIKHOAN table
INSERT INTO TAIKHOAN (MANV, TENTK, MATKHAU) VALUES
('NV01', '', ''),
('NV02', 'admin', 'admin');