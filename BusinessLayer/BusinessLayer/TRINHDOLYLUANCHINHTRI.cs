using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class TRINHDOLYLUANCHINHTRI
    {

        QuanlynhansuEntities db = new QuanlynhansuEntities();
        public TrinhDoLyLuanChinhTri getItems(int MaTDLLCT)
        {
            return db.TrinhDoLyLuanChinhTri.FirstOrDefault(x => x.MaTDLLCT == MaTDLLCT);
        }


        public List<TrinhDoLyLuanChinhTri> getList()
        {
            return db.TrinhDoLyLuanChinhTri.ToList();
        }


        public TrinhDoLyLuanChinhTri Add(TrinhDoLyLuanChinhTri cv)
        {
            try
            {
                db.TrinhDoLyLuanChinhTri.Add(cv);
                db.SaveChanges();
                return cv;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public TrinhDoLyLuanChinhTri Update(TrinhDoLyLuanChinhTri tdllct)
        {
            try
            {
                var _tdllct = db.TrinhDoLyLuanChinhTri.FirstOrDefault(x => x.MaTDLLCT == tdllct.MaTDLLCT);
                _tdllct.TenTDLLCT = tdllct.TenTDLLCT;
                db.SaveChanges();
                return tdllct;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }



        public void Del(int MaTDLLCT)
        {
            try
            {
                var _tdllct = db.TrinhDoLyLuanChinhTri.FirstOrDefault(x => x.MaTDLLCT == MaTDLLCT);
                db.TrinhDoLyLuanChinhTri.Remove(_tdllct);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

    }
}
