using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TRINHDOVANHOA
    {

        QuanlynhansuEntities db = new QuanlynhansuEntities();
        public TrinhDoVanHoa getItems(int MaTDVH)
        {
            return db.TrinhDoVanHoa.FirstOrDefault(x => x.MaTDVH == MaTDVH);
        }


        public List<TrinhDoVanHoa> getList()
        {
            return db.TrinhDoVanHoa.ToList();
        }


        public TrinhDoVanHoa Add(TrinhDoVanHoa tdvh)
        {
            try
            {
                db.TrinhDoVanHoa.Add(tdvh);
                db.SaveChanges();
                return tdvh;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public TrinhDoVanHoa Update(TrinhDoVanHoa tdvh)
        {
            try
            {
                var _tdvh = db.TrinhDoVanHoa.FirstOrDefault(x => x.MaTDVH == tdvh.MaTDVH);
                _tdvh.TenTDVH = tdvh.TenTDVH;
                db.SaveChanges();
                return tdvh;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }



        public void Del(int MaTDVH)
        {
            try
            {
                var _tdvh = db.TrinhDoVanHoa.FirstOrDefault(x => x.MaTDVH == MaTDVH);
                db.TrinhDoVanHoa.Remove(_tdvh);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}
