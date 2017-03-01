using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentCommandLineWebStore.Models;
using StudentCommandLineWebStore.Models.Types;

namespace StudentCommandLineWebStore.Services
{
    class LoginService
    {
        public static bool Check(string email)
        {
            return Customers.All.Where(c => c.EmailAddress == email).Count() == 1;
        }

        public static Customer GetCustomer(string email)
        {
            return Customers.All.FirstOrDefault(c => c.EmailAddress == email);
        }
    }
}
