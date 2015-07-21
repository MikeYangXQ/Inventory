using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDatabase.Entity
{
    class Product
    {
        public long ProductID { get; set; }
        public string Name { get; set; }
        public long CategoryID { get; set; }
        public long SupplierID { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime AddedDate { get; set; }
        public long AddedBy { get; set; }
    }
}
