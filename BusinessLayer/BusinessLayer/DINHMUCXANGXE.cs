using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DINHMUCXANGXE
    {
        QuanlynhansuEntities db = new QuanlynhansuEntities();
        public DinhMucXangXe getItems(int MaDMXX)
        {
            return db.DinhMucXangXe.FirstOrDefault(x => x.MaDMXX == MaDMXX);
        }


        public List<DinhMucXangXe> getList()
        {
            return db.DinhMucXangXe.ToList();
        }


        public DinhMucXangXe Add(DinhMucXangXe tl)
        {
            try
            {
                db.DinhMucXangXe.Add(tl);
                db.SaveChanges();
                return tl;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public DinhMucXangXe Update(DinhMucXangXe tl)
        {
            try
            {
                var _tl = db.DinhMucXangXe.FirstOrDefault(x => x.MaDMXX == tl.MaDMXX);
                _tl.TenPTien = tl.TenPTien;
                _tl.DMXX = tl.DMXX;
                db.SaveChanges();
                return tl;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }



        public void Del(int MaDMXX)
        {
            try
            {
                var _tl = db.DinhMucXangXe.FirstOrDefault(x => x.MaDMXX == MaDMXX);
                db.DinhMucXangXe.Remove(_tl);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }


    }
}
