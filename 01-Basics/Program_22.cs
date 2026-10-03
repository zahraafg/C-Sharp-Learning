using System;

/* Mövzu: Math.Floor() */

namespace MyFirstProgram
{
    internal class Program_22
    {
        public static void Run()
        {
            // Floor: Ədədi aşağı doğru tam ədədə yuvarlaqlaşdırır.
            double num1 = 4.9;

            double num2 = Math.Floor(num1);

            Console.WriteLine(num2);


            /* double e = Math.Floor(4.9);
            Console.WriteLine(e);  */

            Console.ReadKey();
        }
    }
}
