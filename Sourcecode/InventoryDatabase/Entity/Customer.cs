using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDatabase.Entity
{
    class Customer
    {
        public long CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public bool IsRegular { get; set; }
        public bool IsDiscount { get; set; }
        public bool IsLive { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime DateAdded { get; set; }
        public long AddedBy { get; set; }
    }
}
