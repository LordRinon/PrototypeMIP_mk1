using PrototypeMIP_mk1.Model.EF_DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

// Login Module
// Methods
// Login
// Create


namespace PrototypeMIP_mk1.Model
{
    public class LoginModule
    {
        public string Login(string username, string hash)
        {

            using (UserDbContext db = new UserDbContext())
            {
                var res = from user in db.User
                          where user.Username.Equals(username) && user.Password.Equals(hash)
                          select new
                          {
                              user.Access
                          };
                return res.ToString();
            }
        }

        public void Create(string username, string hash, string Access)
        {

            using (UserDbContext db = new UserDbContext())
            {
                User user = new User();
                user.Username = username;
                user.Password = hash;
                user.Access = Access;
                db.User.Add(user);
                db.SaveChanges();
            }
        }
        public bool isAdded(string username)
        {
                using (UserDbContext db = new UserDbContext())
                {
                    var res = from user in db.User
                              where user.Username.Equals(username)
                              select new
                              {
                                  user.ID
                              };
                    if (res != null)
                    {
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
