using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCommandLineWebStore.Models.Types
{
    class Customer
    {
        public int ID { get; set; } 
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public Address BillingAddress { get; set; }
        public HashSet<Address> ShippingAddresses { get; set; }
        public HashSet<Order> OrderHistory { get; set; }

        public Customer() { }

        
    }
}
