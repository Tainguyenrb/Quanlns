using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TRANGTHAILAMVIEC
    {
        QuanlynhansuEntities db = new QuanlynhansuEntities();
        public TrangThaiLamViec getItems(int MaTTLV)
        {
            return db.TrangThaiLamViec.FirstOrDefault(x => x.MaTTLV == MaTTLV);
        }


        public List<TrangThaiLamViec> getList()
        {
            return db.TrangThaiLamViec.ToList();
        }


        public TrangThaiLamViec Add(TrangThaiLamViec tl)
        {
            try
            {
                db.TrangThaiLamViec.Add(tl);
                db.SaveChanges();
                return tl;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public TrangThaiLamViec Update(TrangThaiLamViec ttlv)
        {
            try
            {
                var _ttlv = db.TrangThaiLamViec.FirstOrDefault(x => x.MaTTLV == ttlv.MaTTLV);
                _ttlv.TenTTLV = ttlv.TenTTLV;
                _ttlv.KyHieu = ttlv.KyHieu;
                db.SaveChanges();
                return ttlv;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }



        public void Del(int MaTTLV)
        {
            try
            {
                var _ttlv = db.TrangThaiLamViec.FirstOrDefault(x => x.MaTTLV == MaTTLV);
                db.TrangThaiLamViec.Remove(_ttlv);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

    }
}
