using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Shapes_and_Areas
{

    using System;

    public abstract class Shape
    {
        public string Name { get; set; }

        // Constructor that accepts a parameter 'ashape'
        public Shape(string ashape)
        {
            this.Name = ashape;
        }

        // Virtual method for area, can be overridden in subclasses
        public virtual double GetArea() => 0; // Default implementation (returns 0)

        // Virtual method for volume, can be overridden in subclasses
        public virtual double GetVolume() => 0; 



        static void Main(string[] args)
        {


            Shape2D square = new Square("Square", 5);

        }

    }
}