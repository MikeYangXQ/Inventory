using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDatabase.Entity
{
    class User
    {
        public long UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime DateAdded { get; set; }
        public long AddedBy { get; set; }
    }
}
