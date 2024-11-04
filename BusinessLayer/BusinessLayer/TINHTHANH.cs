using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer
{
    public class TINHTHANH
    {

        QuanlynhansuEntities db = new QuanlynhansuEntities();
        public TinhThanh getItems(int MaTT)
        {
            return db.TinhThanh.FirstOrDefault(x => x.MaTT == MaTT);
        }


        public List<TinhThanh> getList()
        {
            return db.TinhThanh.ToList();
        }


        public TinhThanh Add(TinhThanh cv)
        {
            try
            {
                db.TinhThanh.Add(cv);
                db.SaveChanges();
                return cv;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public TinhThanh Update(TinhThanh tt)
        {
            try
            {
                var _tt = db.TinhThanh.FirstOrDefault(x => x.MaTT == tt.MaTT);
                _tt.TenTT = tt.TenTT;
                db.SaveChanges();
                return tt;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }



        public void Del(int MaTT)
        {
            try
            {
                var _tt = db.TinhThanh.FirstOrDefault(x => x.MaTT == MaTT);
                db.TinhThanh.Remove(_tt);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

    }
}
