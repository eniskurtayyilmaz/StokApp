using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokUygulaması.EntityCrud
{
    public class EntityByUpdated
    {
        EntityByConnection Connection = new EntityByConnection();
        public EntityByUpdated(int id,string Urun)
        {
            int x = id;
            var Update = Connection.Db.StokKartı.Find(x);
            Update.StokKod = id;
            Update.StokKart = Urun;
            Connection.Db.SaveChanges();
        }
        public EntityByUpdated(int id,int adet,int cıktı)
        {
            int x = id;
            var Update = Connection.Db.StokHareket.Find(x);
            Update.Id = id;
            Update.Girdi = adet;
            Update.Cıktı = cıktı;
            Connection.Db.SaveChanges();
        }
    }
}
