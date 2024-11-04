using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO;
using DataLayer;

namespace BusinessLayer
{
    public class BANGLUONG
    {
        QuanlynhansuEntities db = new QuanlynhansuEntities();
        public BangLuong getItems(int MaBangL)
        {
            return db.BangLuong.FirstOrDefault(x => x.MaBangL == MaBangL);
        }


        public List<BangLuong> getList()
        {
            return db.BangLuong.ToList();
        }



        public List<BANGLUONG_DTO> getListFull()
        {
            var lstBangL = db.BangLuong.ToList();
            List<BANGLUONG_DTO> lstBangLDTO = new List<BANGLUONG_DTO>();
            BANGLUONG_DTO banglDTO;
            foreach (var item in lstBangL)
            {
                banglDTO = new BANGLUONG_DTO();
                banglDTO.MaBangL = item.MaBangL;

                banglDTO.MaCCTL = item.MaCCTL;
                var cctl = db.ChamCongTL.FirstOrDefault(b => b.MaCCTL == item.MaCCTL);
                banglDTO.TenCCTL= cctl.TenCCTL;

                banglDTO.Thang = item.Thang;
                banglDTO.Nam = item.Nam;

                banglDTO.MaNV = item.MaNV;
                var nv = db.NhanVien.FirstOrDefault(b => b.MaNV == item.MaNV);
                banglDTO.TenNV = nv.TenNV;
                nv = db.NhanVien.FirstOrDefault(b => b.MaNV == item.MaNV);
                banglDTO.HSL= (double)nv.HeSoLuong;
                banglDTO.HSPC =(double) nv.HeSoPhuCap;

                var mltt = db.MucLuongToiThieu.FirstOrDefault(b => b.MaMLTT == item.MaMLTT);
                banglDTO.MucLuongTTV = mltt.MLTTVung;
                banglDTO.MucLuongTTC = mltt.MLTTC;
                banglDTO.LuongThoiGian = item.LuongThoiGian;
                banglDTO.MucLuongCoSo = item.MucLuongCoSo;
                banglDTO.NgayCong = item.NgayCong;
                banglDTO.PhuCapTTCV = item.PhuCapTTCV;
                banglDTO.TienLuongBQMN = item.TienLuongBQMN;
                banglDTO.NgayHuongCong100PT = item.NgayHuongCong100PT;
                banglDTO.TienAnGiuaCa = item.TienAnGiuaCa;
                banglDTO.CongK3= item.CongK3;
                banglDTO.TienK3 = item.TienK3;
                banglDTO.CongTgNgayThuong = item.CongTgNgayThuong;
                banglDTO.CongTGNgayNghi = item.CongTGNgayNghi;
                banglDTO.CongTGNgayLe = item.CongTGNgayLe;
                banglDTO.TienThuong = item.TienThuong;
                banglDTO.LeTet = item.LeTet;
                banglDTO.GhiChuLeTet = item.GhiChuLeTet;
                banglDTO.TongLuong= item.TongLuong;
                banglDTO.TruBHYT = item.TruBHYT;
                banglDTO.TruBHXH = item.TruBHXH;
                banglDTO.TruBHTN = item.TruBHTN;
                banglDTO.SoTienConNhan = item.SoTienConNhan;
                
                banglDTO.MucThue = item.MucThue;
                banglDTO.ThuePhaiNop = item.ThuePhaiNop;
                banglDTO.ThueCaNam = item.ThueCaNam;
                banglDTO.TamUng = item.TamUng;
                banglDTO.TongThucNhan = item.TongThucNhan;

                banglDTO.MaDMXX = item.MaDMXX;
                var dmxx = db.DinhMucXangXe.FirstOrDefault(b => b.MaDMXX == item.MaDMXX);
                banglDTO.DMXX = (int)dmxx.DMXX;

                banglDTO.MaMLTT = item.MaMLTT;
                mltt = db.MucLuongToiThieu.FirstOrDefault(b => b.MaMLTT == item.MaMLTT);
                banglDTO.MLTTC = (int)mltt.MLTTC;

                banglDTO.MaPB = item.MaPB;
                var pb = db.PhongBan.FirstOrDefault(b => b.MaPB == item.MaPB);
                banglDTO.TenPB = pb.TenPB;

                

                banglDTO.MaChucVu = item.MaChucVu;
                var cv = db.ChucVu.FirstOrDefault(b => b.MaChucVu== item.MaChucVu);
                banglDTO.TenChucVu = cv.TenChucVu;

                banglDTO.MaND = item.MaND;
                var nd = db.NguoiDung.FirstOrDefault(b => b.MaND == item.MaND);
                banglDTO.TenDangNhap = nd.TenDangNhap;


                lstBangLDTO.Add(banglDTO);
            }
            return lstBangLDTO;
        }

        public BangLuong Add(BangLuong bangl)
        {
            try
            {
                db.BangLuong.Add(bangl);
                db.SaveChanges();
                return bangl;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public BangLuong Update(BangLuong bangl)
        {
            try
            {
                var _bangl = db.BangLuong.FirstOrDefault(x => x.MaBangL == bangl.MaBangL);
                // _qtl.MaBangL = qtl.MaBangL;
                _bangl.Thang = bangl.Thang;
                _bangl.Nam = bangl.Nam;
                _bangl.HSL = bangl.HSL;
                _bangl.HSPC = bangl.HSPC;
                _bangl.MucLuongTTV = bangl.MucLuongTTV;
                _bangl.MucLuongTTC = bangl.MucLuongTTC;
                _bangl.NgayCong = bangl.NgayCong;
                _bangl.LuongThoiGian = bangl.LuongThoiGian;
                _bangl.MucLuongCoSo = bangl.MucLuongCoSo;
                _bangl.PhuCapTTCV = bangl.PhuCapTTCV;
                _bangl.TienLuongBQMN = bangl.TienLuongBQMN;
                _bangl.NgayHuongCong100PT = bangl.NgayHuongCong100PT;
                _bangl.TienAnGiuaCa = bangl.TienAnGiuaCa;
                _bangl.CongK3 = bangl.CongK3;
                _bangl.TienK3 = bangl.TienK3;
                _bangl.CongTgNgayThuong = bangl.CongTgNgayThuong;
                _bangl.CongTGNgayNghi = bangl.CongTGNgayNghi;
                _bangl.CongTGNgayLe = bangl.CongTGNgayLe;
                _bangl.TienThuong = bangl.TienThuong;
                _bangl.LeTet = bangl.LeTet;
                _bangl.GhiChuLeTet = bangl.GhiChuLeTet;
                _bangl.TongLuong = bangl.TongLuong;
                _bangl.TruBHYT = bangl.TruBHYT;
                _bangl.TruBHXH = bangl.TruBHXH;
                _bangl.TruBHTN = bangl.TruBHTN;
                _bangl.SoTienConNhan = bangl.SoTienConNhan;

                _bangl.MucThue = bangl.MucThue;
                _bangl.ThuePhaiNop = bangl.ThuePhaiNop;
                _bangl.ThueCaNam = bangl.ThueCaNam;
                _bangl.TamUng = bangl.TamUng;
                _bangl.TongThucNhan = bangl.TongThucNhan;
                _bangl.MaDMXX = bangl.MaDMXX;
                _bangl.MaMLTT = bangl.MaMLTT;
                _bangl.MaPB = bangl.MaPB;
                _bangl.MaNV = bangl.MaNV;
                _bangl.MaChucVu = bangl.MaChucVu;
                _bangl.MaND= bangl.MaND;
           
                db.SaveChanges();
                return bangl;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }



        public void Del(int MaBangL)
        {
            try
            {
                var _bangl = db.BangLuong.FirstOrDefault(x => x.MaBangL == MaBangL);
                db.BangLuong.Remove(_bangl);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }


    }
}
