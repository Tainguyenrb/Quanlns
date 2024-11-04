using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class DANTOC
    {
        QuanlynhansuEntities db = new QuanlynhansuEntities();
        public DanToc getItems(int MaDT)
        {
            return db.DanToc.FirstOrDefault(x => x.MaDT == MaDT);
        }


        public List<DanToc> getList()
        {
            return db.DanToc.ToList();
        }


        public DanToc Add(DanToc dt)
        {
            try
            {
                db.DanToc.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public DanToc Update(DanToc dt)
        {
            try
            {
                var _dt = db.DanToc.FirstOrDefault(x => x.MaDT == dt.MaDT); 
                _dt.TenDT = dt.TenDT;
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }



        public void Del(int MaDT)
        {
            try
            {
                var _dt = db.DanToc.FirstOrDefault(x => x.MaDT == MaDT);
                db.DanToc.Remove(_dt);
                db.SaveChanges();
                
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }





    }
}
