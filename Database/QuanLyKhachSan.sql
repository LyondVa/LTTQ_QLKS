USE QLKS

CREATE TABLE KHACHSAN(
	MAKS CHAR(4) NOT NULL PRIMARY KEY,
	TENKS VARCHAR(20),
	DIACHI VARCHAR(100),
	HOTLINE VARCHAR(15),
	EMAIL VARCHAR(50)
)

CREATE TABLE NHANVIEN(
	MANV CHAR(4) NOT NULL PRIMARY KEY,
	MAKS CHAR(4) FOREIGN KEY REFERENCES KHACHSAN(MAKS),
	HOTEN VARCHAR(50),
	DIACHI VARCHAR(100),
	SDT CHAR(10),
	EMAIL VARCHAR(50),
	CHUCVU VARCHAR(50),
	LUONG MONEY
)

CREATE TABLE LOAIPHONG(
	MALOAIPHG CHAR(4) NOT NULL PRIMARY KEY,
	TENLOAIPHG VARCHAR(10),
	GIADEM MONEY,
	MAXTRGTHANH TINYINT,
	MAXTHIEUNHI TINYINT,
	MAXSOSINH TINYINT
)

CREATE TABLE KHACHHANG(
	CCCD CHAR(12) NOT NULL PRIMARY KEY,
	HOTEN VARCHAR(50),
	NGSINH DATETIME,
	GIOITINH VARCHAR(4),
	SDT CHAR(10),
	EMAIL VARCHAR(50),
	DIACHI VARCHAR(100)
)

CREATE TABLE HOADON(
	MAHD CHAR(7) NOT NULL PRIMARY KEY,
	MAKH CHAR(12) FOREIGN KEY REFERENCES KHACHHANG(CCCD),
	TONGTIEN MONEY,
	PHGTHUC VARCHAR(10),
	NGTHANHTOAN SMALLDATETIME,
	NGXUATHD SMALLDATETIME,
)

CREATE TABLE PHONG(
	MAPHG CHAR(4) NOT NULL PRIMARY KEY,
	MALOAIPHG CHAR(4) FOREIGN KEY REFERENCES LOAIPHONG(MALOAIPHG),
	MAKS CHAR(4) FOREIGN KEY REFERENCES KHACHSAN(MAKS),
	TRANGTHAI VARCHAR(10),
)

CREATE TABLE CTPHG(
	MAPHG CHAR(4) FOREIGN KEY REFERENCES PHONG(MAPHG),
	MAHD CHAR(7) FOREIGN KEY REFERENCES HOADON(MAHD),
	NGNHANPHG DATETIME,
	NGTRPHG DATETIME,
	TIENDATPHG MONEY
)

CREATE TABLE DICHVU(
	MADV CHAR(4) NOT NULL PRIMARY KEY,
	TENDV VARCHAR(20),
	GIADV MONEY
)

CREATE TABLE CTDV(
	MAHD CHAR(7) FOREIGN KEY REFERENCES HOADON(MAHD),
	MADV CHAR(4) FOREIGN KEY REFERENCES DICHVU(MADV),
	SOLUONG INT,
	THOIGIANSD SMALLDATETIME
)
