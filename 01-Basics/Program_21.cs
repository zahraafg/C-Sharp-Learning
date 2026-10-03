using System;

/* Mövzu: Math.Round() */

namespace MyFirstProgram
{
    internal class Program_21
    {
        public static void Run()
        {
            // Round: Ədədi ən yaxın tam ədədə yuvarlaqlaşdırır.
            double num1 = 4.567;

            double num2 = Math.Round(num1);

            Console.WriteLine(num2);


            
           /* double d = Math.Round(4.567, 2);
            Console.WriteLine(d);  */

            Console.ReadKey();
        }
    }
}
