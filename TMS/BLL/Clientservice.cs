using AutoMapper;
using BLL.Entity;
using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Clientservice
    {
        static Clientservice()
        {
            TMSUPEntities db = new TMSUPEntities();
            var config = new MapperConfiguration(cfg =>cfg.CreateMap<Client, ClientModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ClientModel>>(db.Clients.ToList());
        }

        public static object Get()
        {
            throw new NotImplementedException();
        }

        public static void Create(ClientModel b)
        {
            var u = ClientDataAccess.GetUser().InstructorsList();
            return u;
        }

        public static void Edit(ClientModel b)
        {
            var u = ClientDataAccess.GetUser().InstructorsList();
            return u;
        }

        public static void Delete(string id)
        {
          var u= ClientDataAccess.Delete(id);
            return u;
        }

        public static List<ClientModel> Get(int id)
        {
            var u = ClientDataAccess.GetUser().InstructorsList();
            return u;
        }
        public static ClientModel Get(string id)
        {

            var u = ClientDataAccess.GetUser().InstructorsList();
            return u;
        }
    }
}
