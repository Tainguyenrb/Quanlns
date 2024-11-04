using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO;
using DataLayer;

namespace BusinessLayer
{
    public class QLTAMUNG
    {
        QuanlynhansuEntities db = new QuanlynhansuEntities();
        public BangTamUng getItems(int MaBTU)
        {
            return db.BangTamUng.FirstOrDefault(x => x.MaBTU == MaBTU);
        }


        public List<BangTamUng> getList()
        {
            return db.BangTamUng.ToList();
        }



        public List<QLTAMUNG_DTO> getListFull()
        {
            var lstTU = db.BangTamUng.ToList();
            List<QLTAMUNG_DTO> lstTUDTO = new List<QLTAMUNG_DTO>();
            QLTAMUNG_DTO tuDTO;
            foreach (var item in lstTU)
            {
                tuDTO = new QLTAMUNG_DTO();
                tuDTO.MaBTU = item.MaBTU;
                tuDTO.NgayTU = item.NgayTU;
                tuDTO.Thang = item.Thang;
                tuDTO.Nam = item.Nam;


           
                tuDTO.SoTienTU = item.SoTienTU;
                tuDTO.DienGiai = item.DienGiai;

                tuDTO.MaNV = item.MaNV;
                var nv = db.NhanVien.FirstOrDefault(b => b.MaNV == item.MaNV);
                tuDTO.TenNV = nv.TenNV;

                lstTUDTO.Add(tuDTO);
            }
            return lstTUDTO;
        }

        public BangTamUng Add(BangTamUng tu)
        {
            try
            {
                db.BangTamUng.Add(tu);
                db.SaveChanges();
                return tu;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public BangTamUng Update(BangTamUng tu)
        {
            try
            {
                var _tu = db.BangTamUng.FirstOrDefault(x => x.MaBTU == tu.MaBTU);

                _tu.NgayTU = tu.NgayTU;
                _tu.Thang = tu.Thang;
                _tu.Nam = tu.Nam;
                _tu.SoTienTU = tu.SoTienTU;
                _tu.DienGiai = tu.DienGiai; 
                _tu.MaNV = tu.MaNV;
                db.SaveChanges();
                return tu;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }



        public void Del(int MaBTU)
        {
            try
            {
                var _tu = db.BangTamUng.FirstOrDefault(x => x.MaBTU == MaBTU);
                db.BangTamUng.Remove(_tu);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

    }
}
