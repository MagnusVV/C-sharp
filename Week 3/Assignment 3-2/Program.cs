var random = new Random();
var number = random.Next(1, 99);
var numberTries = 0;

Console.Write("I'm thinking of a number between 1 and 99. Which is it?\n");

while (true)
{
    Console.Write("Guess the number: ");
    var answer = Console.ReadLine();

    numberTries++;
    Console.WriteLine($"Tries: {numberTries}");

    if (numberTries >= 3)
    {
        Console.WriteLine("\nGAME OVER, MAN! GAME OVER!");
        break;
    }

    if (!int.TryParse(answer, out int numericalAnswer))
    {
        Console.WriteLine("That is not a number\n");
        continue;
    }

    if (numericalAnswer > number)
    {
        Console.WriteLine("Too high\n");
        continue;
    }
    if (numericalAnswer < number)
    {
        Console.WriteLine("Too low\n");
        continue;
    }
    if (numericalAnswer == number)
    {
        Console.WriteLine("Correct!");
        break;
    }
}
