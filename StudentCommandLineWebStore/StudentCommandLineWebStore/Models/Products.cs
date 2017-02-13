using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentCommandLineWebStore.Models.Types;

namespace StudentCommandLineWebStore.Models
{
    class Products
    {
        public static List<Product> All = new List<Product>
        {
            new Product()
            {
                ID = 1,
                Quantity = 100,
                Name = "Potion",
                Description = "Heals 30 HP",
                Weight = 0.5F,
                Height = 6F,
                Length = 2.5F,
                Width = 2.5F,
                Price = 5.5M
            },
            new Product()
            {
                ID = 2,
                Quantity = 100,
                Name = "Phoenix Down",
                Description = "Revives one party member from death, 0 HP",
                Weight = 0.5F,
                Height = 6F,
                Length = 3.5F,
                Width = 1.5F,
                Price = 10.5M
            },
            new Product()
            {
                ID = 3,
                Quantity = 0,
                Name = "Ether",
                Description = "Recovers 30 MP",
                Weight = 0.8F,
                Height = 5F,
                Length = 2.5F,
                Width = 3.5F,
                Price = 7.5M
            },
            new Product()
            {
                ID = 4,
                Quantity = 100,
                Name = "Hi-Potion",
                Description = "Heals 60 HP",
                Weight = 1.5F,
                Height = 6F,
                Length = 2.5F,
                Width = 2.5F,
                Price = 12.5M
            }
        };
    }
}
