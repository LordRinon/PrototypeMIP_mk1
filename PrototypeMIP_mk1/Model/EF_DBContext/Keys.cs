using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeMIP_mk1.Model.EF_DBContext
{
    public class Keys
    {
        [Key]
        public int ID { get; set; }
        public string Access { get; set; }
        public string key { get; set; }
        public string IV { get; set; }

    }
    public class KeyDbContext : DbContext
    {
        public DbSet<Keys> Keys { get; set; }
    }
}
