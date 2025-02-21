using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ChangeAll
{
    public static string Move(string s)
    {
        string change = "";

        foreach (char c in s)
        {
            // Shift each letter by 1
            change += (char)(c + 1);
        }

        return change;
    }

    public static void Main()
    {
        Console.WriteLine(Move("hello"));    // ➞ "ifmmp"
        Console.WriteLine(Move("bye"));      // ➞ "czf"
        Console.WriteLine(Move("welcome"));  // ➞ "xfmdpnf"
    }
}
