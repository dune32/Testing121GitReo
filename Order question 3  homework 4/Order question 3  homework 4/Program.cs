using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class InOrder
{
    public static bool IsInOrder(string str)
    {

        for (int i = 0; i < str.Length - 1; i++)
        {
            if (str[i] > str[i + 1])
            {
                return false;
            }
        }
        return true;
    }

    public static void Main()
    {

        Console.WriteLine(IsInOrder("abc"));    // Output: true
        Console.WriteLine(IsInOrder("edabit")); // Output: false
        Console.WriteLine(IsInOrder("123"));    // Output: true
        Console.WriteLine(IsInOrder("xyzz"));   // Output: true
    }
}