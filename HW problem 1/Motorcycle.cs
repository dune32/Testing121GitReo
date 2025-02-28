using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_problem_1
{
    public class Motorcycle : Vehicle
    {

        //var for sidecare
        private bool hasSideCar = false;


        //Get and set for sidecar

        public bool HasSideCar
        {
            get { return hasSideCar; }
            set { hasSideCar = value; }
        }

        public Motorcycle(bool ahasSideCar, string amake, string amodel, int ayear) // the motorcycles new constructor 
            : base(amake, amodel, ayear) // Calling the base class constructor
        {
            this.hasSideCar = ahasSideCar;
            this.Make = amake;
            this.Model = amodel;
            this.Year = ayear;
        }


        public override string ToString() // override to string
        {
            string message = "";
            message += $"{Year} {Make} {Model} (Has Sidecar: {HasSideCar}).";
            return message;
        }





    }
}
