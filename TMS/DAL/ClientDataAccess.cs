using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClientDataAccess
    {
        static TMSUPEntities db;
        static ClientDataAccess()
        {
            db = new TMSUPEntities();
        }
        public static ClientRepo<Client, int> GetUser()
        {
            return new UsersRepo(dbObj);
        }
        public static IPost<Post, int> GetRecentPost()
        {
            return new PostRepo(dbObj);
        }

        public static ICourses<Cours, int> GetRecentCourses()
        {
            return new CoursesRepo(dbObj);
        }


    }
}
