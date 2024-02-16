using DogsFK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogsFK.Controller
{
    internal class MainController
    {
        public List<Dogs> ShowDogsById(int id)
        {
            using (DogsDBEntities db = new DogsDBEntities())
            {
                return db.Dogs.Where(d => d.UserId == id).ToList();
            }
        }

        public List<User> ShowUsersWithMoreThan2Dogs()
        {
            using (DogsDBEntities db = new DogsDBEntities())
            {
                return db.User.Where(u => u.Dogs.Count > 2).ToList();
            }
        }
    }
}
