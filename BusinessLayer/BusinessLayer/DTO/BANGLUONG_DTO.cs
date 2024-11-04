using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer.DTO
{
    public class BANGLUONG_DTO
    {

        public int MaBangL { get; set; }
        public Nullable<int> MaCCTL { get; set; }

        public string TenCCTL { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public double HSL { get; set; }
        public double HSPC { get; set; }
        public int MucLuongTTV { get; set; }
        public double MucLuongTTC { get; set; }
        public double NgayCong { get; set; }
        public double LuongThoiGian { get; set; }
        public double MucLuongCoSo { get; set; }
        public double PhuCapTTCV { get; set; }
        public double TienLuongBQMN { get; set; }
        public float NgayHuongCong100PT { get; set; }
        public double TienAnGiuaCa { get; set; }
        public float CongK3 { get; set; }
        public double TienK3 { get; set; }
        public Nullable<float> CongTgNgayThuong { get; set; }
        public Nullable<float> CongTGNgayNghi { get; set; }
        public Nullable<float> CongTGNgayLe { get; set; }
        public Nullable<double> TienThuong { get; set; }
        public Nullable<double> LeTet { get; set; }
        public string GhiChuLeTet { get; set; }
        public double TongLuong { get; set; }
        public double TruBHYT { get; set; }
        public double TruBHXH { get; set; }
        public double TruBHTN { get; set; }
        public double SoTienConNhan { get; set; }
       
        public int MucThue { get; set; }
        public double ThuePhaiNop { get; set; }
        public double ThueCaNam { get; set; }
        public Nullable<double> TamUng { get; set; }

        public double TongThucNhan { get; set; }
        public Nullable<int> MaDMXX { get; set; }
        public Nullable<int> DMXX { get; set; }
        public Nullable<int> MaMLTT { get; set; }

        public int MLTTVung{ get; set; }

        public int MLTTC { get; set; }
        public Nullable<int> MaPB { get; set; }
        public string TenPB { get; set; }
        public Nullable<int> MaChucVu { get; set; }
        public string TenChucVu { get; set; }
        public Nullable<int> MaNV { get; set; }
        public string TenNV { get; set; }

        public int HeSoLuong { get; set; }
        public int HoSoPhuCap { get; set; }
        public Nullable<int> MaND { get; set; }
        public string TenDangNhap { get; set; }
    }
}
