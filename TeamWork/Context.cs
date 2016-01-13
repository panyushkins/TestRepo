using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamWork
{
    class Context : DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<University> Universities { get; set; }
    }
}
