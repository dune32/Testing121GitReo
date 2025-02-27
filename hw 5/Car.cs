using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HW_problem_1
  public class Car : Vehicle
{
    public int NumberOfDoors { get; set; } // Property for number of doors

    // Constructor for Car class
    public Car(int numberOfDoors, string make, string model, int year)
        : base(make, model, year) // Calling the base class constructor
    {
        NumberOfDoors = numberOfDoors;
    }

    // Override ToString method
    public override string ToString()
    {
        return $"{Year} {Make} {Model} with {NumberOfDoors} doors.";
    }
}
