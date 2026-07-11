using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== TYPE CONVERSION IN C# =====");

            Console.WriteLine("\n1. Implicit Conversion");
            ImplicitConversion.Run();

            Console.WriteLine("\n2. Explicit Conversion");
            ExplicitConversion.Run();

            Console.WriteLine("\n3. Convert Class");
            ConvertClassExample.Run();

            Console.WriteLine("\n4. Parse Method");
            ParseExample.Run();

            Console.WriteLine("\n5. TryParse Method");
            TryParseExample.Run();

            Console.WriteLine("\nProgram Completed Successfully.");
        }
    }
}