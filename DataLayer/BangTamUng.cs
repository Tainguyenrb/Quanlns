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
    
    public partial class BangTamUng
    {
        public int MaBTU { get; set; }
        public System.DateTime NgayTU { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public double SoTienTU { get; set; }
        public string DienGiai { get; set; }
        public Nullable<int> MaNV { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
    }
}
