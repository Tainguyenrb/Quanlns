using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class HSTLTHEOBAC
    {
        QuanlynhansuEntities db = new QuanlynhansuEntities();
        public HeSoThangBacLuong getItems(int MaBL)
        {
            return db.HeSoThangBacLuong.FirstOrDefault(x => x.MaBL == MaBL);
        }


        public List<HeSoThangBacLuong> getList()
        {
            return db.HeSoThangBacLuong.ToList();
        }



        public List<HSTLTHEOBAC_DTO> getListFull()
        {
            var lstBL = db.HeSoThangBacLuong.ToList();
            List<HSTLTHEOBAC_DTO> lstBLDTO = new List<HSTLTHEOBAC_DTO>();
            
            foreach (var item in lstBL)
            {
                HSTLTHEOBAC_DTO blDTO = new HSTLTHEOBAC_DTO();
                blDTO.MaBL = item.MaBL;
               

                blDTO.MATL = item.MATL;
                var tl = db.ThangLuong.FirstOrDefault(b => b.MaTL == item.MATL);
                blDTO.TenTL = tl.TenTL;

                blDTO.NgayQD = item.NgayQD;
                blDTO.Bac1 = item.Bac1;
                blDTO.Bac2 = item.Bac2;
                blDTO.Bac3 = item.Bac3;
                blDTO.Bac4 = item.Bac4;
                blDTO.Bac5 = item.Bac5;
                blDTO.Bac6 = item.Bac6;
                blDTO.Bac7 = item.Bac7;
                blDTO.Bac8 = item.Bac8;
                blDTO.Bac9 = item.Bac9;
                blDTO.Bac10 = item.Bac10;
                blDTO.Bac11 = item.Bac11;
                blDTO.Bac12 = item.Bac12;


                lstBLDTO.Add(blDTO);
            }
            return lstBLDTO;
        }

        public HeSoThangBacLuong Add(HeSoThangBacLuong cm)
        {
            try
            {
                db.HeSoThangBacLuong.Add(cm);
                db.SaveChanges();
                return cm;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public HeSoThangBacLuong Update(HeSoThangBacLuong bl)
        {
            try
            {
                var _bl = db.HeSoThangBacLuong.FirstOrDefault(x => x.MaBL == bl.MaBL);
                _bl.MATL = bl.MATL;
                _bl.NgayQD = bl.NgayQD;
                bl.Bac1 = bl.Bac1;
                bl.Bac2 = bl.Bac2;
                bl.Bac3 = bl.Bac3;
                bl.Bac4 = bl.Bac4;
                bl.Bac5 = bl.Bac5;
                bl.Bac6 = bl.Bac6;
                bl.Bac7 = bl.Bac7;
                bl.Bac8 = bl.Bac8;
                bl.Bac9 = bl.Bac9;
                bl.Bac10 = bl.Bac10;
                bl.Bac11 = bl.Bac11;
                bl.Bac12 = bl.Bac12;
                
                db.SaveChanges();
                return bl;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }



        public void Del(int MaBL)
        {
            try
            {
                var _cm = db.HeSoThangBacLuong.FirstOrDefault(x => x.MaBL == MaBL);
                db.HeSoThangBacLuong.Remove(_cm);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }


    }
}
