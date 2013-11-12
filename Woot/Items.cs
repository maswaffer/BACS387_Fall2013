using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Woot
{
    class Items
    {
        public Guid Id { get; set; }
        public decimal? ListPrice { get; set; }
        public int PurchaseLimit { get; set; }
        public decimal? SalePrice { get; set; }
        public List<Attribute> Attributes { get; set; }
    }
}
