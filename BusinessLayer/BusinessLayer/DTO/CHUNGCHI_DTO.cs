using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer.DTO
{
    public class CHUNGCHI_DTO
    {
        public int MaCC { get; set; }
        public string TenCC { get; set; }
        public Nullable<int> MaNV { get; set; }
        public string TenNV { get; set; }
        public System.DateTime NgayCap { get; set; }
        public System.DateTime NgayHetHan { get; set; }
        public string NoiCap { get; set; }
    }
}
