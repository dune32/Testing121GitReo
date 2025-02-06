// [x]  ask for an x and a y value
// [] Use an if statement and relational operator.
// [] display a message about what direction the enemy is coming from using the image on the right.

Console.WriteLine("What is the x-coordinate of the enemy?");

//Calls the int from console
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is the y coordinate of the enemy?");
int y = Convert.ToInt32(Console.ReadLine());



// if x = to 0 true of false if true then y y = the enemy is here!
// if false continue to run


if (x == 0 && y == 0) Console.WriteLine("The enemy is here!"); 
if (x == 0 && y > 0) Console.WriteLine("The enemy is to the north!"); 
if (x == 0 && y < 0) Console.WriteLine("The enemy is to the south!"); 
if (x < 0 && y == 0) Console.WriteLine("The enemy is to the east!"); 
if (x > 0 && y == 0) Console.WriteLine("The enemy is to the west!");

 
if (x < 0 && y > 0) Console.WriteLine("The enemy is to the northwest!"); 
if (x > 0 && y > 0) Console.WriteLine("The enemy is to the northeast!"); 
if (x < 0 && y < 0) Console.WriteLine("The enemy is to the southwest!"); 
if (x > 0 && y < 0) Console.WriteLine("The enemy is to the southeast!"); 





