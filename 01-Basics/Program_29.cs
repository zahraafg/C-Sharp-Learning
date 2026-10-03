using System;

/* Mövzu: String Methods / ToUpper() */

namespace MyFirstProgram
{
    internal class Program_29
    {
        public static void Run()
        {
            /* ToUpper()
            Hamısını böyük hərfə çevirir. */ 

            string fullName = "Zahra Yaghoubi";
            
            fullName = fullName.ToUpper();

            Console.WriteLine(fullName);

            Console.ReadKey();  
        }
    }
}
