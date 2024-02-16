using DogsFK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogsFK.Controller
{
    public class LoginController
    {
        public bool IsLogin(string username, string password)
        {
            using (DogsDBEntities db = new DogsDBEntities())
            {
                var validAccount = db.User.Where(u => u.Username == username && u.Password == password).FirstOrDefault();
                if (validAccount != null)
                {
                    GlobalData.Id = validAccount.Id;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
