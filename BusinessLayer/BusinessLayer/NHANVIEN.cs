using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class NHANVIEN
    {
        QuanlynhansuEntities db = new QuanlynhansuEntities();
        public NhanVien getItems(int MaNN)
        {
            return db.NhanVien.FirstOrDefault(x => x.MaNN == MaNN);
        }


        public List<NhanVien> getList()
        {
            return db.NhanVien.ToList();
        }



        public List<NHANVIEN_DTO> getListFull()
        {
            var lstNV = db.NhanVien.ToList();
            List<NHANVIEN_DTO> lstNVDTO = new List<NHANVIEN_DTO>();
            NHANVIEN_DTO nvDTO;
            foreach (var item in lstNV)
            {
                nvDTO = new NHANVIEN_DTO();
                nvDTO.MaNV = item.MaNV;
                nvDTO.TenNV = item.TenNV;
                nvDTO.BiDanh = item.BiDanh;
                nvDTO.GioiTinh = item.GioiTinh;
                nvDTO.NgaySinh = item.NgaySinh;
                nvDTO.QueQuan = item.QueQuan;
                nvDTO.NoiSinh = item.NoiSinh;
                nvDTO.NoiOHienTai = item.NoiOHienTai;
                nvDTO.SoCCCD = item.SoCCCD;
                nvDTO.NgayCap= item.NgayCap;
                nvDTO.Email =   item.Email;
                nvDTO.SoDienThoai = item.SoDienThoai;
                nvDTO.Anh = item.Anh;
                nvDTO.NgayVaoDoan = item.NgayVaoDoan;
                nvDTO.NoiVaoDoan = item.NoiVaoDoan;
                nvDTO.NgayVaoDang = item.NgayVaoDang;
                nvDTO.NoiVaoDang= item.NoiVaoDang;
                nvDTO.NgayVaoLam = item.NgayVaoLam;
                nvDTO.NgayRoiCoQuan = item.NgayRoiCoQuan;
                nvDTO.LyDo= item.LyDo;
                nvDTO.HeSoLuong = item.HeSoLuong;
                nvDTO.HeSoPhuCap = item.HeSoPhuCap;
                nvDTO.HeSoTNVK = item.HeSoTNVK;
                nvDTO.SoThe = item.SoThe;
                nvDTO.SoTaiKhoan = item.SoTaiKhoan;
                nvDTO.NganHang = item.NganHang;
                nvDTO.TinhTrangHonNhan = item.TinhTrangHonNhan;
                nvDTO.TinhTrangSuckhoe = item.TinhTrangSuckhoe;
                nvDTO.ChieuCao = item.ChieuCao;
                nvDTO.CanNang = item.CanNang;
                nvDTO.NhomMau = item.NhomMau;
                nvDTO.NgayNhapNgu = item.NgayNhapNgu;
                nvDTO.NgayXuatNgu= item.NgayXuatNgu;
                nvDTO.QuanHamCaoNhat = item.QuanHamCaoNhat;
                nvDTO.ThoiGianNangBacHSL= item.ThoiGianNangBacHSL;
                nvDTO.KhongChoPhepNangLuong = item.KhongChoPhepNangLuong;
                nvDTO.RoiCoQuan = item.RoiCoQuan;
                nvDTO.NghiHuu= item.NghiHuu;
                nvDTO.LuongCoSo = item.LuongCoSo;


                nvDTO.MaDMXX = item.MaDMXX;
               var dmxx = db.DinhMucXangXe.FirstOrDefault(b => b.MaDMXX == item.MaDMXX);
                nvDTO.DMXX =(int) dmxx.DMXX;

                nvDTO.MaTG = item.MaTG;
                var tg = db.TonGiao.FirstOrDefault(b => b.MaTG == item.MaTG);
                nvDTO.TenTG = tg.TenTG;

               

                nvDTO.MaChucVu = item.MaChucVu;
                var cv = db.ChucVu.FirstOrDefault(b => b.MaChucVu  == item.MaChucVu);
                nvDTO.TenChucVu = cv.TenChucVu;

                

                nvDTO.MaXL = item.MaXL;
                var xl = db.XepLoai.FirstOrDefault(b => b.MaXL == item.MaXL);
                nvDTO.TenXL= xl.TenXL;

                nvDTO.MaTT  = item.MaTT;
                var tt = db.TinhThanh.FirstOrDefault(b => b.MaTT == item.MaTT);
                nvDTO.TenTT = tt.TenTT;

                nvDTO.MaTDVH = item.MaTDVH;
                var tdvh = db.TrinhDoVanHoa.FirstOrDefault(b => b.MaTDVH == item.MaTDVH);
                nvDTO.TenTDVH= tdvh.TenTDVH;

                nvDTO.MaDT = item.MaDT;
                var dt = db.DanToc.FirstOrDefault(b => b.MaDT == item.MaDT);
                nvDTO.TenDT = dt.TenDT;

                nvDTO.MaCM = item.MaCM;
                var cm = db.ChuyenMon.FirstOrDefault(b => b.MaCM == item.MaCM);
                nvDTO.TenCM = cm.TenCM;

                nvDTO.MaTDLLCT = item.MaTDLLCT;
                var llct = db.TrinhDoLyLuanChinhTri.FirstOrDefault(b => b.MaTDLLCT == item.MaTDLLCT);
                nvDTO.TenTDLLCT = llct.TenTDLLCT;



                lstNVDTO.Add(nvDTO);
            }
            return lstNVDTO;
        }

        public NhanVien Add(NhanVien nn)
        {
            try
            {
                db.NhanVien.Add(nn);
                db.SaveChanges();
                return nn;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public NhanVien Update(NhanVien nv)
        {
            try
            {
                var _nv = db.NhanVien.FirstOrDefault(x => x.MaNV == nv.MaNV);
                _nv.MaNV = nv.MaNV;
                _nv.TenNV = nv.TenNV;
                _nv.BiDanh = nv.BiDanh;
                _nv.GioiTinh = nv.GioiTinh;
                _nv.NgaySinh = nv.NgaySinh;
                _nv.QueQuan = nv.QueQuan;
                _nv.NoiSinh = nv.NoiSinh;
                _nv.NoiOHienTai = nv.NoiOHienTai;
                _nv.SoCCCD = nv.SoCCCD;
                _nv.NgayCap = nv.NgayCap;
                _nv.Email = nv.Email;
                _nv.SoDienThoai = nv.SoDienThoai;
                _nv.Anh = nv.Anh;
                _nv.NgayVaoDoan = nv.NgayVaoDoan;
                _nv.NoiVaoDoan = nv.NoiVaoDoan;
                _nv.NgayVaoDang = nv.NgayVaoDang;
                _nv.NoiVaoDang = nv.NoiVaoDang;
                _nv.NgayVaoLam = nv.NgayVaoLam;
                _nv.NgayRoiCoQuan = nv.NgayRoiCoQuan;
                _nv.LyDo = nv.LyDo;
                _nv.HeSoLuong = nv.HeSoLuong;
                _nv.HeSoPhuCap = nv.HeSoPhuCap;
                _nv.HeSoTNVK = nv.HeSoTNVK;
                _nv.SoThe = nv.SoThe;
                _nv.SoTaiKhoan = nv.SoTaiKhoan;
                _nv.NganHang = nv.NganHang;
                _nv.TinhTrangHonNhan = nv.TinhTrangHonNhan;
                _nv.TinhTrangSuckhoe = nv.TinhTrangSuckhoe;
                _nv.ChieuCao = nv.ChieuCao;
                _nv.CanNang = nv.CanNang;
                _nv.NhomMau = nv.NhomMau;
                _nv.NgayNhapNgu = nv.NgayNhapNgu;
                _nv.NgayXuatNgu = nv.NgayXuatNgu;
                _nv.QuanHamCaoNhat = nv.QuanHamCaoNhat;
                _nv.ThoiGianNangBacHSL = nv.ThoiGianNangBacHSL;
                _nv.KhongChoPhepNangLuong = nv.KhongChoPhepNangLuong;
                _nv.RoiCoQuan = nv.RoiCoQuan;
                _nv.NghiHuu = nv.NghiHuu;
                _nv.LuongCoSo = nv.LuongCoSo;
                _nv.MaDMXX = nv.MaDMXX;
                _nv.MaTG = nv.MaTG;
               
                _nv.MaChucVu = nv.MaChucVu;
                _nv.MaXL = nv.MaXL;
                _nv.MaTT = nv.MaTT;
                _nv.MaTDVH = nv.MaTDVH;
                _nv.MaDT = nv.MaDT;
                _nv.MaCM = nv.MaCM;
                _nv.MaTDLLCT = nv.MaTDLLCT;
               
                db.SaveChanges();
                return nv;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }



        public void Del(int MaNN)
        {
            try
            {
                var _nv = db.NhanVien.FirstOrDefault(x => x.MaNN == MaNN);
                db.NhanVien.Remove(_nv);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }


    }
}
