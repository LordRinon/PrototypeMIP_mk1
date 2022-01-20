using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeMIP_mk1.Model.EF_DBContext
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Access { get; set; }
    }
    public class UserDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
    }
}
