using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer.DTO
{
    public class NGUOIDUNG_DTO
    {
        public int MaND { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public Nullable<int> MaChucVu { get; set; }
        public string TenChucVu { get; set; }
        public string Quyen { get; set; }
        public Nullable<int> MaNV { get; set; }
        public string TenNV { get; set; }

    }
}
