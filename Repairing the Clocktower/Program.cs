using System;


namespace Repairing_the_Clocktower

{
    class Program
    {
        static void Main() // Without this if statements and remainder function don't work?
        {
            // [x] Take a number as input from the console
            // [x] Display the word "Tick" if the number is even. Display the word "Tock" if the number is odd/


            Console.WriteLine("Enter the number: ");



            int number = Convert.ToInt32(Console.ReadLine());
            int remainder = number % 2;


            if (remainder == 0)
                Console.WriteLine("Tick");
            else Console.WriteLine("Tock");







        }
    }
}
