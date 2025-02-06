// write a program that will loop through the values between and display what kind of blast the crew should expect. (The operator may be of use)
// Change the color of the output based on the type of blast. (Console.ForegroundColor)



using System;

class Program
{
    static void Main()
    {
        string type;
        ConsoleColor color;

        for (int number = 1; number <= 100; number++)
        {
            if (number % 5 == 0 && number % 3 == 0) 
            {
                type = "Electric and Fire";
                color = ConsoleColor.Cyan;
            }
            else if (number % 5 == 0) 
            {
                type = "Electric";
                color = ConsoleColor.Yellow;
            }
            else if (number % 3 == 0) // 
            {
                type = "Fire";
                color = ConsoleColor.Red;
            }
            else 
            {
                type = "Normal";
                color = ConsoleColor.Gray;
            }

            // Set the text color
            Console.ForegroundColor = color;

            Console.WriteLine($"{number}: {type}");
        }

       
        Console.ResetColor();
    }
}