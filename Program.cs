using System;
// Without using system we cannot call the mainframes basic functions.


{


    {
        Console.WriteLine("How many estates do you have?");
        int estateCount = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("How many duchies do you have?");
        int duchyCount = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("How many provinces do you have?");
        int provinceCount = Convert.ToInt32(Console.ReadLine());


        int estatePointValue   = 1 * estateCount;
        int duchyPointValue    = 3 * duchyCount;
        int provincePointValue = 6 * provinceCount;

        int total = estatePointValue + provincePointValue + duchyPointValue;

        Console.WriteLine("You have a total of " + total + " points.");

    }
}


 