create database QUANLYDAILY
USE QUANLYDAILY
create table QUAN
(
	MaQuan char(4),
	TenQuan nchar(50),
	constraint quan_ma_pk primary key(MaQuan)
)

create table LOAIDAILY
(
	MaLoaiDaiLy char(3),
	TenLoaiDaiLy nchar(30),
	TienNo money,
	constraint loaidl_ma_pk primary key(MaLoaiDaiLy)
)
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

DROP TABLE dbo.TAIKHOAN
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
	TongGiaTri money,
	TraTruoc money,
	NgayLap date,
	constraint pxh_madl_fk foreign key(MaDaiLy) references DAILY(MaDaiLy),
	constraint pxh_mapxh_pk primary key(MaPhieuXuatHang)
)
alter table PHIEUXUATHANG add TraTruoc money
alter table PHIEUXUATHANG add MaNhanVien money
--alter table PHIEUXUATHANG add constraint pxh
create table MATHANG
(
	MaMatHang char(6),
	TenMatHang nchar(250),
	SoLuongCon int,
	Loai varchar(20),
	DonGia money,
	constraint mh_pk primary key(MaMatHang)
)
create table CHITIETXUAT
(
	MaChiTietXuat char(10),
	MaPhieuXuatHang char(6),
	MaMatHang char(6),
	SoLuong int,
	ThanhTien money,
	constraint ctt_mapxh_fk foreign key(MaPhieuXuatHang) references PHIEUXUATHANG(MaPhieuXuatHang),
	constraint ctt_mamh_fk foreign key(MaMatHang) references MATHANG(MaMatHang),
	constraint ctt_mctx_pk primary key(MaChiTietXuat)
)
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
SELECT * FROM dbo.LOAIDAILY 
UPDATE dbo.TAIKHOAN SET 
