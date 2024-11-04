//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            this.BangLuong = new HashSet<BangLuong>();
            this.BangTamUng = new HashSet<BangTamUng>();
            this.ChungChi = new HashSet<ChungChi>();
            this.DienBienTrangThaiLamViec = new HashSet<DienBienTrangThaiLamViec>();
            this.DieuChuyenCongTac = new HashSet<DieuChuyenCongTac>();
            this.GiaHanHopDong = new HashSet<GiaHanHopDong>();
            this.HopDong = new HashSet<HopDong>();
            this.KhenThuongKyLuat = new HashSet<KhenThuongKyLuat>();
            this.NguoiDung = new HashSet<NguoiDung>();
            this.QuaTrinhCongTac = new HashSet<QuaTrinhCongTac>();
            this.QuaTrinhDaoTao = new HashSet<QuaTrinhDaoTao>();
            this.QuaTrinhLuong = new HashSet<QuaTrinhLuong>();
            this.ThanNhan = new HashSet<ThanNhan>();
            this.XepLoaiCanBo = new HashSet<XepLoaiCanBo>();
        }
    
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public string BiDanh { get; set; }
        public string GioiTinh { get; set; }
        public System.DateTime NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public string NoiSinh { get; set; }
        public string NoiOHienTai { get; set; }
        public string SoCCCD { get; set; }
        public System.DateTime NgayCap { get; set; }
        public string NoiCap { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public byte[] Anh { get; set; }
        public System.DateTime NgayVaoDoan { get; set; }
        public string NoiVaoDoan { get; set; }
        public System.DateTime NgayVaoDang { get; set; }
        public string NoiVaoDang { get; set; }
        public System.DateTime NgayVaoLam { get; set; }
        public Nullable<System.DateTime> NgayRoiCoQuan { get; set; }
        public string LyDo { get; set; }
        public Nullable<double> HeSoLuong { get; set; }
        public Nullable<double> HeSoPhuCap { get; set; }
        public Nullable<double> HeSoTNVK { get; set; }
        public int SoSocBH { get; set; }
        public System.DateTime NgayCapSo { get; set; }
        public string NoiCapSo { get; set; }
        public string SoThe { get; set; }
        public string SoTaiKhoan { get; set; }
        public string NganHang { get; set; }
        public bool TinhTrangHonNhan { get; set; }
        public string TinhTrangSuckhoe { get; set; }
        public double ChieuCao { get; set; }
        public double CanNang { get; set; }
        public string NhomMau { get; set; }
        public Nullable<System.DateTime> NgayNhapNgu { get; set; }
        public Nullable<System.DateTime> NgayXuatNgu { get; set; }
        public string QuanHamCaoNhat { get; set; }
        public Nullable<int> ThoiGianNangBacHSL { get; set; }
        public Nullable<bool> KhongChoPhepNangLuong { get; set; }
        public Nullable<bool> RoiCoQuan { get; set; }
        public Nullable<bool> NghiHuu { get; set; }
        public Nullable<double> LuongCoSo { get; set; }
        public Nullable<int> MaDMXX { get; set; }
        public Nullable<int> MaTG { get; set; }
        public Nullable<int> MaChucVu { get; set; }
        public Nullable<int> MaXL { get; set; }
        public Nullable<int> MaTT { get; set; }
        public Nullable<int> MaTDVH { get; set; }
        public Nullable<int> MaDT { get; set; }
        public Nullable<int> MaCM { get; set; }
        public Nullable<int> MaNN { get; set; }
        public Nullable<int> MaTDLLCT { get; set; }
        public Nullable<int> MaTTLV { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BangLuong> BangLuong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BangTamUng> BangTamUng { get; set; }
        public virtual ChucVu ChucVu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChungChi> ChungChi { get; set; }
        public virtual ChuyenMon ChuyenMon { get; set; }
        public virtual DanToc DanToc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DienBienTrangThaiLamViec> DienBienTrangThaiLamViec { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DieuChuyenCongTac> DieuChuyenCongTac { get; set; }
        public virtual DinhMucXangXe DinhMucXangXe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaHanHopDong> GiaHanHopDong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HopDong> HopDong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhenThuongKyLuat> KhenThuongKyLuat { get; set; }
        public virtual NgoaiNgu NgoaiNgu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NguoiDung> NguoiDung { get; set; }
        public virtual TrinhDoLyLuanChinhTri TrinhDoLyLuanChinhTri { get; set; }
        public virtual TrinhDoVanHoa TrinhDoVanHoa { get; set; }
        public virtual TonGiao TonGiao { get; set; }
        public virtual TinhThanh TinhThanh { get; set; }
        public virtual TrangThaiLamViec TrangThaiLamViec { get; set; }
        public virtual XepLoai XepLoai { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuaTrinhCongTac> QuaTrinhCongTac { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuaTrinhDaoTao> QuaTrinhDaoTao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuaTrinhLuong> QuaTrinhLuong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThanNhan> ThanNhan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XepLoaiCanBo> XepLoaiCanBo { get; set; }
    }
}