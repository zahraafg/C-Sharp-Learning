using System;

/* Mövzu: Math.Pow() */

namespace MyFirstProgram
{
    internal class Program_19
    {
        public static void Run()
        {
            // Pow: Ədədi qüvvətə yüksəldir.
            double num1 = 3;

            double num2 = Math.Pow(num1, 2);

            Console.WriteLine(num2);


            /* double b = Math.Pow(2, 3); // 2^3 = 8
            Console.WriteLine(b);  */

            Console.ReadKey();
        }
    }
}
