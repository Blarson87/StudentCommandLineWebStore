using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCommandLineWebStore.Models.Types
{
    class Product
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Weight { get; set; } //measured in Kg
        public float Height { get; set; } //measured in Centimeters
        public float Length { get; set; } //measured in Centimeters
        public float Width { get; set; } //measured in Centimeters
        public decimal Price { get; set; } // USD

        public Product() { }

        public override bool Equals(object obj)
        {
            if (obj is Product)
            {
                Product product = (Product)obj;
                return product.ID == ID;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return ID;
        }
    }
}
