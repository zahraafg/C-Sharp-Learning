using System;

/* Mövzu: String Methods / ToLower() */

namespace MyFirstProgram
{
    internal class Program_30
    {
        public static void Run()
        {
            /* ToLower()
            Hamısını kiçik hərfə çevirir. */

            string fullName = "Zahra Yaghoubi";

            fullName = fullName.ToLower();

            Console.WriteLine(fullName);

            Console.ReadKey();
        }
    }
}
