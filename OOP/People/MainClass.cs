/*
James Patterson
C# Main Class -> People Class -> IPeople, PeopleFunctions
                      -> Male, Female
*/
using System;

namespace People
{
    class MainClass : People
    {
        public static void Main(string[] args)
        {
            People james = new Male(0, "James Patterson", 32);

            People stephanie = new Female(1, "Stephanie Swift", 22);

            james.PrintInformation();

            stephanie.PrintInformation();

            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }
    }
}
