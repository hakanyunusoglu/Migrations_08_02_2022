using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstWithoutAutoMigration.Entity
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }

        ICollection<Product> Product { get; set; }
    }
}