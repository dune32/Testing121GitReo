using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss_Battle_Hunting_the_Manticore
{
    public class FireCannonR
    {

        public int RandomValue { get; }  // Aw this is part of the getting the random value set tools. 

        public FireCannonR() // hmm what we call this?
        {
            Random random = new Random();  // modifies the FireCannonR 
            RandomValue = random.Next(0, 101);// ok so this didn't work how I thought at all. so this defines the FireCannonR and sets it as an instance of RandomValue. 
            //We call the tool package of System class of Random.

        }






    }
}