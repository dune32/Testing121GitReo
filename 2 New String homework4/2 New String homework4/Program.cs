using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace _2_New_String_homework4
{


    //{x} Create a function that takes a string and returns a new string
    //{x} First and last characters swapped
    //{x} except under two conditions: If the length of the string is less than two, return "Incompatible.".
    //{x} If the first and last characters are the same, return "Two's a pair.".






    //public class Program




    // public static string first_last(string str)

    // {
    //    return str.Length > 1 ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) +
    //         str.Substring(0, 1) : str;
    //   }

    //        public static void Main(string[] args)
    //     {

    //         Console.WriteLine(first_last(""));
    //         Console.WriteLine(first_last(""));
    //        Console.WriteLine(first_last(""));



    //       Console.ReadKey();

    //    }
    //   }
    // } 

    public class Program
    {
        public static string FlipEndChars(string s)
        {
            if (s.Length < 2)
            {
                return "Incompatible.";
            }

            // Check if the first and last characters are the same
            if (s[0] == s[s.Length - 1])
            {
                return "Two's a pair.";
            }

            // Swap the first and last characters
            char firstChar = s[0];
            char lastChar = s[s.Length - 1];

            // Return the new string with swapped characters
            return lastChar + s.Substring(1, s.Length - 2) + firstChar;
        }

        public static void Main()
        {
            Console.WriteLine(FlipEndChars("Cat, dog, and mouse.")); // ➞ ".at, dog, and mouseC"
            Console.WriteLine(FlipEndChars("ada"));                 // ➞ "Two's a pair."
            Console.WriteLine(FlipEndChars("Ada"));                 // ➞ "adA"
            Console.WriteLine(FlipEndChars("z"));                   // ➞ "Incompatible."
        }
    }
}