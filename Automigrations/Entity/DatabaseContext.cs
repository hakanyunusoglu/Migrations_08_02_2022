using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Automigrations.Entity
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext():base("DatabaseContext")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

    }
}