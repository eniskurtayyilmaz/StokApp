using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokUygulaması.EntityCrud
{
    public class EntityByAdded
    {
        EntityByConnection Connection = new EntityByConnection();

        public EntityByAdded(string Urun)
        {
            StokKartı kart = new StokKartı();
            kart.StokKart = Urun;
            Connection.Db.StokKartı.Add(kart);
            Connection.Db.SaveChanges();
        }

        public EntityByAdded(int id,int adet,int cıktı)
        {
            StokHareket hareket = new StokHareket();
            hareket.Id = id;
            hareket.Girdi = adet;
            hareket.Cıktı = cıktı;
            Connection.Db.StokHareket.Add(hareket);
            Connection.Db.SaveChanges();
        }
        public EntityByAdded(int id, int adet)
        {
            StokHareket hareket = new StokHareket();
            hareket.Id = id;
            hareket.Girdi = adet;
            Connection.Db.StokHareket.Add(hareket);
            Connection.Db.SaveChanges();
        }
    }
}
