using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentCommandLineWebStore.Models.Types;

namespace StudentCommandLineWebStore.Models
{
    class Orders
    {
        public static List<Order> All = new List<Order>
        {
            new Order()
            {
                ID = 1,
                OrderDate = null,
                ShipDate = null
            },
            new Order()
            {
                ID = 2,
                OrderDate = new DateTime(2017, 1, 16),
                ShipDate = null
            },
            new Order()
            {
                ID = 3,
                OrderDate = new DateTime(2016, 12, 23),
                ShipDate = new DateTime(2016, 12, 26)
            },
            new Order()
            {
                ID = 4,
                OrderDate = null,
                ShipDate = new DateTime(2012, 11, 11)
            }
        };

        public static void Init()
        {
            All[0].AddProduct(Products.All[0]);
            All[0].AddProduct(Products.All[0]);
            All[0].AddProduct(Products.All[0]);
        }
    }
}
