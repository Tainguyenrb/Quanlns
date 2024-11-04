using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TRINHDONGOAINGU
    {
        QuanlynhansuEntities db = new QuanlynhansuEntities();
        public TrinhDoNgoaiNgu getItems(int MaTDNN)
        {
            return db.TrinhDoNgoaiNgu.FirstOrDefault(x => x.MaTDNN == MaTDNN);
        }


        public List<TrinhDoNgoaiNgu> getList()
        {
            return db.TrinhDoNgoaiNgu.ToList();
        }


        public TrinhDoNgoaiNgu Add(TrinhDoNgoaiNgu tdnn)
        {
            try
            {
                db.TrinhDoNgoaiNgu.Add(tdnn);
                db.SaveChanges();
                return tdnn;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public TrinhDoNgoaiNgu Update(TrinhDoNgoaiNgu tdnn)
        {
            try
            {
                var _tdnn = db.TrinhDoNgoaiNgu.FirstOrDefault(x => x.MaTDNN == tdnn.MaTDNN);
                _tdnn.TenTDNN = tdnn.TenTDNN;
                db.SaveChanges();
                return tdnn;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }



        public void Del(int MaTDNN)
        {
            try
            {
                var _tdnn = db.TrinhDoNgoaiNgu.FirstOrDefault(x => x.MaTDNN == MaTDNN);
                db.TrinhDoNgoaiNgu.Remove(_tdnn);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}
