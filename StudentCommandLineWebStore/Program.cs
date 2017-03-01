using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentCommandLineWebStore.Models.Types;
using StudentCommandLineWebStore.Services;

namespace StudentCommandLineWebStore
{
    class Program
    {
        public static void Main()
        {
            string logInEmail = null;
            bool firstLogin = true;

            Console.WriteLine("Welcome, please type your email address to log in.");
            
            do
            {
                if (!firstLogin)
                {
                    Console.WriteLine("try again");
                }
                logInEmail = Console.ReadLine();
                firstLogin = false;
            } while (!LoginService.Check(logInEmail));

            Customer currentCustomer = LoginService.GetCustomer(logInEmail);
            Console.WriteLine();
            Console.WriteLine(string.Format("Welcome {0}!", currentCustomer.Name));

            string customerSelection = null;

            do
            {
                DisplayMenu();
                customerSelection = Console.ReadLine();
                if (customerSelection == "6")
                {
                    break;
                }
                
                switch (customerSelection)
                {
                    case "1":
                        PlaceOrder();
                        break;
                    case "2":
                        CheckHistory();
                        break;
                    case "3":
                        AddShipping();
                        break;
                    case "4":
                        RemoveShipping();
                        break;
                    case "5":
                        ChangeBilling();
                        break;
                    default:
                        break;                    
                }

            } while (customerSelection != "6");
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Place Order");
            Console.WriteLine("2) Check History");
            Console.WriteLine("3) Add Shipping Address");
            Console.WriteLine("4) Remove Shipping Address");
            Console.WriteLine("5) Change Billing Address");
            Console.WriteLine("6) Quit~");
        }

        public static void PlaceOrder()
        {
            int selection = 0;
            int quantity = 0;
            bool correctType = false;

            while (!correctType)
            {
                Console.WriteLine("What would you like to order?");
                Console.WriteLine("1) Potion 2) Phoenix Down 3) Ether 4) Hi-potion");
                correctType = int.TryParse(Console.ReadLine(), out selection);
                correctType = correctType && (selection >= 1) && (selection <= 4);
            }

            correctType = false;

            Product itemSelected = ProductService.GetProduct(selection);
            Console.WriteLine("*" + itemSelected.Name + "*");
            Console.WriteLine("*" + itemSelected.Description + "*");
            Console.WriteLine("Amount is stock *" + itemSelected.Quantity + "*");

            while (!correctType)
            {
                Console.WriteLine("How Many?");
                correctType = int.TryParse(Console.ReadLine(), out quantity);

                decimal purchaseCost = quantity * itemSelected.Price;

                if (itemSelected.Quantity - quantity >= 0)
                {
                    itemSelected.Quantity = itemSelected.Quantity - quantity;
                    Console.WriteLine(string.Format("Thank you, this will cost {0} there are {1} left in stock", purchaseCost, itemSelected.Quantity));
                }
                else
                {
                    Console.WriteLine("Not enough in stock, please try again");
                }
            }
        }

        public static void CheckHistory()
        {

        }

        public static void AddShipping()
        {

        }

        public static void RemoveShipping()
        {

        }

        public static void ChangeBilling()
        {

        }
    }
}
