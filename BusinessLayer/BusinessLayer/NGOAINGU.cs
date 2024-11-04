using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class NGOAINGU
    {

        QuanlynhansuEntities db = new QuanlynhansuEntities();
        public NgoaiNgu getItems(int MaNN)
        {
            return db.NgoaiNgu.FirstOrDefault(x => x.MaNN == MaNN);
        }


        public List<NgoaiNgu> getList()
        {
            return db.NgoaiNgu.ToList();
        }



        public List<NGOAINGU_DTO> getListFull()
        {
            var lstNN = db.NgoaiNgu.ToList();
            List<NGOAINGU_DTO> lstNNDTO = new List<NGOAINGU_DTO>();
            NGOAINGU_DTO nnDTO;
            foreach (var item in lstNN)
            {
                nnDTO = new NGOAINGU_DTO();
                nnDTO.MaNN = item.MaNN;
                nnDTO.TenNN = item.TenNN;

                nnDTO.MaTDNN = item.MaTDNN;
                var tdnn = db.TrinhDoNgoaiNgu.FirstOrDefault(b => b.MaTDNN == item.MaTDNN);
                nnDTO.TenTDNN = tdnn.TenTDNN;

                lstNNDTO.Add(nnDTO);
            }
            return lstNNDTO;
        }

        public NgoaiNgu Add(NgoaiNgu nn)
        {
            try
            {
                db.NgoaiNgu.Add(nn);
                db.SaveChanges();
                return nn;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public NgoaiNgu Update(NgoaiNgu nn)
        {
            try
            {
                var _nn = db.NgoaiNgu.FirstOrDefault(x => x.MaNN == nn.MaNN);
                _nn.TenNN = nn.TenNN;
                _nn.MaTDNN = nn.MaTDNN;
                db.SaveChanges();
                return nn;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }



        public void Del(int MaNN)
        {
            try
            {
                var _nn = db.NgoaiNgu.FirstOrDefault(x => x.MaNN == MaNN);
                db.NgoaiNgu.Remove(_nn);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

    }
}
