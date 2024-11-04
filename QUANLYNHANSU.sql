Create database Quanlynhansu
go 
use Quanlynhansu
go







create table MucLuongToiThieu(
MaMLTT int identity primary key,
NgayAD date not null,
MLTTVung int not null,
MLTTC float not null
)


create table TrinhDoVanHoa (
MaTDVH int identity primary key,
TenTDVH nvarchar(150) unique not null
)

create table TrinhDoChuyenMon(
MaTDCM int identity primary key,
TenTDCM nvarchar(150) unique not null
)

create table ChuyenMon(
MaCM int identity primary key,
TenCM nvarchar(150) unique not null,
MaTDCM int foreign key references TrinhDoChuyenMon(MaTDCM)
)

create table TrinhDoLyLuanChinhTri (
MaTDLLCT int identity primary key,
TenTDLLCT nvarchar(150) unique not null
)


create table TrinhDoNgoaiNgu(
MaTDNN int identity primary key,
TenTDNN nvarchar(150) unique not null
)

create table NgoaiNgu (
MaNN int identity primary key,
TenNN nvarchar(100) unique not null,
MaTDNN int foreign key references TrinhDoNgoaiNgu(MaTDNN)
)


create table TrangThaiLamViec(
MaTTLV int identity primary key,
TenTTLV nvarchar(100)  not null,
KyHieu varchar(10)
)






create table XepLoai (
MaXL int identity primary key,
TenXL nvarchar(100) unique not null
)




create table ThangLuong (
MaTL int identity primary key,
TenTL nvarchar(150) unique not null,
DienGiai nvarchar(100) 
)


create table HeSoThangBacLuong(
MaBL int identity primary key,
MATL int foreign key references ThangLuong(MaTL),
NgayQD date not null,
Bac1 float,
Bac2 float,
Bac3 float,
Bac4 float,
Bac5 float,
Bac6 float,
Bac7 float,
Bac8 float,
Bac9 float,
Bac10 float,
Bac11 float,
Bac12 float
)

create table TinhThanh (
MaTT int identity primary key,
TenTT nvarchar(150) unique not null
)



create table PhongBan(
MaPB int identity primary key,
TenPB nvarchar(150) unique not null,
CapDo int not null,
DoTuoiVeHuuNam int,
DoTuoiVeHuuNu int
)


create table ChucVu(
MaChucVu int identity primary key,
TenChucVu nvarchar(150) unique not null,
CapDo int not null,
HeSoChucDanh float not null
)


create table DanToc(
MaDT int identity primary key,
TenDT nvarchar(50) unique not null
)


create table TonGiao(
MaTG int identity primary key,
TenTG nvarchar(50) unique not null
)

create table QuanHeThanNhan(
MaQHTN int identity primary key,
TenQHTN nvarchar(50) not null
)

create table DinhMucXangXe(
MaDMXX int identity primary key,
TenPTien nvarchar(150),
DMXX float not null

)

create table ChamCongTL(
MaCCTL int identity primary key,
TenCCTL nvarchar(150) not null,
Nam int not null,
Thang int not null,
Khoa bit,
NgayTinhCong date,
NgayCongTrongThang float,
TrangThai bit

)




create table NhanVien(
MaNV int  primary key,
TenNV nvarchar(150) not null,
BiDanh nvarchar(50) not null,
GioiTinh nvarchar(5) not null,
NgaySinh date not null,
QueQuan nvarchar(150) not null,
NoiSinh nvarchar(100) not null,
NoiOHienTai nvarchar(150) not null,
SoCCCD varchar(15) not null,
NgayCap date not null,
NoiCap nvarchar(100) not null,
Email nvarchar(70) not null,
SoDienThoai nvarchar(100) not null,
Anh image,
NgayVaoDoan date not null,
NoiVaoDoan nvarchar(150) not null,
NgayVaoDang date not null,
NoiVaoDang nvarchar(150) not null,
NgayVaoLam date not null,
NgayRoiCoQuan date,
LyDo nvarchar(150),
HeSoLuong float,
HeSoPhuCap float,
HeSoTNVK float,
SoSocBH int not null,
NgayCapSo date not null,
NoiCapSo nvarchar(150) not null,
SoThe varchar(30) not null,
SoTaiKhoan varchar(20) not null,
NganHang nvarchar(100) not null,
TinhTrangHonNhan bit not null,
TinhTrangSuckhoe nvarchar(50) not null,
ChieuCao float not null,
CanNang float not null,
NhomMau nvarchar(50) not null,
NgayNhapNgu date,
NgayXuatNgu date,
QuanHamCaoNhat nvarchar(50),
ThoiGianNangBacHSL int,
KhongChoPhepNangLuong bit,
RoiCoQuan bit,
NghiHuu bit,
LuongCoSo float,
MaDMXX int foreign key references DinhMucXangXe(MaDMXX),
MaTG int foreign key references TonGiao(MaTG),
MaChucVu int foreign key references ChucVu(MaChucVu),
MaXL int foreign key references XepLoai(MaXL),
MaTT int foreign key references TinhThanh(MaTT),
MaTDVH int foreign key references TrinhDoVanHoa(MaTDVH),
MaDT int foreign key references DanToc(MaDT),
MaCM int foreign key references ChuyenMon(MaCM),
MaNN int foreign key references NgoaiNgu(MaNN),
MaTDLLCT int foreign key references TrinhDoLyLuanChinhTri(MaTDLLCT),
MaTTLV int foreign key references TrangThaiLamViec(MaTTLV)
)




create table NguoiDung (
MaND int identity primary key,
TenDangNhap nvarchar(100) unique not null,
MatKhau nvarchar(100) not null,
MaChucVu int foreign key references ChucVu(MaChucVu),
Quyen nvarchar(100),
MaNV int foreign key references NhanVien(MaNV)
)

create table ChucNangPhanMem (
MaCN int identity primary key,
TenCN nvarchar(100) unique not null,
DienGiai nvarchar(100),
MaND int foreign key references Nguoidung(MaND)
)

create table ChungChi(
MaCC int identity primary key,
TenCC nvarchar(100) unique not null,
MaNV int foreign key references NhanVien(MaNV),
NgayCap date not null,
NgayHetHan date not null,
NoiCap nvarchar(200) not null
)



create table ThanNhan(
MaTN int identity primary key,
HoVaTen nvarchar(50) not null,
NgaySinh date not null,
NgheNghiep nvarchar(150) not null,
NoiO nvarchar(150) not null,
MaQHTN int foreign key references QuanHeThanNhan(MaQHTN),
MaNV int foreign key references NhanVien(MaNV),
GhiChu nvarchar(150)
)



create table QuaTrinhCongTac(
MaQTCT int identity primary key,
MaNV int foreign key references NhanVien(MaNV),
MaPB int foreign key references PhongBan(MaPB),
MaChucVu int foreign key references ChucVu(MaChucVu),
NgayBatDau date not null,
NgayKetThuc date not null,
Ngay date
)


create table DienBienTrangThaiLamViec(
MaDBTTLV int identity primary key,
MaNV int foreign key references NhanVien(MaNV),
MaPB int foreign key references PhongBan(MaPB),
MaCV int foreign key references ChucVu(MaChucVu),
MaTTLV int foreign key references TrangThaiLamViec(MaTTLV),
TrangThai nvarchar(100) not null,
TuNgay date not null,
DenNgay date not null,
SoQD nvarchar(50) not null,
NgayQD date not null,
TroCapThoiViec int not null,
GhiChu nvarchar(150)
)



create table LoaiHopDong(
MaLoaiHD int identity primary key,
TenLoaiHD nvarchar(150) not null,
GhiChu nvarchar(150)
)




create table HopDong(
MaHD int identity primary key,
MaLoaiHD int foreign key references LoaiHopDong(MaLoaiHD),
MaNV int foreign key references NhanVien(MaNV),
NgayKy date not null,
NgayHetHan date not null,
ThoiHan int not null,
NguoiKy nvarchar(100) not null,
MaBL int foreign key references HeSoThangBacLuong(MaBL),
MaTL int foreign key references ThangLuong(MaTL),
MaChucVu int foreign key references ChucVu(MaChucVu),
NoiCap nvarchar(200) not null,
GhiChu nvarchar(150)
)




create table GiaHanHopDong(
MaGHHD int identity primary key,
NgayGiaHan date not null,
NgayHetHanCu date not null,
NgayHetHanMoi date not null,
MaHD int foreign key references HopDong(MaHD),
MaNV int foreign key references NhanVien(MaNV),
GhiChu nvarchar(150)
)

create table DieuChuyenCongTac(
MaCCT int identity primary key,
NgayChuyen date not null,
SoQD nvarchar(10) not null,
MaPB int foreign key references PhongBan(MaPB),
MaChucVu int foreign key references ChucVu(MaChucVu),
MaHD int foreign key references HopDong(MaHD),
MaNV int foreign key references NhanVien(MaNV),
MaBL int foreign key references HeSoThangBacLuong(MaBL),
GhiChu nvarchar(150)
)


create table KhenThuongKyLuat(
MaHD int identity primary key,
SoQD int not null,
NgayQD date not null,
TenKTKL nvarchar(200) not null,
LyDo nvarchar(100) not null,
HinhThuc nvarchar(200) not null,
DonviKTKL nvarchar(150),
MaNV int foreign key references NhanVien(MaNV)
)



create table XepLoaiCanBo(
MaXLCB int identity primary key,
MaNV int foreign key references NhanVien(MaNV),
XepLoai varchar(100) not null,
DanhHieu nvarchar(100) not null,
MaPB int foreign key references PhongBan(MaPB),
GhiChu nvarchar(150)
)


create table QuaTrinhLuong(
MaQTL int identity primary key,
NgayQD date not null,
NgayHuong date not null,
NgayNangCapLuong date not null,
MaBL int foreign key references HeSoThangBacLuong(MaBL),
HSL float,
HSPC float,
MaMLTT int foreign key references MucLuongToiThieu(MaMLTT),
MaNV int foreign key references  NhanVien(MaNV)
)


create table QuaTrinhDaoTao(
MaQTDT int identity primary key,
MaNV int foreign key references NhanVien(MaNV),
NgayBatDau date not null,
NgayHetHan date not null,
TruongDaoTao nvarchar(150) not null,
NuocDaoTao varchar(10) not null,
NganhDaoTao nvarchar(200) not null,
HinhThucDaoTao varchar(10) not null,
TrinhDoDaoTao nvarchar(100) not null,
MaPB int foreign key references PhongBan(MaPB),
MaChucVu int foreign key references ChucVu(MaChucVu),
)

create table BangLuong(
MaBangL int identity primary key,
MaCCTL int foreign key references ChamCongTL(MaCCTL),
Thang int not null,
Nam int not null,
HSL float  not null,
HSPC float not null,
MaMLTT int foreign key references MucLuongToiThieu(MaMLTT),
MucLuongTTV int not null,
MucLuongTTC float not null,
NgayCong float not null,
MucLuongCoSo float not null,
PhuCapTTCV float not null,
TienLuongBQMN float not null,
LuongThoiGian float not null,
NgayHuongCong100PT real not null,
TienAnGiuaCa float not null,
CongK3 real not null,
TienK3 float not null,
CongTgNgayThuong real,
CongTGNgayNghi real,
CongTGNgayLe real,
TienThuong float,
MaDMXX int foreign key references DinhMucXangXe(MaDMXX),
LeTet float,
GhiChuLeTet nvarchar(150),
TongLuong float not null,
TruBHYT float not null,
TruBHXH float not null,
TruBHTN float not null,
SoTienConNhan float not null,
MucThue int not null,
ThuePhaiNop float not null,
ThueCaNam float not null,
TamUng float,
TongThucNhan float not null,
MaPB int foreign key references PhongBan(MaPB),
MaChucVu int foreign key references ChucVu(MaChucVu),
MaNV int foreign key references NhanVien(MaNV),
MaND int foreign key references Nguoidung(MaND),
)


create table BangTamUng(
MaBTU int identity primary key,
NgayTU date not null,
Thang int not null,
Nam int not null,
SoTienTU float not null,
DienGiai nvarchar(150) ,
MaNV int foreign key references NhanVien(MaNV),
)




-- Table: MucLuongToiThieu
INSERT INTO MucLuongToiThieu (NgayAD, MLTTVung, MLTTC) VALUES ('2024-07-01', 1, 4960000);
INSERT INTO MucLuongToiThieu (NgayAD, MLTTVung, MLTTC) VALUES ('2024-07-01', 2, 4100000);
INSERT INTO MucLuongToiThieu (NgayAD, MLTTVung, MLTTC) VALUES ('2024-07-01', 3, 3965000);

-- Table: TrinhDoVanHoa
INSERT INTO TrinhDoVanHoa (TenTDVH) VALUES (N'Tốt nghiệp THPT 8/8');
INSERT INTO TrinhDoVanHoa (TenTDVH) VALUES (N'Tốt nghiệp THPT 10/10');
INSERT INTO TrinhDoVanHoa (TenTDVH) VALUES (N'Tốt nghiệp THPT');
INSERT INTO TrinhDoVanHoa (TenTDVH) VALUES (N'Tốt nghiệp Đại học');
INSERT INTO TrinhDoVanHoa (TenTDVH) VALUES (N'Tốt nghiệp Cao học');

-- Table: TrinhDoChuyenMon
INSERT INTO TrinhDoChuyenMon (TenTDCM) VALUES (N'Kỹ sư CNTT');
INSERT INTO TrinhDoChuyenMon (TenTDCM) VALUES (N'Bác sĩ');
INSERT INTO TrinhDoChuyenMon (TenTDCM) VALUES (N'Luật sư');

-- Table: ChuyenMon
INSERT INTO ChuyenMon (TenCM, MaTDCM) VALUES (N'Lập trình viên', 1);
INSERT INTO ChuyenMon (TenCM, MaTDCM) VALUES (N'Bác sĩ đa khoa', 2);
INSERT INTO ChuyenMon (TenCM, MaTDCM) VALUES (N'Luật dân sự', 3);

-- Table: TrinhDoLyLuanChinhTri
INSERT INTO TrinhDoLyLuanChinhTri (TenTDLLCT) VALUES (N'Cơ bản');
INSERT INTO TrinhDoLyLuanChinhTri (TenTDLLCT) VALUES (N'Trung cấp');
INSERT INTO TrinhDoLyLuanChinhTri (TenTDLLCT) VALUES (N'Cao cấp');

-- Table: TrinhDoNgoaiNgu
INSERT INTO TrinhDoNgoaiNgu (TenTDNN) VALUES (N'Đọc Hiểu');
INSERT INTO TrinhDoNgoaiNgu (TenTDNN) VALUES (N'Dịch Thuật');
INSERT INTO TrinhDoNgoaiNgu (TenTDNN) VALUES (N'Thông Thạo');

-- Table: NgoaiNgu
INSERT INTO NgoaiNgu (TenNN, MaTDNN) VALUES (N'Tiếng Anh', 1);
INSERT INTO NgoaiNgu (TenNN, MaTDNN) VALUES (N'Tiếng Pháp', 2);
INSERT INTO NgoaiNgu (TenNN, MaTDNN) VALUES (N'Tiếng Nhật', 3);

-- Table: TrangThaiLamViec
INSERT INTO TrangThaiLamViec (TenTTLV, KyHieu) VALUES (N'Đang làm việc', 'DLV');
INSERT INTO TrangThaiLamViec (TenTTLV, KyHieu) VALUES (N'Nghỉ phép', 'NP');
INSERT INTO TrangThaiLamViec (TenTTLV, KyHieu) VALUES (N'Nghỉ việc', 'NV');

-- Table: XepLoai
INSERT INTO XepLoai (TenXL) VALUES (N'Xuất sắc');
INSERT INTO XepLoai (TenXL) VALUES (N'Giỏi');
INSERT INTO XepLoai (TenXL) VALUES (N'Trung bình');

-- Table: ThangLuong
INSERT INTO ThangLuong (TenTL, DienGiai) VALUES (N'Hệ số lương Quản lý', N'Lương cơ bản theo trình độ');
INSERT INTO ThangLuong (TenTL, DienGiai) VALUES (N'Hệ số lương Trưởng phòng', N'Lương cơ bản theo trình độ');
INSERT INTO ThangLuong (TenTL, DienGiai) VALUES (N'Hệ số lương Nhân Viên', N'Lương cơ bản theo trình độ');

-- Table: HeSoThangBacLuong
INSERT INTO HeSoThangBacLuong (MATL, NgayQD, Bac1, Bac2, Bac3, Bac4, Bac5, Bac6, Bac7, Bac8, Bac9, Bac10, Bac11, Bac12) 
VALUES (3, '2024-01-01', 5100000,5500000, 5900000, 6300000, 6700000, 7100000, 7500000, 7900000, 8300000, 8700000, 9100000, 9500000);
INSERT INTO HeSoThangBacLuong (MATL, NgayQD, Bac1, Bac2, Bac3, Bac4, Bac5, Bac6, Bac7, Bac8, Bac9, Bac10, Bac11, Bac12) 
VALUES (1, '2024-01-01', 6500000, 7000000, 7500000, 8000000, 8500000, 9000000, 9500000, 10000000, 10500000, 11000000, 11500000, 12000000);

-- Table: TinhThanh
INSERT INTO TinhThanh (TenTT) VALUES (N'Hà Nội');
INSERT INTO TinhThanh (TenTT) VALUES (N'TP Hồ Chí Minh');
INSERT INTO TinhThanh (TenTT) VALUES (N'Đà Nẵng');

-- Table: PhongBan
INSERT INTO PhongBan (TenPB, CapDo, DoTuoiVeHuuNam, DoTuoiVeHuuNu) VALUES (N'Phòng Hành Chính', 1, 60, 55);
INSERT INTO PhongBan (TenPB, CapDo, DoTuoiVeHuuNam, DoTuoiVeHuuNu) VALUES (N'Phòng Kỹ Thuật', 2, 60, 55);
INSERT INTO PhongBan (TenPB, CapDo, DoTuoiVeHuuNam, DoTuoiVeHuuNu) VALUES (N'Phòng Kinh Doanh', 3, 60, 55);

-- Table: ChucVu
INSERT INTO ChucVu (TenChucVu, CapDo, HeSoChucDanh) VALUES (N'Giám đốc', 1, 3);
INSERT INTO ChucVu (TenChucVu, CapDo, HeSoChucDanh) VALUES (N'Trưởng phòng', 2, 2);
INSERT INTO ChucVu (TenChucVu, CapDo, HeSoChucDanh) VALUES (N'Phó phòng', 3, 1.5);
INSERT INTO ChucVu (TenChucVu, CapDo, HeSoChucDanh) VALUES (N'Nhân viên', 4, 1.0);

-- Table: DanToc
INSERT INTO DanToc (TenDT) VALUES (N'Kinh');
INSERT INTO DanToc (TenDT) VALUES (N'Tày');
INSERT INTO DanToc (TenDT) VALUES (N'Thái');

-- Table: TonGiao
INSERT INTO TonGiao (TenTG) VALUES (N'Phật giáo');
INSERT INTO TonGiao (TenTG) VALUES (N'Tin lành');
INSERT INTO TonGiao (TenTG) VALUES (N'Không');

-- Table: QuanHeThanNhan
INSERT INTO QuanHeThanNhan (TenQHTN) VALUES (N'Cha mẹ');
INSERT INTO QuanHeThanNhan (TenQHTN) VALUES (N'Anh chị em');
INSERT INTO QuanHeThanNhan (TenQHTN) VALUES (N'Vợ/chồng');

-- Table: DinhMucXangXe
INSERT INTO DinhMucXangXe (TenPTien, DMXX) VALUES (N'Xe máy', 300.0);
INSERT INTO DinhMucXangXe (TenPTien, DMXX) VALUES (N'Ô tô', 130.0);
INSERT INTO DinhMucXangXe (TenPTien, DMXX) VALUES (N'Xe đạp', 400.0);



Create TRIGGER trg_TinhLuongBangLuong
ON BangLuong
AFTER INSERT, UPDATE
AS
BEGIN
    -- Khởi động một giao dịch để bảo đảm tính toàn vẹn của dữ liệu
    BEGIN TRANSACTION;

    -- Cập nhật các cột tính toán cho bảng BangLuong dựa trên công thức tính lương
    UPDATE BangLuong
    SET 
        -- Mức lương cơ sở
        MucLuongCoSo = MucLuongTTV * HSL,

        -- Tiền lương bình quân 1 ngày
        TienLuongBQMN = (MucLuongTTV * HSL) / 26,

        -- Lương thời gian
        LuongThoiGian = (MucLuongTTV * HSL / 26) * NgayCong,

        -- Ngày công hưởng 100%
        NgayHuongCong100PT = (MucLuongTTV * HSL / 26) * NgayCong,

        -- Chức vụ, trách nhiệm
        PhuCapTTCV = 0.2 * MucLuongTTV,

        -- Tiền ăn giữa ca
        TienAnGiuaCa = NgayCong * 25000,

        -- Tiền K3
        TienK3 = CongK3 * ((MucLuongTTV * HSL / 26) * 0.3),

        -- Tổng lương
        TongLuong = 
            ((MucLuongTTV * HSL / 26) * NgayCong) + 
            (0.2 * MucLuongTTV) + 
            (ISNULL((SELECT DMXX FROM DinhMucXangXe WHERE MaDMXX = BangLuong.MaDMXX), 0)) + 
            (NgayCong * 25000) + 
            (CongK3 * ((MucLuongTTV * HSL / 26) * 0.3)) + 
            ISNULL(TienThuong, 0) - ISNULL(TamUng, 0),

        -- Bảo hiểm xã hội (BHXH)
        TruBHXH = (MucLuongTTV * HSL + (0.2 * MucLuongTTV)) * 0.08,

        -- Bảo hiểm y tế (BHYT)
        TruBHYT = (MucLuongTTV * HSL + (0.2 * MucLuongTTV)) * 0.015,

        -- Bảo hiểm thất nghiệp (BHTN)
        TruBHTN = (MucLuongTTV * HSL + (0.2 * MucLuongTTV)) * 0.01,

        -- Thuế thu nhập cá nhân hàng tháng (10% của tổng lương tháng)
        ThuePhaiNop = TongLuong * 0.1,

        -- Thuế thu nhập cả năm (15% của thu nhập chịu thuế cả năm)
        ThueCaNam = (TongLuong *12 ) * 0.15,

        -- Tổng lương nhận được sau khi trừ các khoản bảo hiểm và thuế tháng
        SoTienConNhan = 
            (TongLuong - 
            (TruBHXH + TruBHYT + TruBHTN + ThuePhaiNop + ISNULL(TamUng, 0)))

    FROM BangLuong
    WHERE EXISTS (SELECT 1 FROM inserted i WHERE i.MaBangL = BangLuong.MaBangL);

    -- Kết thúc giao dịch
    COMMIT TRANSACTION;
END;


CREATE TRIGGER trg_UpdateSalaryOnTamUngChange
ON BangTamUng
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @MaNV INT, @Thang INT, @Nam INT, @SoTienTU FLOAT;

    -- Lấy MaNV, Thang, và Nam từ bản ghi mới (inserted) hoặc đã xóa (deleted)
    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        SELECT @MaNV = MaNV, @Thang = Thang, @Nam = Nam
        FROM inserted;
    END
    ELSE IF EXISTS (SELECT * FROM deleted)
    BEGIN
        SELECT @MaNV = MaNV, @Thang = Thang, @Nam = Nam
        FROM deleted;
    END

    -- Tính tổng tiền tạm ứng cho nhân viên với tháng và năm chỉ định trong bảng BangTamUng
    SELECT @SoTienTU = ISNULL(SUM(SoTienTU), 0)
    FROM BangTamUng
    WHERE MaNV = @MaNV AND Thang = @Thang AND Nam = @Nam;

    -- Cập nhật SoTienTU và SoTienConNhan trong bảng BangLuong nếu có tháng, năm, và mã NV trùng khớp
    UPDATE BangLuong
    SET TamUng = @SoTienTU,
        SoTienConNhan = TongLuong - TruBHXH - TruBHYT - TruBHTN - @SoTienTU
    WHERE MaNV = @MaNV AND Thang = @Thang AND Nam = @Nam;
END;





INSERT INTO NhanVien (MaNV, TenNV, BiDanh, GioiTinh, NgaySinh, QueQuan, NoiSinh, NoiOHienTai, SoCCCD, NgayCap, NoiCap, Email, SoDienThoai, Anh, NgayVaoDoan, NoiVaoDoan, NgayVaoDang, NoiVaoDang, NgayVaoLam, NgayRoiCoQuan, LyDo, HeSoLuong, HeSoPhuCap, HeSoTNVK, SoSocBH, NgayCapSo, NoiCapSo, SoThe, SoTaiKhoan, NganHang, TinhTrangHonNhan, TinhTrangSuckhoe, ChieuCao, CanNang, NhomMau, NgayNhapNgu, NgayXuatNgu, QuanHamCaoNhat, ThoiGianNangBacHSL, KhongChoPhepNangLuong, RoiCoQuan, NghiHuu, LuongCoSo, MaDMXX, MaTG, MaChucVu, MaXL, MaTT, MaTDVH, MaDT, MaCM, MaNN, MaTDLLCT, MaTTLV)
VALUES 
(1, N'Nguyen Van A', N'A', N'Nam', '1985-01-01', N'Hà Nội', N'Hà Nội', N'123 Phố Huế, Hà Nội', '012345678901', '2005-01-01', N'Hà Nội', N'nguyenvana@example.com', '0909123456', NULL, '2001-06-01', N'Hà Nội', '2003-08-01', N'Hà Nội', '2005-09-01', NULL, NULL, 4.5, 1.2, 0.8, 123456, '2006-01-01', N'Hà Nội', '123456789', '0123456789', N'Vietcombank', 1, N'Tốt', 1.75, 65, N'O', '2003-02-01', NULL, N'Thiếu tá', 5, 0, 0, 0, 6500000, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1);

INSERT INTO NhanVien (MaNV, TenNV, BiDanh, GioiTinh, NgaySinh, QueQuan, NoiSinh, NoiOHienTai, SoCCCD, NgayCap, NoiCap, Email, SoDienThoai, Anh, NgayVaoDoan, NoiVaoDoan, NgayVaoDang, NoiVaoDang, NgayVaoLam, NgayRoiCoQuan, LyDo, HeSoLuong, HeSoPhuCap, HeSoTNVK, SoSocBH, NgayCapSo, NoiCapSo, SoThe, SoTaiKhoan, NganHang, TinhTrangHonNhan, TinhTrangSuckhoe, ChieuCao, CanNang, NhomMau, NgayNhapNgu, NgayXuatNgu, QuanHamCaoNhat, ThoiGianNangBacHSL, KhongChoPhepNangLuong, RoiCoQuan, NghiHuu, LuongCoSo, MaDMXX, MaTG, MaChucVu, MaXL, MaTT, MaTDVH, MaDT, MaCM, MaNN, MaTDLLCT, MaTTLV)
VALUES 
(2, N'Tran Thi B', N'B', N'Nữ', '1990-05-15', N'Hải Phòng', N'Hải Phòng', N'456 Đường Láng, Hà Nội', '098765432109', '2010-05-15', N'Hải Phòng', N'tranthib@example.com', '0912345678', NULL, '2007-06-15', N'Hải Phòng', '2008-09-15', N'Hải Phòng', '2010-10-01', NULL, NULL, 4.0, 1.0, 0.7, 654321, '2011-05-15', N'Hải Phòng', '987654321', '1234567890', N'Agribank', 1, N'Khá', 1.65, 52, N'B', '2009-03-01', '2011-09-01', N'Thiếu úy', 3, 0, 0, 0, 7000000, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2);

INSERT INTO NhanVien (MaNV, TenNV, BiDanh, GioiTinh, NgaySinh, QueQuan, NoiSinh, NoiOHienTai, SoCCCD, NgayCap, NoiCap, Email, SoDienThoai, Anh, NgayVaoDoan, NoiVaoDoan, NgayVaoDang, NoiVaoDang, NgayVaoLam, NgayRoiCoQuan, LyDo, HeSoLuong, HeSoPhuCap, HeSoTNVK, SoSocBH, NgayCapSo, NoiCapSo, SoThe, SoTaiKhoan, NganHang, TinhTrangHonNhan, TinhTrangSuckhoe, ChieuCao, CanNang, NhomMau, NgayNhapNgu, NgayXuatNgu, QuanHamCaoNhat, ThoiGianNangBacHSL, KhongChoPhepNangLuong, RoiCoQuan, NghiHuu, LuongCoSo, MaDMXX, MaTG, MaChucVu, MaXL, MaTT, MaTDVH, MaDT, MaCM, MaNN, MaTDLLCT, MaTTLV)
VALUES 
(3, N'Le Van C', N'C', N'Nam', '1988-03-22', N'Đà Nẵng', N'Đà Nẵng', N'789 Đinh Bộ Lĩnh, Đà Nẵng', '987654321098', '2015-03-22', N'Đà Nẵng', N'levanc@example.com', '0987654321', NULL, '2005-04-01', N'Đà Nẵng', '2006-06-01', N'Đà Nẵng', '2015-07-01', NULL, NULL, 5.2, 1.4, 0.9, 111222, '2016-03-22', N'Đà Nẵng', '111222333', '222333444', N'Techcombank', 0, N'Tốt', 1.80, 70, N'AB', NULL, NULL, NULL, 4, 0, 0, 0, 8000000, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3);


-- Chèn dữ liệu vào bảng ChamCongTL
INSERT INTO ChamCongTL (TenCCTL,Nam, Thang, Khoa, NgayTinhCong, NgayCongTrongThang, TrangThai)
VALUES
('Bảng lương tháng 10',2024, 10, 0, '2024-10-01', 28, 1),
('Bảng lương tháng 09',2024, 09, 1, '2024-09-02', 26, 1);

-- Chèn dữ liệu vào bảng NguoiDung
INSERT INTO NguoiDung (TenDangNhap, MatKhau, MaChucVu, Quyen, MaNV)
VALUES
('user1', 'password1', 1, 'Admin', 1),
('user2', 'password2', 2, 'User', 2);

-- Chèn dữ liệu vào bảng ChucNangPhanMem
INSERT INTO ChucNangPhanMem (TenCN, DienGiai, MaND)
VALUES
('Chức năng 1', 'Mô tả chức năng 1', 1),
('Chức năng 2', 'Mô tả chức năng 2', 2);

-- Chèn dữ liệu vào bảng ChungChi
INSERT INTO ChungChi (TenCC, MaNV, NgayCap, NgayHetHan, NoiCap)
VALUES
('Chứng chỉ 1', 1, '2024-01-01', '2025-01-01', 'Hà Nội'),
('Chứng chỉ 2', 2, '2024-02-01', '2025-02-01', 'TP. Hồ Chí Minh');






INSERT INTO BangLuong (MaCCTL, Thang, Nam, HSL, HSPC, MaMLTT, MucLuongTTV, MucLuongTTC, NgayCong, MucLuongCoSo, PhuCapTTCV,
                       TienLuongBQMN, LuongThoiGian, NgayHuongCong100PT, TienAnGiuaCa, CongK3, TienK3, 
                       CongTgNgayThuong, CongTGNgayNghi, CongTGNgayLe, TienThuong, MaDMXX, LeTet, 
                       GhiChuLeTet, TongLuong, TruBHYT, TruBHXH, TruBHTN, SoTienConNhan, MucThue, 
                       ThuePhaiNop, ThueCaNam, TamUng, TongThucNhan, MaPB, MaChucVu, MaNV, MaND)
VALUES
(1, 10, 2024, 1.5, 2.0, 1, 1, 4960000, 28, 5000000, 1000000, 
 2000000, 1500000, 1, 100000, 10, 1000000, 
 28, 0, 0, 2000000, 1, 300000, 
 'Thưởng cuối năm', 20000000, 1500000, 2000000, 1000000, 500000,10, 
 1000000, 12000000, 2000000, 10000000, 1, 1, 1, 1);

INSERT INTO BangLuong (MaCCTL, Thang, Nam, HSL, HSPC, MaMLTT, MucLuongTTV, MucLuongTTC, NgayCong, MucLuongCoSo, PhuCapTTCV,
                       TienLuongBQMN, LuongThoiGian, NgayHuongCong100PT, TienAnGiuaCa, CongK3, TienK3, 
                       CongTgNgayThuong, CongTGNgayNghi, CongTGNgayLe, TienThuong, MaDMXX, LeTet, 
                       GhiChuLeTet, TongLuong, TruBHYT, TruBHXH, TruBHTN, SoTienConNhan, MucThue, 
                       ThuePhaiNop, ThueCaNam, TamUng, TongThucNhan, MaPB, MaChucVu, MaNV, MaND)
VALUES
(2, 10, 2024, 2.0, 2.0, 2, 2, 4100000, 24, 5500000, 1200000, 
 2500000, 1600000, 1, 120000, 12, 1200000, 
 22, 2, 0, 2200000, 2, 350000, 
 'Thưởng tết', 21000000, 1600000, 2100000, 1100000, 600000,10, 
 1200000, 13000000, 2100000, 11000000, 2, 2, 2, 2);