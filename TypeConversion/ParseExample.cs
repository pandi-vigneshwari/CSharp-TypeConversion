using System;

namespace TypeConversion
{
    public class ParseExample
    {
        public static void Run()
        {
            Console.Write("Enter Your Age : ");

            string ageText = Console.ReadLine();

            int age = int.Parse(ageText);

            Console.WriteLine("Your Age is : " + age);
        }
    }
}