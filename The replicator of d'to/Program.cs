using System.Globalization;
using System.Reflection;

namespace The_replicator_of_d_to
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5];
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write("Enter number: ");
                int value = Convert.ToInt32(Console.ReadLine());
                number[i] = value;
            }
            int [] copy = new int[5];
            
           for (int i = 0; i < number.Length;i++)
           copy[i] = number[i];

           for (int i = 0; i < number.Length; i++)
           Console.WriteLine(number[i]);
            
           for (int i = 0; i < copy.Length; i++)
           Console.WriteLine(copy[i]);
            }
        }
    }

