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
    
    public partial class QuaTrinhDaoTao
    {
        public int MaQTDT { get; set; }
        public Nullable<int> MaNV { get; set; }
        public System.DateTime NgayBatDau { get; set; }
        public System.DateTime NgayHetHan { get; set; }
        public string TruongDaoTao { get; set; }
        public string NuocDaoTao { get; set; }
        public string NganhDaoTao { get; set; }
        public string HinhThucDaoTao { get; set; }
        public string TrinhDoDaoTao { get; set; }
        public Nullable<int> MaPB { get; set; }
        public Nullable<int> MaChucVu { get; set; }
    
        public virtual ChucVu ChucVu { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual PhongBan PhongBan { get; set; }
    }
}
