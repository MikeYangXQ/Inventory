using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDatabase.Entity
{
    class SalesOrder
    {
        public long SalesOrderID { get; set; }
        public long CustomerID { get; set; }
        public double TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalPaid { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime AddedDate { get; set; }
        public long AddedBy { get; set; }
    }
}
