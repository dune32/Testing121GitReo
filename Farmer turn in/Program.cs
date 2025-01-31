// Program to solve area = Base * height / 2

using System;
//Don't delete system lol

class Program


//Class we define different functions?
{
    static void Main()
    {
        //This is where I put the actaul code got it!
        // Asking for the base of the triangle
        Console.WriteLine("What is the length of the base of the triangle?");
        string lengthText = Console.ReadLine();

        // Convert the base length to a double
        double length = Convert.ToDouble(lengthText);

        // Asking for the height of the triangle
        Console.WriteLine("What is the height of the triangle?");
        string heightText = Console.ReadLine();

        // Convert the height to a double
        double height = Convert.ToDouble(heightText);
        //So ya we have to make this only accept text so lets try and make it reject anything else.

        // Calculate the area
        double area = length * height / 2;

        // Output the area
        Console.WriteLine("The area of the triangle is: " + area);
    }
}
