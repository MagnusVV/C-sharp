var random = new Random();
var number = random.Next(1,99);

Console.Write("I'm thinking of a number between 1 and 99. Which is it? ");

while(true)
{
    Console.WriteLine("Guess the number: ");
    var answer = Console.ReadLine();

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
    else
    {
        Console.WriteLine("Correct!");
        break;
    }
}
