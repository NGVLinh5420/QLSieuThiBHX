/*
* Ver1.0
* KHÔNG CÓ RÀNG BUỘC DỮ LIỆU (DEFAULT, CHECK,...)
*/

CREATE DATABASE QLSieuThiBHX
GO

USE QLSieuThiBHX
GO

/*DATETIME*/
SET DATEFORMAT DMY

/*TABLE*/
CREATE TABLE NHANVIEN
(
	MaNV VARCHAR(10) NOT NULL PRIMARY KEY,
	HoNV VARCHAR(50) NOT NULL,
	TenNV VARCHAR(50) NOT NULL,
	GioiTinh VARCHAR(3),
	NgaySinh DATE,
	DiaChi VARCHAR(50),
	DienThoai VARCHAR(10),
)
GO
 
CREATE TABLE KHACHHANG
(
	MaKH VARCHAR(10) NOT NULL PRIMARY KEY,
	HoTenKH VARCHAR(50) NOT NULL,
	DiaChi VARCHAR(50),
	DienThoai VARCHAR(10),
)
GO
 
CREATE TABLE HOADON
(
	MaHD VARCHAR(10) NOT NULL PRIMARY KEY,
	MaKH VARCHAR(10) NOT NULL,
	MaNV VARCHAR(10) NOT NULL,
	NgayLapHD DATE,
)
GO
 
 CREATE TABLE SANPHAM
(
	MaSP VARCHAR(10) NOT NULL PRIMARY KEY,
	TenSP VARCHAR(50) NOT NULL,
	DonViTinh VARCHAR(10),
	DonGia FLOAT CHECK (DonGia > 0)
)
GO
 
 CREATE TABLE CHITIETHD
(
	MaHD VARCHAR(10) NOT NULL,
	MaSP VARCHAR(10) NOT NULL,
	SoLuong INT,
	CONSTRAINT PK_CHITIETHD PRIMARY KEY (MaHD, MaSP),
	CHECK (SoLuong > 0)
)
GO

/*CONSTRAINT*/
ALTER TABLE HOADON
ADD CONSTRAINT FK_HD_KH_MaKH FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH)
GO

ALTER TABLE HOADON
ADD CONSTRAINT FK_HD_NV_MaNV FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV)
GO

ALTER TABLE CHITIETHD
ADD CONSTRAINT FK_CT_HD_MaHD FOREIGN KEY (MaHD) REFERENCES HOADON(MaHD)
GO

ALTER TABLE CHITIETHD
ADD CONSTRAINT FK_CT_SP_MaSP FOREIGN KEY (MaSP) REFERENCES SANPHAM(MaSP)
GO

/*CREATE STORES CRUD*/
--ADD (C)
CREATE PROC SP_ADD_NHANVIEN @MaNV VARCHAR(10), @HoNV VARCHAR(50), @TenNV VARCHAR(50), @GioiTinh VARCHAR(3), @NgaySinh DATE, @DiaChi VARCHAR(50), @DienThoai VARCHAR(10)
AS
INSERT INTO NHANVIEN(MaNV, HoNV, TenNV, GioiTinh, NgaySinh, DiaChi, DienThoai)
VALUES (@MaNV,@HoNV,@TenNV,@GioiTinh,@NgaySinh,@DiaChi,@DienThoai)
GO

CREATE PROC SP_ADD_KHACHHANG @MaKH VARCHAR(10), @HoTenKH VARCHAR(50), @DiaChi VARCHAR(50), @DienThoai VARCHAR(10)
AS
INSERT INTO KHACHHANG(MaKH, HoTenKH, DiaChi, DienThoai)
VALUES (@MaKH, @HoTenKH, @DiaChi, @DienThoai)
GO

CREATE PROC SP_ADD_HOADON @MaHD VARCHAR(10), @MaKH VARCHAR(10), @MaNV VARCHAR(10), @NgayLapHD DATE
AS
INSERT INTO HOADON(MaHD, MaKH, MaNV, NgayLapHD)
VALUES (@MaHD, @MaKH, @MaNV, @NgayLapHD)
GO

CREATE PROC SP_ADD_SANPHAM @MaSP VARCHAR(10), @TenSP VARCHAR(50), @DonViTinh VARCHAR(10), @DonGia FLOAT
AS
INSERT INTO SANPHAM(MaSP, TenSP, DonViTinh, DonGia)
VALUES (@MaSP, @TenSP, @DonViTinh, @DonGia)
GO

CREATE PROC SP_ADD_CHITIETHD @MaHD VARCHAR(10), @MaSP VARCHAR(10), @SoLuong INT
AS
INSERT INTO CHITIETHD(MaHD, MaSP, SoLuong)
VALUES (@MaHD, @MaSP, @SoLuong)
GO

--READ (R)
CREATE PROC SP_READ_NHANVIEN
AS
SELECT * FROM NHANVIEN
GO

CREATE PROC SP_READ_KHACHHANG
AS
SELECT * FROM KHACHHANG
GO

CREATE PROC SP_READ_HOADON
AS
SELECT * FROM HOADON
GO

CREATE PROC SP_READ_SANPHAM
AS
SELECT * FROM SANPHAM
GO

CREATE PROC SP_READ_CHITIETHD
AS
SELECT * FROM CHITIETHD
GO

CREATE PROC SP_READ_SELECT_HD_GIA
AS
BEGIN
SELECT CT.MaHD, NgayLapHD, SUM(CT.SoLuong * SP.DonGia) AS "TongGiaTien"
FROM CHITIETHD CT, HOADON HD, SANPHAM SP
WHERE CT.MaHD=HD.MaHD AND CT.MaSP=SP.MaSP
GROUP BY CT.MaHD, NgayLapHD
END
GO

CREATE PROC SP_READ_SELECT_SP_SOLUONG
AS
BEGIN
SELECT SP.MaSP, SP.TenSP, SUM(CT.SoLuong) AS "TongSoLuong"
FROM CHITIETHD CT, SANPHAM SP
WHERE CT.MaSP=SP.MaSP
GROUP BY SP.MaSP, SP.TenSP
END
GO

--UPDATE (U)
CREATE PROC SP_UPDATE_NHANVIEN @MaNV VARCHAR(10), @HoNV VARCHAR(50), @TenNV VARCHAR(50), @GioiTinh VARCHAR(3), @NgaySinh DATE, @DiaChi VARCHAR(50), @DienThoai VARCHAR(10)
AS
BEGIN
UPDATE NHANVIEN
SET HoNV=@HoNV, TenNV=@TenNV, GioiTinh=@GioiTinh, NgaySinh=@NgaySinh, DiaChi=@DiaChi, DienThoai=@DienThoai
WHERE MaNV=@MaNV
END
GO

CREATE PROC SP_UPDATE_KHACHHANG @MaKH VARCHAR(10), @HoTenKH VARCHAR(50), @DiaChi VARCHAR(50), @DienThoai VARCHAR(10)
AS
BEGIN
UPDATE KHACHHANG
SET HoTenKH=@HoTenKH, DiaChi=@DiaChi, DienThoai=@DienThoai
WHERE MaKH=@MaKH
END
GO

CREATE PROC SP_UPDATE_HOADON @MaHD VARCHAR(10), @MaKH VARCHAR(10), @MaNV VARCHAR(10), @NgayLapHD DATE
AS
BEGIN
UPDATE HOADON
SET MaKH = @MaKH, MaNV=@MaNV, NgayLapHD=@NgayLapHD
WHERE MaHD=@MaHD
END
GO

CREATE PROC SP_UPDATE_SANPHAM @MaSP VARCHAR(10), @TenSP VARCHAR(50), @DonViTinh VARCHAR(10), @DonGia FLOAT
AS
BEGIN
UPDATE SANPHAM
SET TenSP=@TenSP, DonViTinh=@DonViTinh, DonGia=@DonGia
WHERE MaSP=@MaSP
END
GO

CREATE PROC SP_UPDATE_CHITIETHD @MaHD VARCHAR(10), @SoLuong INT
AS
BEGIN
UPDATE CHITIETHD
SET SoLuong=@SoLuong
WHERE MaHD=@MaHD
END
GO

--DELETE (D)
CREATE PROC SP_DELETE_NHANVIEN @MaNV VARCHAR(10)
AS
BEGIN
DELETE FROM NHANVIEN WHERE MaNV=@MaNV
END
GO

CREATE PROC SP_DELETE_KHACHHANG @MaKH VARCHAR(10)
AS
BEGIN
DELETE FROM KHACHHANG WHERE MaKH=@MaKH
END
GO

CREATE PROC SP_DELETE_HOADON @MaHD VARCHAR(10)
AS
BEGIN
DELETE FROM HOADON WHERE MaHD=@MaHD
END
GO

CREATE PROC SP_DELETE_SANPHAM @MaSP VARCHAR(10)
AS
BEGIN
DELETE FROM SANPHAM WHERE MaSP=@MaSP
END
GO

CREATE PROC SP_DELETE_CHITIETHD @MaHD VARCHAR(10)
AS
BEGIN
DELETE FROM CHITIETHD WHERE MaHD=@MaHD
END
GO

--SEARCH
CREATE PROC SP_SEARCH_KHACHHANG @DienThoai VARCHAR(10)
AS
BEGIN
	SELECT * FROM KHACHHANG
	WHERE KHACHHANG.DienThoai LIKE '%'+@DienThoai+'%'
END
GO

/* ĐƯỢC SỬ DỤNG TRONG FILE CODE CỦA C# */

--SELECT (NV.HoNV + ' ' + NV.TenNV) AS "HoTenNV"
--FROM NHANVIEN NV

--SELECT KH.HoTenKH
--FROM KHACHHANG KH

--SELECT (NV.HoNV + ' ' + NV.TenNV) AS "HoTenNV"
--FROM NHANVIEN NV, HOADON HD
--WHERE HD.MaHD = 'HD2' AND NV.MaNV = HD.MaNV

--SELECT KH.HoTenKH
--FROM KHACHHANG KH, HOADON HD
--WHERE HD.MaHD = 'HD2' AND KH.MaKH = HD.MaKH


/*USE PROC*/
--ADD
EXEC SP_ADD_KHACHHANG 'KH0','KHACH HANG LA', '', ''
EXEC SP_ADD_KHACHHANG 'KH1','KHACH MOT', '1 THU DUC', '0111100001'
EXEC SP_ADD_KHACHHANG 'KH2','KHACH HAI', '2 THU DUC', '0111100002'
EXEC SP_ADD_KHACHHANG 'KH3','KHACH BA', '3 THU DUC', '0111100003'
EXEC SP_ADD_KHACHHANG 'KH4','KHACH BON', '4 THU DUC', '0111100004'
EXEC SP_ADD_KHACHHANG 'KH5','KHACH NAM', '5 THU DUC', '0111100005'

EXEC SP_ADD_NHANVIEN 'NV1', 'NGUYEN VAN', 'MOT', 'NAM', '01/01/2001', '1 THU THIEM', '0222200001'
EXEC SP_ADD_NHANVIEN 'NV2', 'PHAN THI', 'HAI', 'NU', '01/01/2002', '2 THU THIEM', '0222200002'
EXEC SP_ADD_NHANVIEN 'NV3', 'NGUYEN VAN', 'BA', 'NAM', '01/01/2003', '3 THU THIEM', '0222200003'
EXEC SP_ADD_NHANVIEN 'NV4', 'PHAN THI', 'BON', 'NU', '01/01/2004', '4 THU THIEM', '0222200004'
EXEC SP_ADD_NHANVIEN 'NV5', 'NGUYEN VAN', 'NAM', 'NAM', '01/01/2005', '5 THU THIEM', '0222200005'

EXEC SP_ADD_HOADON 'HD1', 'KH1', 'NV1', '01/01/2023'
EXEC SP_ADD_HOADON 'HD2', 'KH2', 'NV2', '02/01/2023'
EXEC SP_ADD_HOADON 'HD3', 'KH3', 'NV3', '03/01/2023'
EXEC SP_ADD_HOADON 'HD4', 'KH4', 'NV4', '04/01/2023'
EXEC SP_ADD_HOADON 'HD5', 'KH5', 'NV5', '05/01/2023'
EXEC SP_ADD_HOADON 'HD6', 'KH1', 'NV1', '01/01/2023'

EXEC SP_ADD_SANPHAM	'SP1', 'AO', 'CAI', 1000
EXEC SP_ADD_SANPHAM	'SP2', 'BIA', 'LON', 2500
EXEC SP_ADD_SANPHAM	'SP3', 'CHOI', 'CAY', 3000
EXEC SP_ADD_SANPHAM	'SP4', 'DU DU', 'TRAI', 4500
EXEC SP_ADD_SANPHAM	'SP5', 'EMP', 'LO', 5000

EXEC SP_ADD_CHITIETHD 'HD1', 'SP1', '11'
EXEC SP_ADD_CHITIETHD 'HD1', 'SP4', '14'
EXEC SP_ADD_CHITIETHD 'HD2', 'SP1', '21'
EXEC SP_ADD_CHITIETHD 'HD2', 'SP2', '22'
EXEC SP_ADD_CHITIETHD 'HD2', 'SP3', '23'
EXEC SP_ADD_CHITIETHD 'HD2', 'SP4', '24'
EXEC SP_ADD_CHITIETHD 'HD3', 'SP5', '35'
EXEC SP_ADD_CHITIETHD 'HD4', 'SP5', '45'
EXEC SP_ADD_CHITIETHD 'HD4', 'SP2', '42'
EXEC SP_ADD_CHITIETHD 'HD4', 'SP3', '43'
EXEC SP_ADD_CHITIETHD 'HD5', 'SP3', '53'
EXEC SP_ADD_CHITIETHD 'HD6', 'SP4', '64'


