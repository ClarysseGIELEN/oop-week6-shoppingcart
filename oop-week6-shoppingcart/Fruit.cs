using System;
using System.Collections.Generic;
using System.Text;

namespace oop_week6_shoppingcart
{
    public class Fruit : Product
    {
        public double Cost;
        //
        public Fruit(double cost)
        {
            this.Cost = cost;
        }
    }
}
