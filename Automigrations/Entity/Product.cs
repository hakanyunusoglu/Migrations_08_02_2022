using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Automigrations.Entity
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public int QuantityPerUnit { get; set; }
    }
}