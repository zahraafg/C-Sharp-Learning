using System;

namespace MyFirstProgram
{
    internal class Program_18
    {
        public static void Run()
        {
            // Abs: Mənfi ədədi müsbət edir, yəni mütləq qiyməti qaytarır.
            double num1 = -3;

            double num2 = Math.Abs(num1);

            Console.WriteLine(num2);

           
           /* double num3 = Math.Abs(-3.4);
            Console.WriteLine(num3);  */

           /* int num4 = Math.Abs(-3);
            Console.WriteLine(num4);  */

            Console.ReadKey();
        }
    }
}
