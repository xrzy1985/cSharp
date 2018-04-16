using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // String builder is for when you want to edit a string without creating a new one

            StringBuilder sb = new StringBuilder();

            // this will append the string we write onto sb, which is empty at the moment
            sb.Append("This is the first sentence. ");

            // sb.AppendLine() will add a new line at the end of the append statement

            // this will format the string I'm going to append to sb
            sb.AppendFormat("My name is {0} and I live in {1}.", "James", "Georgia");

            Console.WriteLine(sb.ToString());

            // we can replace Replace(stringToReplace, stringToReplaceWith)
            sb.Replace("a", "e");

            Console.WriteLine(sb.ToString());

            // Remove(startingIndex, howManySpacesToRemove)
            sb.Remove(5, 8);

            Console.WriteLine(sb.ToString());

            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();

        }
    }
}
