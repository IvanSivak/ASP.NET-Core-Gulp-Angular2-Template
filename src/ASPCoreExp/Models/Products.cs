using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreExp.ViewModel
{
    public class Products
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Decimal RetailPrice { get; set; }
        public int VATIndex { get; set; }
    }
}
