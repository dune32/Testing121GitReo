using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace HUNTING_THE_MANIITCORE
{
    public class Program
    {
        
        public static void Main(string[] args)
        {

            int manticoreHealth = 10;
            int cityHealth = 15;
            int roundNumber = 1;

          
            int distanceToCity = PromptForNumber("Player 1, how far away from the city do you want to station the Manticore?");

            Console.Clear();



            Console.WriteLine("Player 2 it's your turn.");



            while (cityHealth > 0 && manticoreHealth > 0) // && always after zero
            {
                
                ColoredWriteLine("---------------------------", ConsoleColor.Yellow);
                Console.Write($"Status: Round: {roundNumber} City : {cityHealth} /15 Manticore: {manticoreHealth} /10"); // the money symbol lets us input vars?

                // The dollar tells the compiler. This string contains placeholders.

                int expectedDamage = ComputeExpectedDamage(roundNumber);
                Console.WriteLine($" The cannon is expected to deal {expectedDamage} damage this round.");
                Console.WriteLine(($" The cannon is expected to deal {ComputeExpectedDamage(roundNumber + 1)} damage next round."));


                int targetRange = PromptForNumber(" Enter desired cannon range:  ");

                void ColoredWriteLine (string text, ConsoleColor color)
                {
                    Console.ForegroundColor = color;
                    Console.WriteLine(text);




                }



              DisplayAttackResults(targetRange, distanceToCity);

                if (targetRange == distanceToCity)
                    manticoreHealth -= expectedDamage;

                roundNumber++;
            }
            if (manticoreHealth <= 0 && cityHealth > 0) Console.WriteLine("The manticore has fallen! Consalsa is saved. ");
            else if (cityHealth <= 0) Console.WriteLine("The world has ended consalsa has fallen! Game over ");

            void DisplayAttackResults(int target, int actaul)
            {

                if (target == actaul)
                    Console.WriteLine("That was a hit!");

                if (target <  actaul)
                    Console.WriteLine("That was an overshot!");
                if (target >  actaul) Console.WriteLine("You undershot!");

                if (manticoreHealth > 0) cityHealth--;



            }

            int ComputeExpectedDamage(int round)
            {


                bool isMultipleOfFive = round % 5 == 0;
                bool isMultipleOfThree = round % 3 == 0;

                if (isMultipleOfFive && isMultipleOfThree) return 10;
                if (isMultipleOfFive) return 3;
                if (isMultipleOfThree) return 3;

                return 1;



            }
            int PromptForNumber(string message)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(message);
                return Convert.ToInt32(Console.ReadLine());


            }

        }
    } }
