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
    
    public partial class PhongBan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhongBan()
        {
            this.BangLuong = new HashSet<BangLuong>();
            this.DienBienTrangThaiLamViec = new HashSet<DienBienTrangThaiLamViec>();
            this.DieuChuyenCongTac = new HashSet<DieuChuyenCongTac>();
            this.QuaTrinhCongTac = new HashSet<QuaTrinhCongTac>();
            this.QuaTrinhDaoTao = new HashSet<QuaTrinhDaoTao>();
            this.XepLoaiCanBo = new HashSet<XepLoaiCanBo>();
        }
    
        public int MaPB { get; set; }
        public string TenPB { get; set; }
        public int CapDo { get; set; }
        public Nullable<int> DoTuoiVeHuuNam { get; set; }
        public Nullable<int> DoTuoiVeHuuNu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BangLuong> BangLuong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DienBienTrangThaiLamViec> DienBienTrangThaiLamViec { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DieuChuyenCongTac> DieuChuyenCongTac { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuaTrinhCongTac> QuaTrinhCongTac { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuaTrinhDaoTao> QuaTrinhDaoTao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XepLoaiCanBo> XepLoaiCanBo { get; set; }
    }
}
