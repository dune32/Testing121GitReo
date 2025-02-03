using System;
using System.Runtime.CompilerServices;
// Expected results 
//Target row 6
//Target Colum 5
//Deploy to (6,4) (5,5)(6,6) and (7,5)
// [x] ASK user for the target row and column.
// [x] Compute the neighboring rows and colums of where to deply the squad.
// [] Display the deployment instructions in a different color of your choosing.
// [x] Change the window title to be "Defense of Consolas"
// [] Play a sound with Console.Beep when the results have been computed and displayed.


{
    Console.Title = "Defense of Consolas";

    Console.ForegroundColor = ConsoleColor.Green;

    Console.Write("What row is your airship on? ");
    int row = Convert.ToInt32(Console.ReadLine());

    Console.Write("What is your target column? ");
    int column = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Deploy to:");

    Console.WriteLine("(" + row + ", " + (column -1) + ")");
    Console.WriteLine("(" + (row - 1) + ", " + column + ")");
    Console.WriteLine("(" + row + ", " + (column + 1)+ ")");
    Console.WriteLine("(" + (row + 1) + ", " + column + ")");

    Console.Beep();
    Console.ReadKey();

}














