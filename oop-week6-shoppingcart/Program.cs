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
                //Chair for 25 euro 
                //Create an interface for the coupon thing

            Product apple = new Product("Apple",0.6);
            Product orange = new Product("Orange",0.25);
            Product banana = new Product("Banana",0.15);
            Product chair = new Product("Chair", 25);

            Cart cart = new Cart();
            cart.Add(apple);
            cart.Add(apple);
            cart.Add(apple);
            cart.Add(orange);

            double total = cart.Checkout();
            Console.WriteLine(total);

        }
    }
}
