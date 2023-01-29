int GetInteger(string prompt)
{
    while (true)
    {

        Console.WriteLine($"{prompt}: ");

        var answer = Console.ReadLine();

        if (int.TryParse(answer, out int answerIsNumber))
        {
            return answerIsNumber;
        };
    };
};

Console.WriteLine("What's your taste in prompts?");

var inputPrompt = Console.ReadLine();

var number = GetInteger(inputPrompt);

Console.WriteLine($"Your number is {number}.");