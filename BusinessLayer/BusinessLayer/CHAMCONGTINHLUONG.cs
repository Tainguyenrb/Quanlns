using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO;
using DataLayer;

namespace BusinessLayer
{
    public class CHAMCONGTINHLUONG
    {
        QuanlynhansuEntities db = new QuanlynhansuEntities();


        public List<ChamCongTL> getList()
        {
            return db.ChamCongTL.ToList();
        }


        
        public ChamCongTL getItems(int MaCCTL)
        {
            return db.ChamCongTL.FirstOrDefault(x => x.MaCCTL == MaCCTL);
        }


       


        public ChamCongTL Add(ChamCongTL cctl)
        {
            try
            {
                db.ChamCongTL.Add(cctl);
                db.SaveChanges();
                return cctl;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public ChamCongTL Update(ChamCongTL cctl)
        {
            try
            {
                var _cctl = db.ChamCongTL.FirstOrDefault(x => x.MaCCTL== cctl.MaCCTL);
                _cctl.Nam= cctl.Nam;
                _cctl.Thang= cctl.Thang;
                _cctl.Khoa= cctl.Khoa;
                _cctl.NgayTinhCong= cctl.NgayTinhCong;
                _cctl.NgayCongTrongThang= cctl.NgayCongTrongThang;
                _cctl.TrangThai = cctl.TrangThai;
               
                db.SaveChanges();
                return cctl;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }



        public void Del(int MaCCTL,int iduser)
        {
            try
            {
                var _cctl = db.ChamCongTL.FirstOrDefault(x => x.MaCCTL == MaCCTL);
                
                //db.ChamCongTL.Remove(_cctl);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

    } 
}
