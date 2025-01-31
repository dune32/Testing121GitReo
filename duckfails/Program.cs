
Console.WriteLine("How many eggs were there today?");
int length = Convert.ToInt32(Console.ReadLine());

int eggsForEachSister = length / 4; // Will need this explained
int eggsForDuckbear = length % 4; // also unsure

Console.WriteLine("Each Sister gets " + eggsForEachSister + " chocolate eggs.");

Console.WriteLine("The duckbear gets " + eggsForDuckbear + " chocolate eggs.");
