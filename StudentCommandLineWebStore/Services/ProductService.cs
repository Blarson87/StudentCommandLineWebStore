using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentCommandLineWebStore.Models;
using StudentCommandLineWebStore.Models.Types;

namespace StudentCommandLineWebStore.Services
{
    class ProductService
    {
        public static Product GetProduct( int id)
        {
            return Products.All.FirstOrDefault(p => p.ID == id);
        }
    }
}
