using System;

/* Mövzu: Math.Max() */

namespace MyFirstProgram
{
    internal class Program_24
    {
        public static void Run()
        {
            // Max: İki ədəddən böyük olanı qaytarır.
            double num1 = 10.9;
            double num2 = 20.1;

            double num3 = Math.Max(num1, num2);

            Console.WriteLine(num3);


            /* double g = Math.Max(10.9, 20.1);
            Console.WriteLine(g);

            int G = Math.Max(10, 20);
            Console.WriteLine(G);  */

            Console.ReadKey();
        }
    }
}
