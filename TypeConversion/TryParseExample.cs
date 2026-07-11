using System;

namespace TypeConversion
{
    public class TryParseExample
    {
        public static void Run()
        {
            Console.Write("Enter a Number : ");

            string input = Console.ReadLine();

            bool result = int.TryParse(input, out int number);

            if (result)
            {
                Console.WriteLine("Valid Number : " + number);
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
}