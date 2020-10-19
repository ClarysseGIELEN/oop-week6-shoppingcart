using System;
using System.Collections;
using System.Collections.Generic;

namespace oop_week6_shoppingcart
{
    class Program
    {
        static void Main(string[] args)
        {

                //The shop decides to introduce 2 new offers
                //Buy one, get one free on Apples
                //3 for price of 2 on Oranges
                //And it adds two new item s
                //Bananas for 15 cent a banana
                //Chair for 25 euro -- > would be weird to add it as a fruit

            Fruit apple = new Fruit(0.6);
            Fruit orange = new Fruit(0.25);
            Fruit banana = new Fruit(0.15);
            Objet chair = new Objet(25);
            ArrayList liste = new ArrayList();
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
