using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer.DTO
{
    public class NHANVIEN_DTO
    {
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
        public int DMXX { get; set; }
        public Nullable<int> MaTG { get; set; }
        public string TenTG { get; set; }
       
        public string TenBH { get; set; }
        public Nullable<int> MaChucVu { get; set; }
        public string TenChucVu { get; set; }
        public Nullable<int> MaXL { get; set; }
        public string TenXL { get; set; }
        public Nullable<int> MaTT { get; set; }
        public string TenTT { get; set; }
        public Nullable<int> MaTDVH { get; set; }
        public string TenTDVH { get; set; }
        public Nullable<int> MaDT { get; set; }
        public string TenDT { get; set; }
        public Nullable<int> MaCM { get; set; }
        public string TenCM { get; set; }
        public Nullable<int> MaNN { get; set; }
        public string TenNN { get; set; }
        public Nullable<int> MaTDLLCT { get; set; }
        public string TenTDLLCT { get; set; }
        public Nullable<int> MaTTLV { get; set; }
        public string TenTTLV { get; set; }


    }
}
