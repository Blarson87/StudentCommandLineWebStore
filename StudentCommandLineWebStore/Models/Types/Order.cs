using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCommandLineWebStore.Models.Types
{
    class Order
    {
        public int ID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ShipDate
        {
            get
            {
                return _shipDate;
            }
            set
            {
                if (!OrderDate.HasValue || !value.HasValue)
                {
                    throw new NullReferenceException("Order date and ship date required!");
                }
                
                if (OrderDate > value)
                {
                    throw new FormatException("Order date cannot be earlier than ship date!");
                }

                _shipDate = value;
            }
        }

        public enum Statuses
        {
            Cart,
            Ordered,
            Shipped
        }

        public Dictionary<Product, int> Products
        {
            get
            {
                return _products;
            }
        }

        private DateTime? _shipDate;
        private Dictionary<Product, int> _products;

        public Order() { }

        public void AddProduct(Product product)
        {
            if(product.Quantity == 0)
            {
                return;
            }
                
            if (_products.ContainsKey(product))
            {
                _products[product]++;
            }
            else
            {
                _products.Add(product, 1);
            }

            product.Quantity--;
        }
        
        public Statuses GetStatus()
        {
            Statuses current;

            if(!OrderDate.HasValue && !ShipDate.HasValue)
            {
                current = Statuses.Cart;
            }
            else if( OrderDate.HasValue && !ShipDate.HasValue)
            {
                current = Statuses.Ordered;
            }
            else
            {
                current = Statuses.Shipped;
            }

            return current;
        }


    }
}
