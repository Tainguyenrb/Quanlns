using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO;
using DataLayer;

namespace BusinessLayer
{
    public class NGUOIDUNG
    {
        QuanlynhansuEntities db = new QuanlynhansuEntities();
        public NguoiDung getItems(int MaND)
        {
            return db.NguoiDung.FirstOrDefault(x => x.MaND == MaND);
        }


        public List<NguoiDung> getList()
        {
            return db.NguoiDung.ToList();
        }



        public List<NGUOIDUNG_DTO> getListFull()
        {
            var lstND = db.NguoiDung.ToList();
            List<NGUOIDUNG_DTO> lstNDDTO = new List<NGUOIDUNG_DTO>();
            NGUOIDUNG_DTO ndDTO;
            foreach (var item in lstND)
            {
                ndDTO = new NGUOIDUNG_DTO();
                ndDTO.MaND = item.MaND;
                ndDTO.TenDangNhap = item.TenDangNhap;
                ndDTO.MatKhau = item.MatKhau;
               
                
                ndDTO.MaChucVu = item.MaChucVu;
                var cv = db.ChucVu.FirstOrDefault(b => b.MaChucVu == item.MaChucVu);
                ndDTO.TenChucVu = cv.TenChucVu;

                ndDTO.Quyen = item.Quyen;
                


                ndDTO.MaNV = item.MaNV;
                var nv = db.NhanVien.FirstOrDefault(b => b.MaNV == item.MaNV);
                ndDTO.TenNV = nv.TenNV;

                


                lstNDDTO.Add(ndDTO);
            }
            return lstNDDTO;
        }

        public NguoiDung Add(NguoiDung qtl)
        {
            try
            {
                db.NguoiDung.Add(qtl);
                db.SaveChanges();
                return qtl;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public NguoiDung Update(NguoiDung nd)
        {
            try
            {
                var _nd = db.NguoiDung.FirstOrDefault(x => x.MaND == nd.MaND);
                
                _nd.TenDangNhap = nd.TenDangNhap;
                _nd.MatKhau = nd.MatKhau;
                _nd.MaChucVu = nd.MaChucVu;
                _nd.Quyen = nd.Quyen;
                _nd.MaNV = nd.MaNV;
                

                db.SaveChanges();
                return nd;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }



        public void Del(int MaND)
        {
            try
            {
                var _nd = db.NguoiDung.FirstOrDefault(x => x.MaND == MaND);
                db.NguoiDung.Remove(_nd);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

    }
}
