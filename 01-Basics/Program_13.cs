using System;

namespace MyFirstProgram
{
    internal class Program_13
    {
        public static void Run()
        {
            int friends = 5;

            friends = friends + 1;
            friends += 1;
            friends++;

            Console.WriteLine(friends);

            Console.ReadKey();
        }
    }
}
