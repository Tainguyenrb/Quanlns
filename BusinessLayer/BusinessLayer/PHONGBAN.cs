using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
    public class PHONGBAN
    {

        QuanlynhansuEntities db = new QuanlynhansuEntities();
        public PhongBan getItems(int MaPB)
        {
            return db.PhongBan.FirstOrDefault(x => x.MaPB == MaPB);
        }


        public List<PhongBan> getList()
        {
            return db.PhongBan.ToList();
        }


        public PhongBan Add(PhongBan pb)
        {
            try
            {
                db.PhongBan.Add(pb);
                db.SaveChanges();
                return pb;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public PhongBan Update(PhongBan pb)
        {
            try
            {
                var _pb = db.PhongBan.FirstOrDefault(x => x.MaPB == pb.MaPB);
                _pb.TenPB = pb.TenPB;
                _pb.CapDo = pb.CapDo;
                _pb.DoTuoiVeHuuNam = pb.DoTuoiVeHuuNam;
                _pb.DoTuoiVeHuuNu = pb.DoTuoiVeHuuNu;
                db.SaveChanges();
                return pb;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }



        public void Del(int MaPB)
        {
            try
            {
                var _pb = db.PhongBan.FirstOrDefault(x => x.MaPB == MaPB);
                db.PhongBan.Remove(_pb);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }


    }
}
