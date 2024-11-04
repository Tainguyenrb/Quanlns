using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BusinessLayer
{
    public class TONGIAO
    {
        QuanlynhansuEntities db = new QuanlynhansuEntities();
        public TonGiao getItems(int MaTG)
        {
            return db.TonGiao.FirstOrDefault(x => x.MaTG == MaTG);
        }


        public List<TonGiao> getList()
        {
            return db.TonGiao.ToList();
        }


        public TonGiao Add(TonGiao tg)
        {
            try
            {
                db.TonGiao.Add(tg);
                db.SaveChanges();
                return tg;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public TonGiao Update(TonGiao tg)
        {
            try
            {
                var _tg = db.TonGiao.FirstOrDefault(x => x.MaTG == tg.MaTG);
                _tg.TenTG = tg.TenTG;
                db.SaveChanges();
                return tg;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }



        public void Del(int MaTG)
        {
            try
            {
                var _tg = db.TonGiao.FirstOrDefault(x => x.MaTG == MaTG);
                db.TonGiao.Remove(_tg);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }



    }
}
