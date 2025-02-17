using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss_Battle_Hunting_the_Manticore
{
    public class Program
    {
        static void Main(string[] args)
        {
            Manitcore man1 = new Manitcore(10,1,1);
            {
        




            }

            Consalsa



            Console.WriteLine("The Manticore is approaching! Type 1 to engage? To run away from the city type 2 to disengage.");
            string userChoice = Console.ReadLine(); // stores as a string

            Rand1 rand1 = new Rand1();
            // this initiates the constructor in the console don't forget to do it. 



            if (userChoice == "1")
            {
                Console.WriteLine("Ready the soldiers! Press any key to continue...");
                Console.Clear();

                Console.WriteLine("The Manticore is approaching" + "the Manticore is :" + rand1.RandomValue + "Units away" + " Fire the cannons! " + "\n" + "Press any key to continue.");
                //so you need lower case to access gets and sets.



            else if (userChoice == "2")
            {
                Console.WriteLine("Consala has fallen you have lost the game.");
                    Console.ReadKey();
                    else
                    {
                        // If the input is not valid (neither 1 nor 2)
                        Console.WriteLine("Invalid choice. Please type 1 to engage or 2 to disengage.");
                        Console.ReadKey();
                    }

                    while (consalsa.healthPoints && manticore.healthPoints > 0)
                    {
            
                   
              
                    
                    
                    
                    
                    }

            }
                Console.WriteLine("The Manticore has been defeated.");
            }
    }
}