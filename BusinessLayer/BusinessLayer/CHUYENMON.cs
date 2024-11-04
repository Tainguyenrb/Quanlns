using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO;
using DataLayer;

namespace BusinessLayer
{
     public class CHUYENMON
    {

        QuanlynhansuEntities db = new QuanlynhansuEntities();
        public ChuyenMon getItems(int MaCM)
        {
            return db.ChuyenMon.FirstOrDefault(x => x.MaCM == MaCM);
        }


        public List<ChuyenMon> getList()
        {
            return db.ChuyenMon.ToList();
        }

        

        public List<CHUYENMON_DTO> getListFull()
        {
            var lstCM = db.ChuyenMon.ToList();
            List<CHUYENMON_DTO> lstCMDTO = new List<CHUYENMON_DTO>();
            CHUYENMON_DTO cmDTO;
            foreach (var item in lstCM)
            {
                cmDTO = new CHUYENMON_DTO();
                cmDTO.MaCM = item.MaCM;
                cmDTO.TenCM = item.TenCM;
                
                cmDTO.MaTDCM = item.MaTDCM;
                var tdcm = db.TrinhDoChuyenMon.FirstOrDefault(b => b.MaTDCM == item.MaTDCM);
                cmDTO.TenTDCM = tdcm.TenTDCM;
                
                lstCMDTO.Add(cmDTO);
            }
            return lstCMDTO;
        }

        public ChuyenMon Add(ChuyenMon cm)
        {
            try
            {
                db.ChuyenMon.Add(cm);
                db.SaveChanges();
                return cm;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public ChuyenMon Update(ChuyenMon cm)
        {
            try
            {
                var _cm = db.ChuyenMon.FirstOrDefault(x => x.MaCM == cm.MaCM);
                _cm.TenCM = cm.TenCM;
                _cm.MaTDCM = cm.MaTDCM;
                db.SaveChanges();
                return cm;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }



        public void Del(int MaCM)
        {
            try
            {
                var _cm = db.ChuyenMon.FirstOrDefault(x => x.MaCM == MaCM);
                db.ChuyenMon.Remove(_cm);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

    }
}
