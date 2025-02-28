using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_problem_1
{ // Vehicle class} 
    public class Vehicle //base class
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle() { } // empty constructor
        public Vehicle(string make, string model, int year) // full constructor
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public override string ToString()
        {
            return $"{Year} {Make} {Model}";
        }


        static void Main(string[] args)

        { }
    }
}
        
        
    
       
