using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class THANGLUONG
    {

        QuanlynhansuEntities db = new QuanlynhansuEntities();
        public ThangLuong getItems(int MaTL)
        {
            return db.ThangLuong.FirstOrDefault(x => x.MaTL == MaTL);
        }


        public List<ThangLuong> getList()
        {
            return db.ThangLuong.ToList();
        }


        public ThangLuong Add(ThangLuong tl)
        {
            try
            {
                db.ThangLuong.Add(tl);
                db.SaveChanges();
                return tl;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public ThangLuong Update(ThangLuong tl)
        {
            try
            {
                var _tl = db.ThangLuong.FirstOrDefault(x => x.MaTL == tl.MaTL);
                _tl.TenTL = tl.TenTL;
                _tl.DienGiai = tl.DienGiai;
                db.SaveChanges();
                return tl;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }



        public void Del(int MaTL)
        {
            try
            {
                var _tl = db.ThangLuong.FirstOrDefault(x => x.MaTL == MaTL);
                db.ThangLuong.Remove(_tl);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }


    }
}
