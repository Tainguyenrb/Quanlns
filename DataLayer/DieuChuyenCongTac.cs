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
    
    public partial class DieuChuyenCongTac
    {
        public int MaCCT { get; set; }
        public System.DateTime NgayChuyen { get; set; }
        public string SoQD { get; set; }
        public Nullable<int> MaPB { get; set; }
        public Nullable<int> MaChucVu { get; set; }
        public Nullable<int> MaHD { get; set; }
        public Nullable<int> MaNV { get; set; }
        public Nullable<int> MaBL { get; set; }
        public string GhiChu { get; set; }
    
        public virtual ChucVu ChucVu { get; set; }
        public virtual HeSoThangBacLuong HeSoThangBacLuong { get; set; }
        public virtual HopDong HopDong { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual PhongBan PhongBan { get; set; }
    }
}