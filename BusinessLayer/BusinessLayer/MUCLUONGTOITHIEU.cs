using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class MUCLUONGTOITHIEU
    {
        QuanlynhansuEntities db = new QuanlynhansuEntities();
        public MucLuongToiThieu getItems(int MaMLTT)
        {
            return db.MucLuongToiThieu.FirstOrDefault(x => x.MaMLTT == MaMLTT);
        }


        public List<MucLuongToiThieu> getList()
        {
            return db.MucLuongToiThieu.ToList();
        }


        public MucLuongToiThieu Add(MucLuongToiThieu mltt)
        {
            try
            {
                db.MucLuongToiThieu.Add(mltt);
                db.SaveChanges();
                return mltt;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public MucLuongToiThieu Update(MucLuongToiThieu mltt)
        {
            try
            {
                var _mltt = db.MucLuongToiThieu.FirstOrDefault(x => x.MaMLTT == mltt.MaMLTT);
                _mltt.NgayAD = mltt.NgayAD;
                _mltt.MLTTC = mltt.MLTTC;
                _mltt.MLTTVung = mltt.MLTTVung;


                db.SaveChanges();
                return mltt;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }



        public void Del(int MaMLTT)
        {
            try
            {
                var _mltt = db.MucLuongToiThieu.FirstOrDefault(x => x.MaMLTT == MaMLTT);
                db.MucLuongToiThieu.Remove(_mltt);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

    }
}
