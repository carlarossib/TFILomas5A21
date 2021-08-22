using LMJ.Data;
using LMJ.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMJ.Business
{
    public class AsociadoBusiness
    {
        public List<Asociado> List()
        {
            List<Asociado> result = default(List<Asociado);
            var asociadoDAC = new AsociadoDAC();
            result = asociadoDAC.Select();
            return result;
        }

        public void Edit(Asociado asociado)
        {
            var asociadoDAC = new AsociadoDAC();
            asociadoDAC.UpdateById(asociado);
        }


        public Asociado Get(int id)
        {
            var asociadoDAC = new AsociadoDAC();
            var result = asociadoDAC.SelectById(id);
            return result;
        }

        public Asociado Add(Asociado asociado)
        {
            Asociado result = default(Asociado);
            var asociadoDAC = new AsociadoDAC();

            result = asociadoDAC.Create(asociado);
            return result;
        }


        public void Remove(int id)
        {
            var asociadoDAC = new AsociadoDAC();
            asociadoDAC.DeleteById(id);
        }
        //private BaseDataService<Artist> db = new BaseDataService<Artist>();
        //public List<Artist> GetArtist()
        //{
        //    return db.Get();
        //}
        //public Artist EditArtist(Artist artist)
        //{
        //    return db.Update(artist, artist.Id);
        //}
        //public Artist GetById(int id)
        //{
        //    return db.GetById(id);
        //}
        //public Artist Create(Artist artist)
        //{
        //    return db.Create(artist);
        //}
        //public void Delete (int id)
        //{
        //    db.Delete(id);
        //}
    }
}
