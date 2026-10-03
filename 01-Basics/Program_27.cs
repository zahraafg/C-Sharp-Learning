using System;

/* Random.NextDouble() */

namespace MyFirstProgram
{
    internal class Program_27
    {
        public static void Run()
        {
            Random random = new Random();

            double num = random.NextDouble();

            Console.WriteLine(num);

            Console.ReadKey();
        }
    }
}
