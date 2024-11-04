using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class QUATRINHLUONG
    {

        QuanlynhansuEntities db = new QuanlynhansuEntities();
        public QuaTrinhLuong getItems(int MaQTL)
        {
            return db.QuaTrinhLuong.FirstOrDefault(x => x.MaQTL == MaQTL);
        }


        public List<QuaTrinhLuong> getList()
        {
            return db.QuaTrinhLuong.ToList();
        }



        public List<QUATRINHLUONG_DTO> getListFull()
        {
            var lstQTL = db.QuaTrinhLuong.ToList();
            List<QUATRINHLUONG_DTO> lstQTLDTO = new List<QUATRINHLUONG_DTO>();
            QUATRINHLUONG_DTO qtlDTO;
            foreach (var item in lstQTL)
            {
                qtlDTO = new QUATRINHLUONG_DTO();
                qtlDTO.MaQTL = item.MaQTL;
                qtlDTO.NgayQD = item.NgayQD ;
                qtlDTO.NgayHuong = item.NgayHuong;
                qtlDTO.NgayNangCapLuong = item.NgayNangCapLuong;


                qtlDTO.MaBL = item.MaBL;
                var bl = db.HeSoThangBacLuong.FirstOrDefault(b => b.MaBL == item.MaBL);
                qtlDTO.Bac1 = (int)bl.Bac1;


                qtlDTO.MaBL = item.MaBL;
                bl = db.HeSoThangBacLuong.FirstOrDefault(b => b.MaBL == item.MaBL);
                qtlDTO.Bac2 = (int)bl.Bac2;
               
                bl = db.HeSoThangBacLuong.FirstOrDefault(b => b.MaBL == item.MaBL);
                qtlDTO.Bac3 = (int)bl.Bac3;
                bl = db.HeSoThangBacLuong.FirstOrDefault(b => b.MaBL == item.MaBL);
                qtlDTO.Bac4 = (int)bl.Bac4;
                
                bl = db.HeSoThangBacLuong.FirstOrDefault(b => b.MaBL == item.MaBL);
                qtlDTO.Bac5 = (int)bl.Bac5;
               
                bl = db.HeSoThangBacLuong.FirstOrDefault(b => b.MaBL == item.MaBL);
                qtlDTO.Bac6 = (int)bl.Bac6;
               
                bl = db.HeSoThangBacLuong.FirstOrDefault(b => b.MaBL == item.MaBL);
                qtlDTO.Bac7 = (int)bl.Bac7;
                
                bl = db.HeSoThangBacLuong.FirstOrDefault(b => b.MaBL == item.MaBL);
                qtlDTO.Bac8 = (int)bl.Bac8;

                bl = db.HeSoThangBacLuong.FirstOrDefault(b => b.MaBL == item.MaBL);
                qtlDTO.Bac9 = (int)bl.Bac9;

                bl = db.HeSoThangBacLuong.FirstOrDefault(b => b.MaBL == item.MaBL);
                qtlDTO.Bac10 = (int)bl.Bac10;

                bl = db.HeSoThangBacLuong.FirstOrDefault(b => b.MaBL == item.MaBL);
                qtlDTO.Bac11 = (int)bl.Bac11;

                bl = db.HeSoThangBacLuong.FirstOrDefault(b => b.MaBL == item.MaBL);
                qtlDTO.Bac12 = (int)bl.Bac12;




                qtlDTO.HSL = item.HSL;
                qtlDTO.HSPC = item.HSPC;

                qtlDTO.MaMLTT = item.MaMLTT;
                var mltt = db.MucLuongToiThieu.FirstOrDefault(b => b.MaMLTT == item.MaMLTT);
                qtlDTO.MLTTC = (int)mltt.MLTTC;

                qtlDTO.MaNV = item.MaNV;
                var nv = db.NhanVien.FirstOrDefault(b => b.MaNV == item.MaNV);
                qtlDTO.TenNV = nv.TenNV;

                lstQTLDTO.Add(qtlDTO);
            }
            return lstQTLDTO;
        }

        public QuaTrinhLuong Add(QuaTrinhLuong qtl)
        {
            try
            {
                db.QuaTrinhLuong.Add(qtl);
                db.SaveChanges();
                return qtl;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public QuaTrinhLuong Update(QuaTrinhLuong qtl)
        {
            try
            {
                var _qtl = db.QuaTrinhLuong.FirstOrDefault(x => x.MaQTL == qtl.MaQTL);
                _qtl.MaQTL = qtl.MaQTL;
                _qtl.NgayQD = qtl.NgayQD;
                _qtl.NgayHuong = qtl.NgayHuong;
                _qtl.NgayNangCapLuong = qtl.NgayNangCapLuong;
                _qtl.MaBL = qtl.MaBL;
                _qtl.HSL = qtl.HSL;
                _qtl.HSPC = qtl.HSPC;
                _qtl.MaMLTT = qtl.MaMLTT;
                _qtl.MaNV = qtl.MaNV;
                db.SaveChanges();
                return qtl;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }



        public void Del(int MaQTL)
        {
            try
            {
                var _qtl = db.QuaTrinhLuong.FirstOrDefault(x => x.MaQTL == MaQTL);
                db.QuaTrinhLuong.Remove(_qtl);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }


    }
}
