using System;
using System.Collections.Generic;
using System.Text;

namespace oop_week6_shoppingcart
{
    public class Cart
    {
        List<Product> cart { get; set; }
        public Cart()
        {
            this.cart = new List<Product>();
        }

        public void Add(Product product)
        {
            cart.Add(product);
        }

        public double Checkout()
        {
            double total = 0;
            foreach(Product prod in cart)
            {
                total = total + prod.Cost;
            }
            return total;
        }
    }
}
