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
    
    public partial class ChucNangPhanMem
    {
        public int MaCN { get; set; }
        public string TenCN { get; set; }
        public string DienGiai { get; set; }
        public Nullable<int> MaND { get; set; }
    
        public virtual NguoiDung NguoiDung { get; set; }
    }
}
