using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer.DTO
{
    public class QLTAMUNG_DTO
    {

        public int MaBTU { get; set; }
        public System.DateTime NgayTU { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public double SoTienTU { get; set; }
        public string DienGiai { get; set; }
        public Nullable<int> MaNV { get; set; }
        public string TenNV { get; set; }
    }
}
