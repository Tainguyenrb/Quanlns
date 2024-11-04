using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace BusinessLayer
{
    public class TRINHDOCHUYENMON
    {
        QuanlynhansuEntities db = new QuanlynhansuEntities();
        public TrinhDoChuyenMon getItems(int MaTDCM)
        {
            return db.TrinhDoChuyenMon.FirstOrDefault(x => x.MaTDCM == MaTDCM);
        }


        public List<TrinhDoChuyenMon> getList()
        {
            return db.TrinhDoChuyenMon.ToList();
        }


        public TrinhDoChuyenMon Add(TrinhDoChuyenMon tdcm)
        {
            try
            {
                db.TrinhDoChuyenMon.Add(tdcm);
                db.SaveChanges();
                return tdcm;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public TrinhDoChuyenMon Update(TrinhDoChuyenMon tdcm)
        {
            try
            {
                var _tdcm = db.TrinhDoChuyenMon.FirstOrDefault(x => x.MaTDCM == tdcm.MaTDCM);
                _tdcm.TenTDCM = tdcm.TenTDCM;
                db.SaveChanges();
                return tdcm;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }



        public void Del(int MaTDCM)
        {
            try
            {
                var _tdcm = db.TrinhDoChuyenMon.FirstOrDefault(x => x.MaTDCM == MaTDCM);
                db.TrinhDoChuyenMon.Remove(_tdcm);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }


    }
}
