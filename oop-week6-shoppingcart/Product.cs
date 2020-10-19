using System;
using System.Collections.Generic;
using System.Text;

namespace oop_week6_shoppingcart
{
    public  class Product
    {
        public double Cost { get; set; }
        public string Name { get; set; }

        public Product(string name, double cost)
        {
            Cost = cost;
            Name = name;
        }

    }
}
