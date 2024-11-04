using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer
{
    public class CHUCVU
    {
        QuanlynhansuEntities db = new QuanlynhansuEntities();
        public ChucVu getItems(int MaChucVu)
        {
            return db.ChucVu.FirstOrDefault(x => x.MaChucVu == MaChucVu);
        }


        public List<ChucVu> getList()
        {
            return db.ChucVu.ToList();
        }


        public ChucVu Add(ChucVu cv)
        {
            try
            {
                db.ChucVu.Add(cv);
                db.SaveChanges();
                return cv;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public ChucVu Update(ChucVu cv)
        {
            try
            {
                var _cv = db.ChucVu.FirstOrDefault(x => x.MaChucVu == cv.MaChucVu);
                _cv.TenChucVu = cv.TenChucVu;
                db.SaveChanges();
                return cv;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }



        public void Del(int MaChucVu)
        {
            try
            {
                var _cv = db.ChucVu.FirstOrDefault(x => x.MaChucVu == MaChucVu);
                db.ChucVu.Remove(_cv);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

    }
}
