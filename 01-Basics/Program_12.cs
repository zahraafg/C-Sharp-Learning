using System;

/* Mövzu: User Input */

namespace MyFirstProgram
{
    internal class Program_12
    {
        public static void Run()
        {
            // user input
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();


            Console.WriteLine("What's your age?");
            int age = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Hello " + name);
            Console.WriteLine("You are " + age + " years old.");

            Console.ReadKey();
        }
    }
}
