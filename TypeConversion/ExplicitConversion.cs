using System;

namespace TypeConversion
{
    public class ExplicitConversion
    {
        public static void Run()
        {
            double price = 999.99;

            int amount = (int)price;

            Console.WriteLine("Double Value : " + price);
            Console.WriteLine("Integer Value: " + amount);
        }
    }
}