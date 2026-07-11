using System;

namespace TypeConversion
{
    public class ImplicitConversion
    {
        public static void Run()
        {
            int number = 100;

            double value = number;

            Console.WriteLine("Integer Value : " + number);
            Console.WriteLine("Double Value  : " + value);
        }
    }
}