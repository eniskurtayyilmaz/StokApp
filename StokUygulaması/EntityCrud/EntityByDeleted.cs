using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokUygulaması.EntityCrud
{
    public class EntityByDeleted
    {
        EntityByConnection Connection = new EntityByConnection();

        public void EntityByDeletedCard(int id)
        {
            int x = Convert.ToInt32(id);
            var Search = Connection.Db.StokKartı.Find(id);
            Connection.Db.StokKartı.Remove(Search);
            Connection.Db.SaveChanges();
        }
        public void EntityByDeletedMovements(int id)
        {
            int x = Convert.ToInt32(id);
            var Search = Connection.Db.StokHareket.Find(id);
            Connection.Db.StokHareket.Remove(Search);
            Connection.Db.SaveChanges();
        }
    }
}
