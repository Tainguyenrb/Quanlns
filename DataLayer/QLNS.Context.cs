﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanlynhansuEntities : DbContext
    {
        public QuanlynhansuEntities()
            : base("name=QuanlynhansuEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BangLuong> BangLuong { get; set; }
        public virtual DbSet<BangTamUng> BangTamUng { get; set; }
        public virtual DbSet<ChamCongTL> ChamCongTL { get; set; }
        public virtual DbSet<ChucNangPhanMem> ChucNangPhanMem { get; set; }
        public virtual DbSet<ChucVu> ChucVu { get; set; }
        public virtual DbSet<ChungChi> ChungChi { get; set; }
        public virtual DbSet<ChuyenMon> ChuyenMon { get; set; }
        public virtual DbSet<DanToc> DanToc { get; set; }
        public virtual DbSet<DienBienTrangThaiLamViec> DienBienTrangThaiLamViec { get; set; }
        public virtual DbSet<DieuChuyenCongTac> DieuChuyenCongTac { get; set; }
        public virtual DbSet<DinhMucXangXe> DinhMucXangXe { get; set; }
        public virtual DbSet<GiaHanHopDong> GiaHanHopDong { get; set; }
        public virtual DbSet<HeSoThangBacLuong> HeSoThangBacLuong { get; set; }
        public virtual DbSet<HopDong> HopDong { get; set; }
        public virtual DbSet<KhenThuongKyLuat> KhenThuongKyLuat { get; set; }
        public virtual DbSet<LoaiHopDong> LoaiHopDong { get; set; }
        public virtual DbSet<MucLuongToiThieu> MucLuongToiThieu { get; set; }
        public virtual DbSet<NgoaiNgu> NgoaiNgu { get; set; }
        public virtual DbSet<NguoiDung> NguoiDung { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<PhongBan> PhongBan { get; set; }
        public virtual DbSet<QuanHeThanNhan> QuanHeThanNhan { get; set; }
        public virtual DbSet<QuaTrinhCongTac> QuaTrinhCongTac { get; set; }
        public virtual DbSet<QuaTrinhDaoTao> QuaTrinhDaoTao { get; set; }
        public virtual DbSet<QuaTrinhLuong> QuaTrinhLuong { get; set; }
        public virtual DbSet<TinhThanh> TinhThanh { get; set; }
        public virtual DbSet<TonGiao> TonGiao { get; set; }
        public virtual DbSet<ThanNhan> ThanNhan { get; set; }
        public virtual DbSet<ThangLuong> ThangLuong { get; set; }
        public virtual DbSet<TrangThaiLamViec> TrangThaiLamViec { get; set; }
        public virtual DbSet<TrinhDoChuyenMon> TrinhDoChuyenMon { get; set; }
        public virtual DbSet<TrinhDoLyLuanChinhTri> TrinhDoLyLuanChinhTri { get; set; }
        public virtual DbSet<TrinhDoNgoaiNgu> TrinhDoNgoaiNgu { get; set; }
        public virtual DbSet<TrinhDoVanHoa> TrinhDoVanHoa { get; set; }
        public virtual DbSet<XepLoai> XepLoai { get; set; }
        public virtual DbSet<XepLoaiCanBo> XepLoaiCanBo { get; set; }
    }
}
