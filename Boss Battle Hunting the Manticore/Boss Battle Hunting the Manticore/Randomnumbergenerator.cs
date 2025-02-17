using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss_Battle_Hunting_the_Manticore
{
    public class Rand1
    {
        public int RandomValue { get; }  // so this holds the constructor or an empty constructor the get is set here I will test to see if it can be used at the end aswell later.
        //Can we use same naming squencing? 

        public Rand1() // empty constructor
        {
            Random random = new Random(); // we are defining the constructor of Random (wait it only uses first word for constructor? Weird) 

            RandomValue = random.Next(0,100); // RandomValue we are making a new instance. We are using the .Next method to establish our random number. 

        }






    }
}
