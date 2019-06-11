create database QUANLYDAILY
USE QUANLYDAILY
create table QUAN
(
	MaQuan char(4),
	TenQuan nchar(50),
	constraint quan_ma_pk primary key(MaQuan)
)
INSERT INTO dbo.QUAN
        ( MaQuan, TenQuan )
VALUES  ( 'Q1', N'Quận 1'), ( 'Q2', N'Quận 2'), ( 'Q3', N'Quận 3'), ( 'Q4', N'Quận 4'), ( 'Q5', N'Quận 5'),
( 'Q6', N'Quận 6'), ( 'Q7', N'Quận 7'), ( 'Q8', N'Quận 8'), ( 'Q9', N'Quận 9'), ( 'Q10', N'Quận 10'), ( 'Q11', N'Quận 11'), ( 'Q12', N'Quận 12')

create table LOAIDAILY
(
	MaLoaiDaiLy char(3),
	TenLoaiDaiLy nchar(30),
	TienNo money,
	constraint loaidl_ma_pk primary key(MaLoaiDaiLy)
)
INSERT INTO dbo.LOAIDAILY
        ( MaLoaiDaiLy, TenLoaiDaiLy, TienNo )
VALUES  ( '001', N'ĐL loại 1', 50000000  ), ( '002', N'ĐL loại 2', 20000000  )
CREATE TABLE DAILY
(
	MaDaiLy char(6),	
	TenDaiLy nchar(250) not null,
	MaLoaiDaiLy char(3),
	DienThoai char(13),
	Email char(30),
	DiaChi nchar(300) not null,
	MaQuan char(4),
	NgayTiepNhan date,
	SoNo money,
	constraint dl_ma_pk primary key(MaDaiLy),
	constraint dl_loaidl_fk foreign key(MaLoaiDaiLy) references LOAIDAILY(MaLoaiDaiLy),
	constraint dl_maquan_fk foreign key(MaQuan) references QUAN(MaQuan)
)
ALTER TABLE dbo.DAILY DROP COLUMN MaNhanVien
ALTER TABLE dbo.DAILY ADD GhiChu NCHAR(250)
ALTER TABLE dbo.DAILY ADD MaNhanVien CHAR(6)
INSERT INTO dbo.DAILY
        ( MaDaiLy ,
          TenDaiLy ,
          MaLoaiDaiLy ,
          DienThoai ,
          Email ,
          DiaChi ,
          MaQuan ,
          NgayTiepNhan ,
          SoNo ,
          GhiChu ,
          MaNhanVien
        )
VALUES  ( 'DL0001' , -- MaDaiLy - char(6)
          N'Hoàng Nam' , -- TenDaiLy - nchar(50)
          '001' , -- MaLoaiDaiLy - char(3)
          '123456789' , -- DienThoai - char(13)
          'hoangnam@gmail.com' , -- Email - char(30)
          N'123 Võ Văn Ngân' , -- DiaChi - nchar(300)
          'Q1' , -- MaQuan - char(4)
          '5-14-2019' , -- NgayTiepNhan - date
          0 , -- SoNo - money
          N'' , -- GhiChu - nvarchar(250)
          'NV0002'  -- MaNhanVien - char(6)
        )

create table PHIEUTHUTIEN
(
	MaPhieuThuTien char(8),
	MaDaiLy char(6),
	NgayThuTien date,
	SoTienThu money not null,
	NoiDung nchar(1000) not null,
	GhiChu nchar(1000),
	constraint ptt_ma_pk primary key(MaPhieuThuTien),
	constraint ptt_madl_fk foreign key(MaDaiLy) references DAILY(MaDaiLy)
)
create table TAIKHOAN
(
	MaNhanVien char(6),
	TenNhanVien NVARCHAR(250) not null,
	MatKhau char(16) not null,
	LoaiTaiKhoan NVARCHAR(20),
	constraint tk_ma_pk primary key(MaNhanVien)
)

create table DOANHSO
(
	MaDaiLy char(6),
	Thang date,
	SoPhieuXuat int,
	TongGiaTri money,
	constraint ds_madl_fk foreign key(MaDaiLy) references DAILY(MaDaiLy),
	constraint ds_pk primary key(MaDaiLy, Thang)
)
create table PHIEUXUATHANG
(
	MaPhieuXuatHang char(6),
	MaDaiLy char(6),
	TraTruoc DECIMAL,
	NgayLap date,
	MaNhanVien CHAR(6),
	TienConLai DECIMAL,
	constraint pxh_madl_fk foreign key(MaDaiLy) references dbo.DAILY(MaDaiLy),
	constraint pxh_manv_fk foreign KEY(MaNhanVien) references dbo.TAIKHOAN(MaNhanVien),
	constraint pxh_mapxh_pk primary key(MaPhieuXuatHang)
)
DROP TABLE dbo.PHIEUXUATHANG
--alter table PHIEUXUATHANG add constraint pxh
create table MATHANG
(
	MaMatHang char(6),
	TenMatHang nchar(250),
	SoLuongCon int,
	DonViTinh nvarchar(20),
	DonGia DECIMAL,
	constraint mh_pk primary key(MaMatHang)
)

ALTER TABLE dbo.MATHANG ADD DonViTinh INT
DROP TABLE dbo.MATHANG

SELECT MaMatHang FROM dbo.MATHANG


create table CHITIETXUAT
(
	MaPhieuXuatHang char(6),
	MaMatHang char(6),
	SoLuong int,
	ThanhTien DECIMAL,
	constraint ctt_mapxh_fk foreign key(MaPhieuXuatHang) references PHIEUXUATHANG(MaPhieuXuatHang),
	constraint ctt_mamh_fk foreign key(MaMatHang) references MATHANG(MaMatHang),
	constraint ctt_mctx_pk primary key(MaPhieuXuatHang, MaMatHang)
)
INSERT INTO CHITIETXUAT (MaPhieuXuatHang, MaMatHang, SoLuong, ThanhTien) VALUES (, -- MaPhieuXuatHang - 
, -- MaMatHang - 
, -- SoLuong - 
 -- ThanhTien - 
)
SELECT CHITIETXUAT.MaMatHang, MATHANG.TenMatHang, MATHANG.DonViTinh, CHITIETXUAT.SoLuong,MATHANG.DonGia, ThanhTien 
FROM dbo.CHITIETXUAT, dbo.MATHANG, dbo.PHIEUXUATHANG
WHERE PHIEUXUATHANG.MaPhieuXuatHang = CHITIETXUAT.MaPhieuXuatHang AND CHITIETXUAT.MaMatHang = MATHANG.MaMatHang

DROP TABLE dbo.CHITIETXUAT

create table CONGNO
(
	MaDaiLy char(6),
	Thang date,
	NoDau money,
	PhatSinh money,
	NoCuoi money,
	constraint cn_madl_fk foreign key(MaDaiLy) references DAILY(MaDaiLy),
	constraint cn_pk primary key(MaDaiLy, Thang)
)
create table THAMSO
(
	SoDaiLyToiDa tinyint,
	SoLoaiDaiLy tinyint,
	SoMatHang tinyint,
)

SELECT MaNhanVien, MatKhau FROM dbo.TAIKHOAN

DELETE FROM dbo.DAILY WHERE MaDaiLy = ''
SELECT MaLoaiDaiLy FROM dbo.LOAIDAILY WHERE TenLoaiDaiLy = N'ĐL loại 1'
SELECT MaPhieuXuatHang, NgayLap FROM dbo.PHIEUXUATHANG
 
