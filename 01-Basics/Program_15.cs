using System;

/* Mövzu: Compound Assignment / Multiplication */

namespace MyFirstProgram
{
    internal class Program_15
    {
        public static void Run()
        {
            int friends = 5;

            friends = friends * 2;
            friends *= 2;

            Console.WriteLine(friends);

            Console.ReadKey();
        }
    }
}
