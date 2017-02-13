using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentCommandLineWebStore.Models.Types;

namespace StudentCommandLineWebStore.Models
{
    class Addresses
    {
        public static List<Address> All = new List<Address>
        {
          new Address()
          {
              ID = 1,
              StreetName = "97628 Westend Court",
              City = "Pueblo",
              State = "Colorado",
              ZipCode = "81005", 
              Country = "United States"
          },
          new Address()
          {
              ID = 2,
              StreetName = "0212 Aberg Junction",
              City = "Richmond",
              State = "Virginia",
              ZipCode = "23285",
              Country = "United States"
          },
          new Address()
          {
              ID = 3,
              StreetName = "5 Dapub Street",
              City = "Columbia",
              State = "South Carolina",
              ZipCode = "29220",
              Country = "United States"
          },
          new Address()
          {
              ID = 4,
              StreetName = "92 Nova Port",
              City = "Sacromento",
              State = "California",
              ZipCode = "958865",
              Country = "United States"
          },
            new Address()
          {
              ID = 5,
              StreetName = "93665 Sugar Place",
              City = "Seattle",
              State = "Washington",
              ZipCode = "98133",
              Country = "United States"
          }
        };
    }
}
