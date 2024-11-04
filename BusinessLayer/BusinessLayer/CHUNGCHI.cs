using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer
{
    public class CHUNGCHI
    {

        QuanlynhansuEntities db = new QuanlynhansuEntities();
        public ChungChi getItems(int MaCC)
        {
            return db.ChungChi.FirstOrDefault(x => x.MaCC == MaCC);
        }


        public List<ChungChi> getList()
        {
            return db.ChungChi.ToList();
        }
        public List<CHUNGCHI_DTO> getListFull()
        {
            var lstCC = db.ChungChi.ToList();
            List<CHUNGCHI_DTO> lstCCDTO = new List<CHUNGCHI_DTO>();
            CHUNGCHI_DTO ccDTO;
            foreach (var item in lstCC) { 
            ccDTO= new CHUNGCHI_DTO();
            ccDTO.MaCC = item.MaCC;
            ccDTO.TenCC = item.TenCC;

            ccDTO.MaNV= item.MaNV;
            var nv = db.NhanVien.FirstOrDefault(b => b.MaNV== item.MaNV);
            ccDTO.TenNV = nv.TenNV;

            ccDTO.NgayCap = item.NgayCap;
            ccDTO.NgayHetHan = item.NgayHetHan;
            ccDTO.NoiCap = item.NoiCap;

                lstCCDTO.Add(ccDTO);
            }
            return lstCCDTO;
        }


        public ChungChi Add(ChungChi cv)
        {
            try
            {
                db.ChungChi.Add(cv);
                db.SaveChanges();
                return cv;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public ChungChi Update(ChungChi cc)
        {
            try
            {
                var _cc = db.ChungChi.FirstOrDefault(x => x.MaCC == cc.MaCC);
                _cc.TenCC = cc.TenCC;
                _cc.MaNV = cc.MaNV;
                _cc.NgayCap = cc.NgayCap;
                _cc.NgayHetHan = cc.NgayHetHan;
                _cc.NoiCap = cc.NoiCap;

                db.SaveChanges();
                return cc;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }



        public void Del(int MaCC)
        {
            try
            {
                var _cc = db.ChungChi.FirstOrDefault(x => x.MaCC == MaCC);
                db.ChungChi.Remove(_cc);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }



    }
}
