using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordcount_reader
{

    class Program
    {

        static int CountWords(string sentence)
        {
            // Initialize count to 1 assuming at least one word
          
            int count = 1;

            foreach (char character in sentence) //foreach better to use than for or while in this case. I didn't really get why char was a thing makes sense now.
            {
                if (character == ' ')
                {
                    count++;
                }
            }

            return count;
        }

        static void Main()
        {
            Console.WriteLine("Write a sentence");
            string sentence = Console.ReadLine();

            Console.WriteLine("Number of words: "
                              + CountWords(sentence));
        }
    }
}

