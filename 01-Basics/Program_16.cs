using System;

/* Mövzu: Compound Assignment / Division */

namespace MyFirstProgram
{
    internal class Program_16
    {
        public static void Run()
        {
            double friends = 5;

            friends = friends / 2;
            friends /= 2;

            Console.WriteLine(friends);

            Console.ReadKey();
        }
    }
}
