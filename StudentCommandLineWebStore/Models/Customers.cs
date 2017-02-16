using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentCommandLineWebStore.Models.Types;

namespace StudentCommandLineWebStore.Models
{
    class Customers
    {
        public static List<Customer> All = new List<Customer>
        {
            new Customer()
            {
                ID = 1,
                Name = "Billy Bob",
                EmailAddress = "bbthorten@gmail.com",
                BillingAddress = null,
                ShippingAddresses = null,
                OrderHistory = null
            },
            new Customer()
            {
                ID = 2,
                Name = "Peter Parker",
                EmailAddress = "spidy87@aol.com",
                BillingAddress = Addresses.All[0],
                ShippingAddresses = new HashSet<Address>() {Addresses.All[0]},
                OrderHistory = new HashSet<Order>() {Orders.All[2]}
            },
            new Customer()
            {
                ID = 3,
                Name = "Dante",
                EmailAddress = "rebel@hotmail.com",
                BillingAddress = Addresses.All[1],
                ShippingAddresses = new HashSet<Address>() {Addresses.All[1], Addresses.All[3]},
                OrderHistory = new HashSet<Order>() {Orders.All[1]}
            },
            new Customer()
            {
                ID = 4,
                Name = "David Bowie",
                EmailAddress = "stardust@yahoo.com",
                BillingAddress = Addresses.All[2],
                ShippingAddresses = new HashSet<Address>() {Addresses.All[4]},
                OrderHistory = new HashSet<Order>() {Orders.All[3], Orders.All[4]}
            }
        };
    }
}
