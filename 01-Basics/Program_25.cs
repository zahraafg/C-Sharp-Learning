using System;

/* Mövzu: Math.Min() */

namespace MyFirstProgram
{
    internal class Program_25
    {
        public static void Run()
        {
            // Min: İki ədəddən kiçik olanı qaytarır.
            double num1 = 10.9;

            double num2 = 20.1;

            double num3 = Math.Min(num1, num2);

            Console.WriteLine(num3);

            
            
            /* double h = Math.Min(10.9, 20.1);
            Console.WriteLine(h);

            int H = Math.Min(10, 20);
            Console.WriteLine(H);  */

            Console.ReadKey();
        }
    }
}
