// [x]Ask the user to enter a number from the menu.
// [x]Ask the user to enter a number from the menu.
// [x] Using the information above, use a swith (either type) to show the items cost.

Console.WriteLine("What is your name?");
string name = Console.ReadLine();

//The following items are available:
// 1. Rope
// 2. Torches
// 3. Climbing equipment
// 4. Clean water Matchete
// 5. canoe
// 6. Food supplies
// 7. Matchete

Console.WriteLine("The following are available:");

Console.WriteLine("1. - Rope");
Console.WriteLine("2. - Torches");
Console.WriteLine("3. - Climbing equipment");
Console.WriteLine("4. - Clean water");
Console.WriteLine("5. - Matchete");
Console.WriteLine("6. - Canoe");
Console.WriteLine("7. - Food supplies");
Console.WriteLine("What number do you want to see the price off? ");

float option = Convert.ToInt32(Console.ReadLine());


string itemName = option switch
//Could also use displayText instead of itemName
{
    1 => " A Rope is",
    2 => "A Torche is",
    3 => "A set of Climbing equipment is",
    4 => "1 bottle of Clean water is",
    5 => "1 Matchete is",
    6 => "1 Canoe is",
    7 => "a can of Food supplies is",
    _ => "Invalid option"
};

float cost = option switch
{
    1 => 10,
    2 => 15,
    3 => 25,
    4 => 1,
    5 => 20,
    6 => 200,
    7 => 1,
    _ => 0
};

{ 
if (name == "John")
    cost /= 2;

}


Console.WriteLine($" {itemName} {cost} gold.");