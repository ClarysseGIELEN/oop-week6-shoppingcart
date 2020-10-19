using System;
using System.Collections.Generic;

namespace oop_week6_shoppingcart
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit apple = new Fruit(0.6);
            Fruit orange = new Fruit(0.25);
            List<Fruit> liste = new List<Fruit>();
            liste.Add(apple);
            liste.Add(apple);
            liste.Add(apple);
            liste.Add(orange);


            //Check-out
            double total = 0;
            foreach (Fruit fruit in liste)
            {
                total = total + fruit.Cost;
            }
            Console.WriteLine(total);

        }
    }
}
