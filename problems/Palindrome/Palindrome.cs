using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class PalindromeClass
    {
        public static bool IsPalindrome(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if(char.ToLower(word[i]) == char.ToLower(word[word.Length-1]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(PalindromeClass.IsPalindrome("Deleveled"));
            Console.WriteLine(PalindromeClass.IsPalindrome("Releveled"));
            Console.WriteLine(PalindromeClass.IsPalindrome("Hannah"));

            Console.ReadLine();
        }
    }
}
