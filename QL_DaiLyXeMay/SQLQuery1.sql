create table BAOCAODATAO
(
	MaBaoCao varchar(6),
	NgayTao DateTime,
	MaNhanVien varchar(6),
	constraint bcdt_mabc_pk primary key(MaBaoCao)
)
create table CHITIETBAOCAO
(
	MaBaoCao varchar(6),
	MaDaiLy varchar(6),
	Stt int,
	SoPhieuXuat int,
	TongGiaTri money,
	TiLe float,
	constraint ctbc_mabc_fk foreign key(MaBaoCao) references BAOCAODATAO(MaBaoCao),
	constraint ctbc_madl_fk foreign key(MaDaiLy) references DAILY(MaDaiLy),
	constraint ctbc_mabc_madl_pk primary key(MaBaoCao, MaDaiLy)
)