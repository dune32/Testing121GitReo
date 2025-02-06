// [x] if the number is above 100 or less than 0 keep asking.
// [x] clear the screen once the program has collected a good number.
// [x] ask a second user, the hunter, to guess numbers.
// [x] indicate whether the user guessed too high or to low or guessed right.
// [x] Loop until they get it right, then end the program.


int number;
do
{
    Console.Write("User 1,Enter a number between 0 and 100: ");
   number = Convert.ToInt32(Console.ReadLine());
} while (number < 0 || number > 100);

Console.Clear();

Console.WriteLine("User 2, guess the number");
Console.WriteLine("What is your next guess? ");

int guess;

do
{

    guess = Convert.ToInt32(Console.ReadLine());

    if (guess == number) Console.WriteLine("You guessed right!");
    else if (guess > number) Console.WriteLine($"{guess} too high!");
    else Console.WriteLine($"{guess} is to low!");

} while (guess != number);

