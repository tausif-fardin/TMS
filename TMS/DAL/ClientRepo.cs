using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class ClientRepo : IRepo<Client, int>
    {
        TMSUPEntities db;

        public ClientRepo(TMSUPEntities db)
        {
            this.db = db;
        }

        public void Add(Client e)
        {
            this.db.Clients.Add(e);
            this.db.SaveChanges();
        }

        public void Delete(int id)
        {
            var buyer = db.Clients.FirstOrDefault(c => c.clientid == id);
            db.Clients.Remove(buyer);
            db.SaveChanges();
        }

        public void Edit(Client e)
        {
            var b = db.Clients.FirstOrDefault(en => en.clientid == e.clientid);
            db.Entry(b).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Client> Get()
        {
            return db.Clients.ToList();
        }

        public Client Get(int id)
        {
            return db.Clients.FirstOrDefault(c => c.clientid == id);
        }
    }
}
