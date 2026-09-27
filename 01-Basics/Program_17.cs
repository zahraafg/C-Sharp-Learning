using System;

namespace MyFirstProgram
{
    internal class Program_17
    {
        public static void Run()
        {
            int friends = 10;

            friends = friends % 3;
            friends %= 3;

            Console.WriteLine(friends);

            Console.ReadKey();
        }
    }
}
