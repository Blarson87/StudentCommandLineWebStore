using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentCommandLineWebStore.Models.Types;
using StudentCommandLineWebStore.Models;

namespace StudentCommandLineWebStore
{
    class Program
    {
        public static void Main()
        {
            string logInEmail = null;
            Customer guest = new Customer();

            Console.WriteLine("Welcome, please type your email address to log in.");
            logInEmail = Console.ReadLine();

            guest.LogInCheck(logInEmail);

        }
    }
}
