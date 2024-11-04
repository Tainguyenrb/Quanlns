using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer.DTO
{
    public class QUATRINHLUONG_DTO
    {
        public int MaQTL { get; set; }
        public System.DateTime NgayQD { get; set; }
        public System.DateTime NgayHuong { get; set; }
        public System.DateTime NgayNangCapLuong { get; set; }
        public Nullable<float> MaBL { get; set; }
        public Nullable<float> Bac1 { get; set; }
        public Nullable<float> Bac2 { get; set; }
        public Nullable<float> Bac3 { get; set; }
        public Nullable<float> Bac4 { get; set; }
        public Nullable<float> Bac5 { get; set; }
        public Nullable<float> Bac6 { get; set; }
        public Nullable<float> Bac7 { get; set; }
        public Nullable<float> Bac8 { get; set; }
        public Nullable<float> Bac9 { get; set; }
        public Nullable<float> Bac10 { get; set; }
        public Nullable<float> Bac11 { get; set; }
        public Nullable<float> Bac12 { get; set; }
        public Nullable<double> HSL { get; set; }
        public Nullable<double> HSPC { get; set; }
        public Nullable<int> MaMLTT { get; set; }
        public Nullable<int> MLTTC { get; set; }
        public Nullable<int> MaNV { get; set; }
        public string TenNV { get; set; }
    }
}
