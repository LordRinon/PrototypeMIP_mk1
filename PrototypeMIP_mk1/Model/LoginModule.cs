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
        EncryptionModule en = new EncryptionModule();

        public UserDbContext UserDbContext
        {
            get => default;
            set
            {
            }
        }

        public Controller.LoginController LoginController
        {
            get => default;
            set
            {
            }
        }

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
            using(KeyDbContext db = new KeyDbContext())
            {
                Tuple<string,string> t = en.GenKey();
                Keys keys = new Keys();
                keys.Access = Access;
                keys.key = t.Item1;
                keys.IV = t.Item2;
                db.Keys.Add(keys);
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
        public Tuple<string, string> GetKey(string access)
        {

            using (KeyDbContext db = new KeyDbContext())
            {
                string key = "d2MP7WO7NYdSE4l/dHcniyOMkW8w1Fy6RBwR/HhV9II=";
                string IV = "/xH6M0th/eE838EctFiEHg==";
                var res = from keys in db.Keys
                          where keys.Access == access
                          select new
                          {
                              key = keys.key,
                              IV = keys.IV
                          };
                return new Tuple<string, string>(key, IV);
            }
        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }
    }
}
