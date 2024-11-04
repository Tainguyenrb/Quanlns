using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class QUANHETHANNHAN
    {
        QuanlynhansuEntities db = new QuanlynhansuEntities();
        public QuanHeThanNhan getItems(int MaQHTN)
        {
            return db.QuanHeThanNhan.FirstOrDefault(x => x.MaQHTN == MaQHTN);
        }


        public List<QuanHeThanNhan> getList()
        {
            return db.QuanHeThanNhan.ToList();
        }


        public QuanHeThanNhan Add(QuanHeThanNhan qhtn)
        {
            try
            {
                db.QuanHeThanNhan.Add(qhtn);
                db.SaveChanges();
                return qhtn;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public QuanHeThanNhan Update(QuanHeThanNhan qhtn)
        {
            try
            {
                var _qhtn = db.QuanHeThanNhan.FirstOrDefault(x => x.MaQHTN == qhtn.MaQHTN);
                _qhtn.TenQHTN = qhtn.TenQHTN;
                db.SaveChanges();
                return qhtn;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }



        public void Del(int MaQHTN)
        {
            try
            {
                var _qhtn = db.QuanHeThanNhan.FirstOrDefault(x => x.MaQHTN == MaQHTN);
                db.QuanHeThanNhan.Remove(_qhtn);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}
