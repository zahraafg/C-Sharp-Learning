using System;

/* Mövzu: Random */

namespace MyFirstProgram
{
    internal class Program_26
    {
        public static void Run()
        {
            Random random = new Random();

            int num = random.Next(1, 25);

            Console.WriteLine(num);

            Console.ReadKey();
        }
    }
}
