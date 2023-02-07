string CheckMathSkills(int x, int y)
{
    var result = x + y;

    Console.Write($"What is the sum of {x} and {y}?: ");
    int.TryParse(Console.ReadLine(), out var numericalAnswer);

    if (numericalAnswer != result)
    {
        var answer = "Are you daft?";
        return answer;
    }
    else
    {
        var answer = $"{numericalAnswer} is correct!";
        return answer;
    }
}

Console.Write("Please input the value for X: ");
int.TryParse(Console.ReadLine(), out var X);
Console.Write("Please input the value for Y: ");

int.TryParse(Console.ReadLine(), out var Y);
Console.WriteLine();

var answer = CheckMathSkills(X, Y);

Console.WriteLine($"{answer}");