using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDatabase.Entity
{
    class Sales
    {
        public long SalesID { get; set; }
        public long SalesOrderID { get; set; }
        public long ProductID { get; set; }
        public long Quantity { get; set; }
        public double Price { get; set; }
        public double DiscountAvailed { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime AddedDate { get; set; }
        public long AddedBy { get; set; }
    }
}
