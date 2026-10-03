using System;

/* Mövzu: Math.Ceiling() */

namespace MyFirstProgram
{
    internal class Program_23
    {
        public static void Run()
        {
            // Ceiling: Ədədi yuxarı doğru tam ədədə yuvarlaqlaşdırır.
            double num1 = 4.1;

            double num2 = Math.Ceiling(num1);

            Console.WriteLine(num2);
            
            
            /* double f = Math.Ceiling(4.1);
            Console.WriteLine(f);  */

            Console.ReadKey();
        }
    }
}
