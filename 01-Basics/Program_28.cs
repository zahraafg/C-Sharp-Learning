using System;

/* Mövzu: Pythagorean Theorem / Math.Sqrt() */

namespace MyFirstProgram
{
    internal class Program_28
    {
        public static void Run()
        {
            Console.WriteLine("Enter side A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("The hypotenuse is: " + c);

            Console.ReadKey();
        }
    }
}
