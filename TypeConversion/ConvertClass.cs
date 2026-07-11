using System;

namespace TypeConversion
{
    public class ConvertClassExample
    {
        public static void Run()
        {
            Console.Write("Enter First Number : ");
            string num1 = Console.ReadLine();

            Console.Write("Enter Second Number : ");
            string num2 = Console.ReadLine();

            int first = Convert.ToInt32(num1);
            int second = Convert.ToInt32(num2);

            int sum = first + second;

            Console.WriteLine("Sum = " + sum);
        }
    }
}