create database QUANLYDAILY
create table QUAN
(
	MaQuan varchar(4),
	TenQuan nvarchar(50),
	constraint quan_ma_pk primary key(MaQuan)
)
create table LOAIDAILY
(
	MaLoaiDaiLy varchar(3),
	TenLoaiDaiLy nvarchar(30),
	TienNo money,
	constraint loaidl_ma_pk primary key(MaLoaiDaiLy)
)
CREATE TABLE DAILY
(
	MaDaiLy varchar(6),	
	TenDaiLy nvarchar(50) not null,
	MaLoaiDaiLy varchar(3),
	DienThoai varchar(13),
	Email varchar(30),
	DiaChi nvarchar(300) not null,
	MaQuan varchar(4),
	NgayTiepNhan date,
	SoNo money,
	constraint dl_ma_pk primary key(MaDaiLy),
	constraint dl_loaidl_fk foreign key(MaLoaiDaiLy) references LOAIDAILY(MaLoaiDaiLy),
	constraint dl_maquan_fk foreign key(MaQuan) references QUAN(MaQuan)
)
create table PHIEUTHUTIEN
(
	MaPhieuThuTien varchar(8),
	MaDaiLy varchar(6),
	NgayThuTien date,
	SoTienThu money not null,
	NoiDung nvarchar(1000) not null,
	GhiChu nvarchar(1000),
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
	MaDaiLy varchar(6),
	Thang date,
	SoPhieuXuat int,
	TongGiaTri money,
	constraint ds_madl_fk foreign key(MaDaiLy) references DAILY(MaDaiLy),
	constraint ds_pk primary key(MaDaiLy, Thang)
)
create table PHIEUXUATHANG
(
	MaPhieuXuatHang varchar(6),
	MaDaiLy varchar(6),
	TongGiaTri money,
	TraTruoc money,
	NgayLap date,
	constraint pxh_madl_fk foreign key(MaDaiLy) references DAILY(MaDaiLy),
	constraint pxh_mapxh_pk primary key(MaPhieuXuatHang)
)
--update 8/6/2019: bỏ 3 câu bên dưới
/*alter table PHIEUXUATHANG add TraTruoc money
alter table PHIEUXUATHANG add MaNhanVien money
alter table PHIEUXUATHANG add constraint pxh*/
create table MATHANG
(
	MaMatHang varchar(6),
	TenMatHang nvarchar(250),
	SoLuongCon int,
	Loai varchar(20),
	DonGia money,
	constraint mh_pk primary key(MaMatHang)
)
create table CHITIETXUAT
(
	MaChiTietXuat varchar(10),
	MaPhieuXuatHang varchar(6),
	MaMatHang varchar(6),
	SoLuong int,
	ThanhTien money,
	constraint ctt_mapxh_fk foreign key(MaPhieuXuatHang) references PHIEUXUATHANG(MaPhieuXuatHang),
	constraint ctt_mamh_fk foreign key(MaMatHang) references MATHANG(MaMatHang),
	constraint ctt_mctx_pk primary key(MaChiTietXuat)
)
create table CONGNO
(
	MaDaiLy varchar(6),
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
--update: 8/6/2019
create procedure dbo.BAOCAODOANHSOTHANG
	@Thang int
As
	select A.MaDaiLy, A.TenDaiLy, count (MaPhieuXuatHang) as SoLuongPhieu, Sum (TongGiaTri) as TongGiaTri, count(*) * 100.0 / sum(count(*)) over() AS TiLe
	From DAILY AS A, PHIEUXUATHANG AS B
	where A.MaDaiLy = B.MaDaiLy and month(NgayLap) = @Thang
	Group by A.MaDaiLy, TenDaiLy